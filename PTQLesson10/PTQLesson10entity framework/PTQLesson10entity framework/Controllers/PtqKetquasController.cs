using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTQLesson10entity_framework.Models;

namespace PTQLesson10entity_framework.Controllers
{
    public class PtqKetquasController : Controller
    {
        private PtqK22CNT2Lesson10DbEntities db = new PtqK22CNT2Lesson10DbEntities();

        // GET: PtqKetquas
        public ActionResult PtqIndex()
        {
            var ptqKetqua = db.PtqKetqua.Include(p => p.PtqSinhVien).Include(p => p.PtqMonHoc);
            return View(ptqKetqua.ToList());
        }

        // GET: PtqKetquas/Details/5
        public ActionResult PtqDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtqKetqua ptqKetqua = db.PtqKetqua.Find(id);
            if (ptqKetqua == null)
            {
                return HttpNotFound();
            }
            return View(ptqKetqua);
        }

        // GET: PtqKetquas/Create
        public ActionResult PtqCreate()
        {
            ViewBag.PtqMaSV = new SelectList(db.PtqSinhVien, "PtqMaSV", "PtqHoSV");
            ViewBag.PtqMaMH = new SelectList(db.PtqMonHoc, "PtqMaMH", "PtqTenMH");
            return View();
        }

        // POST: PtqKetquas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtqCreate([Bind(Include = "PtqMaSV,PtqMaMH,PtqDiem")] PtqKetqua ptqKetqua)
        {
            if (ModelState.IsValid)
            {
                db.PtqKetqua.Add(ptqKetqua);
                db.SaveChanges();
                return RedirectToAction("PtqIndex");
            }

            ViewBag.PtqMaSV = new SelectList(db.PtqSinhVien, "PtqMaSV", "PtqHoSV", ptqKetqua.PtqMaSV);
            ViewBag.PtqMaMH = new SelectList(db.PtqMonHoc, "PtqMaMH", "PtqTenMH", ptqKetqua.PtqMaMH);
            return View(ptqKetqua);
        }

        // GET: PtqKetquas/Edit/5
        public ActionResult PtqEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtqKetqua ptqKetqua = db.PtqKetqua.Find(id);
            if (ptqKetqua == null)
            {
                return HttpNotFound();
            }
            ViewBag.PtqMaSV = new SelectList(db.PtqSinhVien, "PtqMaSV", "PtqHoSV", ptqKetqua.PtqMaSV);
            ViewBag.PtqMaMH = new SelectList(db.PtqMonHoc, "PtqMaMH", "PtqTenMH", ptqKetqua.PtqMaMH);
            return View(ptqKetqua);
        }

        // POST: PtqKetquas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtqEdit([Bind(Include = "PtqMaSV,PtqMaMH,PtqDiem")] PtqKetqua ptqKetqua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptqKetqua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtqIndex");
            }
            ViewBag.PtqMaSV = new SelectList(db.PtqSinhVien, "PtqMaSV", "PtqHoSV", ptqKetqua.PtqMaSV);
            ViewBag.PtqMaMH = new SelectList(db.PtqMonHoc, "PtqMaMH", "PtqTenMH", ptqKetqua.PtqMaMH);
            return View(ptqKetqua);
        }

        // GET: PtqKetquas/Delete/5
        public ActionResult PtqDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtqKetqua ptqKetqua = db.PtqKetqua.Find(id);
            if (ptqKetqua == null)
            {
                return HttpNotFound();
            }
            return View(ptqKetqua);
        }

        // POST: PtqKetquas/Delete/5
        [HttpPost, ActionName("PtqDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PtqKetqua ptqKetqua = db.PtqKetqua.Find(id);
            db.PtqKetqua.Remove(ptqKetqua);
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
