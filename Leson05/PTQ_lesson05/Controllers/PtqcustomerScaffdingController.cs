using PTQ_lesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTQ_lesson05.Controllers
{
    public class PtqcustomerScaffdingController : Controller
    {
        // GET: PtqcustomerScaffding
        private List<PtqCustomer> listcustomer = new List<PtqCustomer>()
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
        public ActionResult Index()
        {
            return View(listcustomer);
        }
        public ActionResult PtqCreate()
        {
            var model = new PtqCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult PtqCreate(PtqCustomer model)
        {
            listcustomer.Add(model);
            //return View(model);
            return RedirectToAction("index");
        }
        public ActionResult PtqEdit( int id)
        {
            var customer = listcustomer.FirstOrDefault(x=>x.customerId==id);
            return View(customer);
        }
    }
}