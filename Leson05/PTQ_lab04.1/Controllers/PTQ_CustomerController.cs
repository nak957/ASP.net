using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTQ_lab04._1.Models;


namespace PTQ_lab04._1.Controllers
{
    public class PTQ_CustomerController : Controller
    {
        // GET: PTQ_Customer
        public ActionResult CustomerDetail()
        {
            //tạo một đối tượng Customer ( nhớ using Lab04.Models vào nhé)
            PTQ_Customer cus = new PTQ_Customer()
            {
                CustomerId = "KH001",
                FullName = "Phạm Thế Quyền",
                Address = "Hưng Yên",
                Email = "phamthequyen1411@gmail.com",
                Phone = "0772468753",
                Balance = 15200000
            };
            //cách 1 gán dữ liệu vào ViewBag để chuyển tới View
            //ViewBag.customer = cus;
            //return View();
            //có thể truyền dữ liệu qua đối tượng model để chuyển tới View
            return View(cus);
        }
        public ActionResult CustomerList()
        {
            List<PTQ_Customer> listcustomer = new List<PTQ_Customer>()
            {
                new PTQ_Customer(){ CustomerId = "KH001",
                    FullName = "Phạm Thế Quyền",
                    Address = "Ân Thi",Email = "phamthequyen1411@gmail.com",
                    Phone = "0968364242",Balance = 15200000},
                new PTQ_Customer(){ CustomerId = "KH002",
                    FullName = "Đường Huyền Trang",
                    Address = "Đông thổ Đại đường",Email = "duongtam@gmail.com",
                    Phone = "0986.767.444",Balance = 2200000},
                new PTQ_Customer(){ CustomerId = "KH003",
                    FullName = "Tôn Ngộ Không",
                    Address = "Hoa quả sơn",Email = "ngukhu@gmail.com",
                    Phone = "0924.656.542",Balance = 1200000},
                new PTQ_Customer(){ CustomerId = "KH004",
                    FullName = "Trư Bát giới",
                    Address = "Cao Lão Trang",Email = "Thienbongn@gmail.com",
                    Phone = "0996.555.267",Balance = 6200000 }
            };
                ViewBag.listcustomer = listcustomer;
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}