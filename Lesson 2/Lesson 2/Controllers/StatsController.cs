using Lesson_2.Models;
using Lesson_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_2.Controllers
{
    public class StatsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Stats
        public ActionResult Index()
        {
            var lista = from emp in db.Employees
                        from pro in emp.Projects
                        select new
                        {
                            employeeName = emp.Name,
                            projectName = pro.Title
                        };

            var lista2 = from i in lista
                         group i.employeeName by i.projectName into y
                         select y;

            StatsViewModel vm = new StatsViewModel()
            {
                ProjectsCount = db.Projects.Count(),
                DepartmentsCount = db.Departments.Count(),
                EmployeesCount = db.Employees.Count(),
                EmployeesPerProject = lista2
            };



            return View(vm);
        }
    }
}