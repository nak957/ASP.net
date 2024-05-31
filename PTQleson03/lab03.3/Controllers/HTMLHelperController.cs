using lab03._3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab03._3.Controllers
{
    public class HTMLHelperController : Controller
    {
        public ActionResult FormRegister()
        {
            // tạo list cho droplist
            ViewBag.listCountry = new List<ptqCountry>() {
                new ptqCountry(){ID="0",Name="-- Chọn Quốc Gia --"},
                new ptqCountry(){ID="VN",Name="Việt Nam"},
                new ptqCountry(){ID="AT",Name="AUSTRALIA"},
                new ptqCountry(){ID="UK",Name="Anh"},
                new ptqCountry(){ID="FR",Name="Pháp"},
                new ptqCountry(){ID="US",Name="Mỹ"},
                new ptqCountry(){ID="KP",Name="Hàn Quốc"},
                new ptqCountry(){ID="HU",Name="Hồng Kong"},
                new ptqCountry(){ID="PTQ",Name="Phạm Thế Quyền"},
                };
            return View();
        }
        public ActionResult Register()
        {
            // lấy giá trị được các trường đẩy lên server khi submit
            string fvr = "";
            TempData["UName"] = Request["txtUName"];
            TempData["Pass"] = Request["txtPass"];
            TempData["FName"] = Request["txtFName"];
            TempData["Gender"] = Request["Gender"].ToString();
            TempData["Address"] = Request["txtAddress"];
            TempData["Email"] = Request["txtEmail"];
            TempData["Country"] = Request["Country"];

            if (Request["Reading"].ToString().Contains("true")) fvr
            += "Reading ,";
            if (Request["Shopping"].ToString().Contains("true")) fvr +=
            "Shopping ,";
            if (Request["Sport"].ToString().Contains("true")) fvr += "Sport,";

            TempData["Favourist"] = fvr;

            return View();
        }
    }

}
