using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson2_2.Controllers
{
    public class Pham_The_QuyenController : Controller
    {
        // GET: Pham_The_Quyen
        public ActionResult ShowProduct()
        {
            return View();
        }
        // GET: Action sửa sản phẩm
        public ActionResult EditProduct(int? productId)
        {
            ViewBag.id = productId;
            return View();
        }
        //GET: Action chi tiết sản phẩm
        public ActionResult DetailsProduct(string productName, int? productId)
        {
            ViewBag.name = productName;
            ViewBag.id = productId;
            return View();
        }
    }
}