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
    public class KayitOlController : Controller
    {
        private VeriContext db = new VeriContext();

       
        

        // GET: KayitOl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KayitOl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UyeID,Ad,Soyad,KulAdi,EPosta,Sifre,UyelikTarihi")] Uye uye)
        {
            bool epostaVarMi=true,kulAdiVarMi=true;
            var kontrol = db.Uyeler.ToList();
            foreach (var knt in kontrol)
            {
                if (knt.EPosta==uye.EPosta)
                {
                    epostaVarMi = false;
                }
            }
            foreach (var knt in kontrol)
            {
                if (knt.KulAdi == uye.KulAdi)
                {
                    kulAdiVarMi= false;
                }
            }
            if (ModelState.IsValid&&epostaVarMi&&kulAdiVarMi)
            {
                uye.UyelikTarihi = DateTime.Now;
                db.Uyeler.Add(uye);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index","Home");
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
