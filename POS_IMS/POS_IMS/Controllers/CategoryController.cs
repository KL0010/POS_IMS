using Microsoft.AspNetCore.Mvc;
using POS.Models;
using POS_IMS.Data;
using POS_IMS.Models;
using Python.Runtime;
using System.Security.Cryptography;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Policy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.IO;

namespace POS_IMS.Controllers
{
    public class CategoryController (ApplicationDbContext context) : Controller
    {
        
        // GET: CategoryController
        public ActionResult Index()
        {
            return View(context.Categories.ToList());
        }

        private string GetImgPath(string fileName)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), @"Images\categories\" + fileName);
        }

        private async Task SaveImgUrl(IFormFile file, Category model)
        {
            if (file != null && file.Length > 0)
            {

                using (var stream = new FileStream(GetImgPath(file.FileName), FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                model.ImgPath = "~/Images/categories/" + file.FileName;
            }
        }


        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        [Authorize(Roles = "Admin,SuperAdmin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> CreateAsync([Bind("CategoryName,CategoryDescription,ImgPath")] Category model, IFormFile file)
        {
            ModelState.Remove("ImgPath");
            ModelState.Remove("Blends");

            if (ModelState.IsValid)
            {
                try
                {
                    if (file != null)
                    {
                        Repository repository = new Repository();

                        if (!repository.IsImage(file))
                            ModelState.AddModelError("Path", "The file must be an image (jpeg, jpg, png, or gif).");
                        else if (!repository.IsAllowedExtension(file.FileName))
                            ModelState.AddModelError("Path", "File extensions are not permitted. Please upload files with the extension .jpeg, .jpg, .png, or .gif.");
                        else if (file.Length > 2 * 1024 * 1024) // 2MB
                            ModelState.AddModelError("Path", "Image file size must not exceed 2 MB.");     
                        else
                            await SaveImgUrl(file, model);
                        
                        // your PATH environment variable as well.
                        Runtime.PythonDLL = @"C:\Users\vboxuser\AppData\Local\Programs\Python\Python312\python312.dll";

                        PythonEngine.Initialize();

                        using (Py.GIL())
                        {
                            Init init = new Init();
                            var virusTotal = Py.Import("virus_scan");
                            var path = new PyString(GetImgPath(file.FileName));
                            var apiKey = new PyString(GetImgPath(init.ScanApi));
                            dynamic result = virusTotal.InvokeMethod("scan_file", new PyObject[] { path, apiKey });
                            ScanResult sr = new ScanResult();
                            sr.clean_result = result.clean_result;
                            sr.found_viruses = result.found_viruses;
                            if(! sr.clean_result) // virus found
                            {
                                if (System.IO.File.Exists(GetImgPath(file.FileName))) // Check if file has been saved.
                                    System.IO.File.Delete(GetImgPath(file.FileName)); // Delete file
                            }
                            else
                            {
                                Sanitizer sanatizer = new Sanitizer();
                                model = sanatizer.SanitizeCategoryInputs(model); // Sanatize inputs before commit to DB
                                context.Categories.Add(model);
                                await context.SaveChangesAsync();
                            }
                        }

                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (Exception ex)
                {
                    // Tangani pengecualian, log, dan berikan umpan balik yang sesuai kepada pengguna.
                    ModelState.AddModelError(string.Empty, $"Error: {ex.Message}");
                }
            }
            return View(); // if we have come this far some error has occurred, Return the view.
        }

        // GET: CategoryController/Edit/5
        [Authorize(Roles = "Admin,SuperAdmin")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        [Authorize(Roles = "SuperAdmin")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "SuperAdmin")]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
