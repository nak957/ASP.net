using PTQlesson08K22CNT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTQlesson08K22CNT2.Controllers
{
    public class PtqCategoryController : Controller
    {
        private static PtqBookStore _PtqBookStore;
        public PtqCategoryController()
        {
            _PtqBookStore = new PtqBookStore();
        }
        // GET: PtqCategory
        public ActionResult PtqIndex()
        {
            var ptqCategory = _PtqBookStore.PtqCategories.ToList();
            return View(ptqCategory);
        }
        [HttpGet]
        public ActionResult PtqCreate()
        {
            var ptqCategory = new PtqCategory();
            return View();
        }
        [HttpPost]
        public ActionResult PtqCreate(PtqCategory ptqCategory)
        {
            _PtqBookStore.PtqCategories.Add(ptqCategory);
            _PtqBookStore.SaveChanges();
            return RedirectToAction("PtqIndex");
        }
    }
}