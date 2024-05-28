using PTQ_tulam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTQ_tulam.Controllers
{
    public class PTQ_productController : Controller
    {
        private static List<PTQ_product> products = new List<PTQ_product>();

        // GET: Product
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(PTQ_product product)
        {
            if (ModelState.IsValid)
            {
                if (products.Any(p => p.Id == product.Id))
                {
                    ModelState.AddModelError("Id", "Product ID already exists.");
                    return View(product);
                }

                products.Add(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}