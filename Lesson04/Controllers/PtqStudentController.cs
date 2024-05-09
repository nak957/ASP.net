using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTQ.Lesson04.Controllers
{
    public class PtqStudentController : Controller
    {
        // GET: PtqStudent
        public ActionResult Index()
        {
            //truyền dữ liệu từ controller->view
            ViewBag.fullname = "Phạm Thế Quyền";
            ViewBag.Data["Birthday"] = "14 / 11 / 2004";
            TempData["Số điện thoại"] = "0946275289";
            return View();
        }
        public ActionResult Details()
        {
            string ptqStr = "";
            ptqStr += "<h3>Họ và tên:Phạm Thế Quyền</h3>";
            ptqStr += "<p>Mã số:2210900059";
            ptqStr += "<p>Địa chỉ email:phamthequyen1411@gmail.com";
            ViewBag.Details = ptqStr;
            return View("chitiet");  
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Lê Đại C" };
            ViewBag.names = names;
            return View();
        }
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            string fullname = form["FullName"];
            string masv = form["MaSV"];
            string TaiKhoan = form["TaiKhoan"];
            string MatKhau = form["MatKhau"];
            string ptqStr = "<h3>" + fullname + "</h3>";
            ptqStr += "<p>" + masv;
            ptqStr += "<p>" + TaiKhoan;
            ptqStr += "<p>" + MatKhau;
            ViewBag.info = ptqStr;
            return View("KetQua");
        }
    }
}