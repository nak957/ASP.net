using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Text;
namespace lesson2.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        public ViewResult TestViewResult()
        {
            return View();
        }
        public PartialViewResult TestPartialViewResult()
        {
            return PartialView();
        }
        public EmptyResult TestEmptyResult()
        {
            return new EmptyResult();
        }
        public RedirectResult TestRedirectResult()
        {
            return Redirect("Index");

        }
        public JsonResult TestJsonResult()
        {
            List<Student> listStudent = new List<Student>();

            listStudent.Add(new Student{ID = 001,Name = "Nguyễn QuangHuy", ClassName = "C1311L" });
            listStudent.Add(new Student{ ID = 001, Name = "Nguyễn QuangDuy", ClassName = "C1311J" });
            listStudent.Add(new Student { ID = 001, Name = "Nguyễn Quang Hiển", ClassName = "C1311H" });
            listStudent.Add(new Student { ID = 001, Name = "Nguyễn Duy Huân", ClassName = "C1311T" });
            listStudent.Add(new Student { ID = 001, Name = "Trần Thị Huyền Trang", ClassName = "C1311R" });

            return Json(listStudent, JsonRequestBehavior.AllowGet);
        }
        public JavaScriptResult TestJavaScriptResult()
        {
            string js = "funtion checkEMail(){var btloc=/^([w-]+(?:.[w-]+)*)@((?:[w -] +.) * w[w -]{ 0,66}).([a - z]{ 2,6} (?:.[a - z]{ 2})?)$/ iif (btloc.test(mail)) { kq = true; }else{alert(“Email address invalid”);kq = false;}return kq;}";
        return JavaScript(js);
        }
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
            System.IO.File.ReadAllBytes(Server.MapPath("~/Content/Tay Vớt Ánh Trăng - Haozi.mp3"));
            string fileName = "EM QUA KHO DAI - Haozi Remix.mp3";
            return File(fileBytes,
            System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            return File(fileBytes, "Music/mp3", fileName);
        }
       
        public FilePathResult TestFilePathResult()
        {
            string pathFile = Server.MapPath("~/Content/vonsong.docx");
            string fileName = "vonsong.docx";
            return File(pathFile, "text/doc", fileName);
        }


        }
}