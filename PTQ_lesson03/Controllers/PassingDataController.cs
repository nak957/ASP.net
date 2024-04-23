using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTQ_lesson03.Controllers
{
    public class PassingDataController : Controller
    {
        public ActionResult VewDataTest()
        {
            ViewData["message1"] = "ViewData chỉ tồn tại trong một Request vàgiá trị trở về null khi chuyển hướng(Redirect)";
            ViewData["message2"] = "ViewData yêu cầu chuyển kiểu dữ liệu vàkiểm ta null để tránh lỗi";
            string[] students = { "Na", "Xoài", "Ổi", "Nho" };
            ViewData["student"] = students;
            return View();
        }
        public ActionResult VewBagTest()
        {
            // ViewBag là biến trung gian dùng để truyền dữ liệu từ cont
            ViewBag.message1 = "ViewBag chỉ tồn tại trong một Request và giátrị trở về null khi chuyển hướng(Redirect)";
            ViewBag.message2 = "ViewBag yêu cầu chuyển kiểu dữ liệu và kiểm tanull để tránh lỗi";
            string[] students = { "Hạnh", "Tuyên", "Thủy", "Tiến" };
            ViewBag.students = students;
            return View();
        }
        public ActionResult TempDataTest()
        {
            TempData["message1"] = "TempData có thể truyền dữ liệu từ requesthiện tại tới chuỗi các request con khi sử dụng Redirect";
            TempData["message2"] = "TempData yêu cầu chuyển kiểu dữ liệu vàkiểm ta null để tránh lỗi";
            ViewBag.message1 = "Dữ liệu từ ViewBag";
            ViewData["message1"] = "Dữ liệu từ ViewData";
            return Redirect("~/PassingData/About");
        }
        public ActionResult About()
        {
            return View();
        }
    }
}