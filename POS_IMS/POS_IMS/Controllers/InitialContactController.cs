using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_IMS.Controllers
{
    public class InitialContactController : Controller
    {
        // GET: InitialContactController
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
        public ActionResult Create(IFormCollection collection)
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

        // GET: InitialContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InitialContactController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InitialContactController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
