using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTQ_tulam.Controllers
{
    public class PTQ_ảnhController : Controller
    {
        private readonly string _imagePath = "~/Content/Images/";

        // GET: Album
        public ActionResult Index()
        {
            var images = Directory.GetFiles(Server.MapPath(_imagePath))
                                  .Select(Path.GetFileName)
                                  .ToList();
            return View(images);
        }

        // GET: Album/Upload
        public ActionResult Upload()
        {
            return View();
        }

        // POST: Album/Upload
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath(_imagePath), fileName);
                file.SaveAs(path);
            }
            return RedirectToAction("Index");
        }

        // POST: Album/Delete
        [HttpPost]
        public ActionResult Delete(string fileName)
        {
            var path = Path.Combine(Server.MapPath(_imagePath), fileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            return RedirectToAction("Index");
        }
    }
}