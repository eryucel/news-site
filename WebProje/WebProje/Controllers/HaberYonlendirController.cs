using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class HaberYonlendirController : Controller
    {
        // GET: HaberYonlendir
        public ActionResult Index(Haber haber)
        {
            return View(haber);
        }
    }
}