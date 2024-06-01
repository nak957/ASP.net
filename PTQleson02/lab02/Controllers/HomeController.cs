using lab02.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace lab02.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        //Action trả về một View là một trang html và nó có thể truyền thamsố hoă model

        public ViewResult TestViewResult()
        {
            return View();
        }
        //Action trả về một PartialViewResult
        public PartialViewResult TestPartialViewResult()
        {
            return PartialView();
        }
        //Action trả về một View trống (null)
        public EmptyResult TestEmptyResult()
        {
            return new EmptyResult();
        }
        // Action đáp ứng việc chuyển trực tiếp tới một view khác
        public RedirectResult TestRedirectResult()
        {
            return Redirect("Index");

        }
        public JsonResult TestJsonResult()
        {
            List<ptq_student> listStudent = new List<ptq_student>();
            listStudent.Add(new ptq_student() { ID = 001, Name = "Phạm Thế Quyền", Classname = "K22CNT2" });
            listStudent.Add(new ptq_student() { ID = 001, Name = "Nguyễn QuangHuy", Classname = "C1311L" });
            listStudent.Add(new ptq_student() { ID = 001, Name = "Lê Huy Hải", Classname = "C13123L" });
            listStudent.Add(new ptq_student() { ID = 001, Name = "Tân Bi Đà", Classname = "C1311L" });
            listStudent.Add(new ptq_student() { ID = 001, Name = "Gia Bình", Classname = "C1334w" });
            listStudent.Add(new ptq_student() { ID = 001, Name = "Trần Thị Huyền Trang", Classname = "a7311L" });
            listStudent.Add(new ptq_student() { ID = 001, Name = "Tạ tốn", Classname = "i4311L" });
            listStudent.Add(new ptq_student() { ID = 001, Name = "Nguyễn QuangHuy", Classname = "C1311L" });

            return Json(listStudent, JsonRequestBehavior.AllowGet);
        }
        //Action trả về một view là JavaScript
        public JavaScriptResult TestJavaScriptResult()
        {
            string js = "funtion checkEMail(){var btloc=/^([w-]+(?:.[w-]+)*)@((?:[w -] +.) * w[w -]{ 0,66}).([a - z]{ 2,6} (?:.[a - z]{ 2})?)$/ iif (btloc.test(mail)) { kq = true; }else{ alert(“Email address invalid”);kq = false;}return kq;}";
            return JavaScript(js);
        }
        //Acion tra về một ContentResult dữ liệu là dạng văn bản
        public ContentResult TestContentResult()
        {
            XElement contentXML = new XElement("Students",
            new XElement("Student",
            new XElement("ID", "001"),
            new XElement("FullName", "Nguyễn Viết Nam"),
            new XElement("ClassName", "C1308H")),
            new XElement("Student",
            new XElement("ID", "002"),
            new XElement("FullName", "Nguyễn Hoàng Anh"),
            new XElement("ClassName", "C1411P")),
            new XElement("Student",
            new XElement("ID", "003"),
            new XElement("FullName", "Phạm Ngọc Anh"),
            new XElement("ClassName", "C1411L")),
            new XElement("Student",
            new XElement("ID", "004"),
            new XElement("FullName", "Trần Ngọc Linh"),
            new XElement("ClassName", "C1411H")),
            new XElement("Student",
            new XElement("ID", "005"),
            new XElement("FullName", "Nguyễn Hồng Anh"),
            new XElement("ClassName", "C1411L")));
            return Content(contentXML.ToString(), "text/xml", Encoding.UTF8);

        }
        public FileContentResult TestFileContentResult()
        {
            byte[] fileBytes =
            System.IO.File.ReadAllBytes(Server.MapPath("~/Content/taoanhdep_khung_rank_11544.jpg"));
            string fileName = "taoanhdep_khung_rank_11544.jpg";

            return File(fileBytes, "pictures/jpg", fileName);

        }
        public FileStreamResult TestFileStreamResult()
        {
            string pathFile = Server.MapPath("~/Content/vonsong.docx");
            string fileName = "vonsong.docx";
            return File(new FileStream(pathFile, FileMode.Open),
            "text/doc", fileName);
        }
        public FilePathResult TestFilePathResult()
        {
            string pathFile = Server.MapPath("~/Content/vonsong.docx");        
            string fileName = "vonsong.docx";
            return File(pathFile, "text/doc", fileName);
        }

    }
}