using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtqK22CNT2Lesson11Db.Models;

namespace PtqK22CNT2Lesson11Db.Controllers
{
    public class PtqtaikhoansController : Controller
    {
        private PtqK22CNT2lesson11DbEntities db = new PtqK22CNT2lesson11DbEntities();

        // GET: Ptqtaikhoans
        public ActionResult PtqIndex()
        {
            return View(db.Ptqtaikhoan.ToList());
        }

        // GET: Ptqtaikhoans/Details/5
        public ActionResult PtqDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ptqtaikhoan ptqtaikhoan = db.Ptqtaikhoan.Find(id);
            if (ptqtaikhoan == null)
            {
                return HttpNotFound();
            }
            return View(ptqtaikhoan);
        }

        // GET: Ptqtaikhoans/Create
        public ActionResult PtqCreate()
        {
            return View();
        }

        // POST: Ptqtaikhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtqCreate([Bind(Include = "Ptqid,PtqUserName,PtqPassword,PtqfullName,PtqAge,PtqEmail,PtqPhone,PtqStatus")] Ptqtaikhoan ptqtaikhoan)
        {
            if (ModelState.IsValid)
            {
                db.Ptqtaikhoan.Add(ptqtaikhoan);
                db.SaveChanges();
                return RedirectToAction("PtqIndex");
            }

            return View(ptqtaikhoan);
        }

        // GET: Ptqtaikhoans/Edit/5
        public ActionResult PtqEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ptqtaikhoan ptqtaikhoan = db.Ptqtaikhoan.Find(id);
            if (ptqtaikhoan == null)
            {
                return HttpNotFound();
            }
            return View(ptqtaikhoan);
        }

        // POST: Ptqtaikhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtqEdit([Bind(Include = "Ptqid,PtqUserName,PtqPassword,PtqfullName,PtqAge,PtqEmail,PtqPhone,PtqStatus")] Ptqtaikhoan ptqtaikhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptqtaikhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtqIndex");
            }
            return View(ptqtaikhoan);
        }

        // GET: Ptqtaikhoans/Delete/5
        public ActionResult PtqDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ptqtaikhoan ptqtaikhoan = db.Ptqtaikhoan.Find(id);
            if (ptqtaikhoan == null)
            {
                return HttpNotFound();
            }
            return View(ptqtaikhoan);
        }

        // POST: Ptqtaikhoans/Delete/5
        [HttpPost, ActionName("PtqDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ptqtaikhoan ptqtaikhoan = db.Ptqtaikhoan.Find(id);
            db.Ptqtaikhoan.Remove(ptqtaikhoan);
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
