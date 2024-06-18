using PTQ_lesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTQ_lesson05.Controllers
{
    public class PtqCustomerController : Controller
    {
        // GET: PtqCustomer
        public ActionResult Index()
        {
            return View();
        }
        //Action: PtqCustomerdetail
        public ActionResult PtqCustomerdetail()
        {
            // Tạo đối tượng dữ liệu PtqCustomer
            var customer = new PtqCustomer()
            {
                customerId = 1,
                firstName = "Phạm Thế",
                LastName = "Quyền",
                Address = "K22CNT2",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            
            return View();
        }
        public ActionResult PtqListCustomer()
        {
            var list = new List<PtqCustomer>()
            {
                new PtqCustomer()
                {
                    customerId = 1,
                    firstName = "Phạm Thế",
                    LastName = "Quyền",
                    Address = "K22CNT2",
                    YearOfBirth = 2004
                },
                new PtqCustomer()
                {
                    customerId = 2,
                    firstName = "Nuyễn văn",
                    LastName = "Na",
                    Address = "K22CNT2",
                    YearOfBirth = 2044
                },
                new PtqCustomer()
                {
                    customerId = 2,
                    firstName = "Lê Thị",
                    LastName = "Xoài",
                    Address = "K22CNT2",
                    YearOfBirth = 2043
                },
            };
            //ViewBag.list = list;    // đưa dữ liệu ra view bằng viewbag
            return View(list);  
        }

    }
}