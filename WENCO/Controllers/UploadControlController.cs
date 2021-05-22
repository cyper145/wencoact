using System.Web.Mvc;

namespace WENCO.Controllers
{

    public class UploadControlController : Controller
    {
        // GET: UploadControl
        public ActionResult Index()
        {
            return View();
        }

        // GET: UploadControl/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UploadControl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UploadControl/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UploadControl/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UploadControl/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UploadControl/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UploadControl/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
