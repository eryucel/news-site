using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        [HttpGet]
        public ActionResult UyeGiris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeGiris(Uye model)
        {
            return View();
        }
    }
}