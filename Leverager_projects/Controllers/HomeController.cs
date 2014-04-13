using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Leverager_projects.Models;

namespace Leverager_projects.Controllers
{
    public class HomeController : Controller
    {
        private LeveragerDBContext db = new LeveragerDBContext();

        public ActionResult Index()
        {            
            var Category = from d in db.Categoryes                            
                            select d;            
            var model = Category.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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