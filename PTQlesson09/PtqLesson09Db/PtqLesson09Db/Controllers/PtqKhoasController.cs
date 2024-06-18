using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtqLesson09Db.Models;

namespace PtqLesson09Db.Controllers
{
    public class PtqKhoasController : Controller
    {
        private PtqK22CNT2Lesson09DbEntities db = new PtqK22CNT2Lesson09DbEntities();

        // GET: PtqKhoas
        public ActionResult PtqIndex()
        {
            return View(db.ptqKhoa.ToList());
        }

        // GET: PtqKhoas/Details/5
        public ActionResult PtqDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ptqKhoa ptqKhoa = db.ptqKhoa.Find(id);
            if (ptqKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ptqKhoa);
        }

        // GET: PtqKhoas/Create
        public ActionResult PtqCreate()
        {
            return View();
        }

        // POST: PtqKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtqCreate([Bind(Include = "PtqMaKH,PtqTenKH,PtqTranngThai")] ptqKhoa ptqKhoa)
        {
            if (ModelState.IsValid)
            {
                db.ptqKhoa.Add(ptqKhoa);
                db.SaveChanges();
                return RedirectToAction("PtqIndex");
            }

            return View(ptqKhoa);
        }

        // GET: PtqKhoas/Edit/5
        public ActionResult PtqEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ptqKhoa ptqKhoa = db.ptqKhoa.Find(id);
            if (ptqKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ptqKhoa);
        }

        // POST: PtqKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtqEdit([Bind(Include = "PtqMaKH,PtqTenKH,PtqTranngThai")] ptqKhoa ptqKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptqKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtqIndex");
            }
            return View(ptqKhoa);
        }

        // GET: PtqKhoas/Delete/5
        public ActionResult PtqDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ptqKhoa ptqKhoa = db.ptqKhoa.Find(id);
            if (ptqKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ptqKhoa);
        }

        // POST: PtqKhoas/Delete/5
        [HttpPost, ActionName("PtqDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ptqKhoa ptqKhoa = db.ptqKhoa.Find(id);
            db.ptqKhoa.Remove(ptqKhoa);
            db.SaveChanges();
            return RedirectToAction("PtqIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
