using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebProje.DAL;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class HaberController : Controller
    {
        private VeriContext db = new VeriContext();

        // GET: Haber
        public ActionResult Index()
        {
            var haberler = db.Haberler.Include(h => h.Admin);
            return View(haberler.ToList());
        }

        // GET: Haber/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Haber haber = db.Haberler.Find(id);
            if (haber == null)
            {
                return HttpNotFound();
            }
            return View(haber);
        }

        // GET: Haber/Create
        public ActionResult Create()
        {
            ViewBag.AdminID = new SelectList(db.Adminler, "AdminID", "Ad");
            return View();
        }

        // POST: Haber/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HaberID,AdminID,Icerik,Foto,Kategori,HaberTarihi,Onay,Baslik,OkunmaSayisi")] Haber haber)
        {
            if (ModelState.IsValid)
            {
                db.Haberler.Add(haber);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AdminID = new SelectList(db.Adminler, "AdminID", "Ad", haber.AdminID);
            return View(haber);
        }

        // GET: Haber/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Haber haber = db.Haberler.Find(id);
            if (haber == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdminID = new SelectList(db.Adminler, "AdminID", "Ad", haber.AdminID);
            return View(haber);
        }

        // POST: Haber/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HaberID,AdminID,Icerik,Foto,Kategori,HaberTarihi,Onay,Baslik,OkunmaSayisi")] Haber haber)
        {
            if (ModelState.IsValid)
            {
                db.Entry(haber).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AdminID = new SelectList(db.Adminler, "AdminID", "Ad", haber.AdminID);
            return View(haber);
        }

        // GET: Haber/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Haber haber = db.Haberler.Find(id);
            if (haber == null)
            {
                return HttpNotFound();
            }
            return View(haber);
        }

        // POST: Haber/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Haber haber = db.Haberler.Find(id);
            db.Haberler.Remove(haber);
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
