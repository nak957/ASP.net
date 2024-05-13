using PTQ_lab04._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTQ_lab04._2.Controllers
{
    public class PTQ_CustomerController : Controller
    {
        // GET: PTQ_CustomerController
        public ActionResult Index()
        {
            return View();
        }
        static PTQ_CustomerRepository listCustomer;
        public PTQ_CustomerController()
        {
            listCustomer = new PTQ_CustomerRepository();
        }
        public ActionResult PTQ_GetCustomers()
        {
            return View(listCustomer.GetCustomers());
        }
        [HttpPost]
        public ActionResult PTQ_GetCustomers(string name)
        {
            return View(listCustomer.SearchCustomer(name));
        }
        // GET: /Customer/Details/5
        public ActionResult PTQ_Details(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // GET: /Customer/Create
        public ActionResult PTQ_Create()
        {
            return View();
        }
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult PTQ_Create(PTQ_Customer cus)
        {
            listCustomer.PTQ_AddCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Edit/5
        public ActionResult Edit(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // POST: /Customer/Edit
        [HttpPost]
        public ActionResult Edit(PTQ_Customer cus)
        {
            listCustomer.PTQ_UpdateCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Delete/5
        public ActionResult Delete(string id)
        {
            listCustomer.PTQ_DeleteCustomer(listCustomer.GetCustomer(id));
            return RedirectToAction("GetCustomers");
        }
    }
}

    