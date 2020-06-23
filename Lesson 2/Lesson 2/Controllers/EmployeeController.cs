using Lesson_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_2.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Employee
        public ActionResult Index()
        {
            var employees = db.Employees.ToList();


            return View(employees);
        }

        public ActionResult Index2()
        {
            var employee = db.Employees.Find(2);


            return View(employee);
        }

    }
}