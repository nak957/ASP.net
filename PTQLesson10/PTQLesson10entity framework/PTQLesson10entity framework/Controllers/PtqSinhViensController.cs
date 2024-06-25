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
    public class PtqSinhViensController : Controller
    {
        private PtqK22CNT2Lesson10DbEntities db = new PtqK22CNT2Lesson10DbEntities();

        // GET: PtqSinhViens
        public ActionResult PtqIndex()
        {
            var ptqSinhVien = db.PtqSinhVien.Include(p => p.PtqKhoa);
            return View(ptqSinhVien.ToList());
        }

        // GET: PtqSinhViens/Details/5
        public ActionResult PtqDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtqSinhVien ptqSinhVien = db.PtqSinhVien.Find(id);
            if (ptqSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(ptqSinhVien);
        }

        // GET: PtqSinhViens/Create
        public ActionResult PtqCreate()
        {
            ViewBag.PtqMaKH = new SelectList(db.PtqKhoa, "PtqMaKH", "PtqTenKH");
            return View();
        }

        // POST: PtqSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtqCreate([Bind(Include = "PtqMaSV,PtqHoSV,PtqTenSV,PtqPhai,PtqNgaySinh,PtqNoiSinh,PtqMaKH,PtqHocBong,PtqDiemTrungBinh")] PtqSinhVien ptqSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.PtqSinhVien.Add(ptqSinhVien);
                db.SaveChanges();
                return RedirectToAction("PtqIndex");
            }

            ViewBag.PtqMaKH = new SelectList(db.PtqKhoa, "PtqMaKH", "PtqTenKH", ptqSinhVien.PtqMaKH);
            return View(ptqSinhVien);
        }

        // GET: PtqSinhViens/Edit/5
        public ActionResult PtqEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtqSinhVien ptqSinhVien = db.PtqSinhVien.Find(id);
            if (ptqSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.PtqMaKH = new SelectList(db.PtqKhoa, "PtqMaKH", "PtqTenKH", ptqSinhVien.PtqMaKH);
            return View(ptqSinhVien);
        }

        // POST: PtqSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtqEdit([Bind(Include = "PtqMaSV,PtqHoSV,PtqTenSV,PtqPhai,PtqNgaySinh,PtqNoiSinh,PtqMaKH,PtqHocBong,PtqDiemTrungBinh")] PtqSinhVien ptqSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptqSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtqIndex");
            }
            ViewBag.PtqMaKH = new SelectList(db.PtqKhoa, "PtqMaKH", "PtqTenKH", ptqSinhVien.PtqMaKH);
            return View(ptqSinhVien);
        }

        // GET: PtqSinhViens/Delete/5
        public ActionResult PtqDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtqSinhVien ptqSinhVien = db.PtqSinhVien.Find(id);
            if (ptqSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(ptqSinhVien);
        }

        // POST: PtqSinhViens/Delete/5
        [HttpPost, ActionName("PtqDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PtqSinhVien ptqSinhVien = db.PtqSinhVien.Find(id);
            db.PtqSinhVien.Remove(ptqSinhVien);
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
