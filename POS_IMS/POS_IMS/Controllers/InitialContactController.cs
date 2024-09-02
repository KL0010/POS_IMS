using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS.Models;
using POS_IMS.Data;
using POS_IMS.Models;
using System.Configuration;
using System.Web;
using Twilio.Types;

namespace POS_IMS.Controllers
{
    public class InitialContactController(ApplicationDbContext context) : Controller
    {
        private ApplicationDbContext context = context;

        public ActionResult Index()
        {
            return View();
        }

        // GET: InitialContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InitialContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InitialContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(InitialContact initialContact)
        {
            Sanitizer sanitizer = new Sanitizer();
            
            if (ModelState.IsValid)
            {
                initialContact = sanitizer.SanitizeContact(initialContact);
                if(context.IntialContacts.Any(x => x.Email == initialContact.Email))
                {
                    ViewBag.Email = "Email provided already exist.";
                    return View();
                }
                context.IntialContacts.Add(initialContact);
                context.SaveChanges();
            }

            return Redirect("/Identity/Account/Register?=" + initialContact.Email);

        }

        // GET: InitialContactController/Edit/5
        [Authorize(Roles = "SuperAdmin")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InitialContactController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "SuperAdmin")]
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

        // GET: InitialContactController/Delete/5
        [Authorize(Roles = "SuperAdmin")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InitialContactController/Delete/5
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
