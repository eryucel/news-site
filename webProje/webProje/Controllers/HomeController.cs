using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje.DAL;
using WebProje.Models;
namespace WebProje.Controllers
{
    public class HomeController : Controller
    {
        WebProjeContext db = new WebProjeContext();
        public ActionResult Index()
        {
            var model = new HomeIndexViewModel()
            {
                Haber = db.Haberler.ToList()
            };
            return View(model);
        }
    }
}