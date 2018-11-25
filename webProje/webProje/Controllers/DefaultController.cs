using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webProje.Models;
using webProje.ViewModels;

namespace webProje.Controllers
{
    public class DefaultController : Controller
    {
        haberEntities db = new haberEntities();
        public ActionResult Index()
        {
            var model = new IndexViewModel()
            {
                Haberler = db.Haber.ToList()
            };
            return View(model);
        }
    }
}