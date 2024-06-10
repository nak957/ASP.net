using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTQlesson08K22CNT2.Models;

namespace PTQlesson08K22CNT2.Controllers
{
    public class PtqBooksController : Controller
    {
        private PtqBookStore db = new PtqBookStore();

        // GET: PtqBooks
        public ActionResult PtqIndex()
        {
            var ptqBooks = db.PtqBooks.Include(p => p.PtqCategory);
            return View(ptqBooks.ToList());
        }

        // GET: PtqBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtqBook ptqBook = db.PtqBooks.Find(id);
            if (ptqBook == null)
            {
                return HttpNotFound();
            }
            return View(ptqBook);
        }

        // GET: PtqBooks/Create
        public ActionResult Create()
        {
            ViewBag.PtqCategoryId = new SelectList(db.PtqCategories, "PtqCategoryId", "PtqCategoryId");
            return View();
        }

        // POST: PtqBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PtqBookId,PtqTitle,PtqAuthor,PtqYear,Ptqpubliser,PtqPicture,PtqCategoryId")] PtqBook ptqBook)
        {
            if (ModelState.IsValid)
            {
                db.PtqBooks.Add(ptqBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PtqCategoryId = new SelectList(db.PtqCategories, "PtqCategoryId", "PtqCategoryId", ptqBook.PtqCategoryId);
            return View(ptqBook);
        }

        // GET: PtqBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtqBook ptqBook = db.PtqBooks.Find(id);
            if (ptqBook == null)
            {
                return HttpNotFound();
            }
            ViewBag.PtqCategoryId = new SelectList(db.PtqCategories, "PtqCategoryId", "PtqCategoryId", ptqBook.PtqCategoryId);
            return View(ptqBook);
        }

        // POST: PtqBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PtqBookId,PtqTitle,PtqAuthor,PtqYear,Ptqpubliser,PtqPicture,PtqCategoryId")] PtqBook ptqBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptqBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PtqCategoryId = new SelectList(db.PtqCategories, "PtqCategoryId", "PtqCategoryId", ptqBook.PtqCategoryId);
            return View(ptqBook);
        }

        // GET: PtqBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtqBook ptqBook = db.PtqBooks.Find(id);
            if (ptqBook == null)
            {
                return HttpNotFound();
            }
            return View(ptqBook);
        }

        // POST: PtqBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PtqBook ptqBook = db.PtqBooks.Find(id);
            db.PtqBooks.Remove(ptqBook);
            db.SaveChanges();
            return RedirectToAction("Index");
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
