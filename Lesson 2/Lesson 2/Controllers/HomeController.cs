using Lesson_2.Models;
using Lesson_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_2.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            AllEntitiesViewModel vm = new AllEntitiesViewModel()
            {
                Employees = db.Employees.ToList(),
                Departments = db.Departments.ToList(),
                Projects = db.Projects.ToList(),
                Cards = db.Cards.ToList()
            };

            return View(vm);
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