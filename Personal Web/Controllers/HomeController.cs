using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;
using Personal_Web.Models;
namespace Personal_Web.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();

        public async Task<ActionResult> Index()
        {
            var departments = from c in db.Departments select c;

            return View(await departments.ToListAsync());


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
    }
}