using Lesson_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PagedList;

namespace Lesson_2.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Employee
        public ActionResult Index(string searchName,int? searchSalaryMin, int? searchSalaryMax, int? page)
        {
            var employees = db.Employees.ToList();  //Fertous olous


            

            //Filtering
            if (!String.IsNullOrWhiteSpace(searchName))  //Filtrare kapoious an exei timi to searchname
            {
                employees = employees.Where(x => x.Name.ToUpper().Contains(searchName.ToUpper())).ToList();
            }

            if (!(searchSalaryMin is null))  //searchSalaryMin!=null  //Filtrare kapoious an exei timi to searchSalaryMin
            {
                employees = employees.Where(x => x.Salary >= searchSalaryMin).ToList();
            }

            if (!(searchSalaryMax is null))  //searchSalaryMin!=null   //Filtrare kapoious an exei timi to searchSalaryMax
            {
                employees = employees.Where(x => x.Salary <= searchSalaryMax).ToList();
            }

            //(1) Fere mou aytous pou exoun monaxa ena project 



            int pageSize = 4;
            int pageNumber = page ?? 1;


            return View(employees.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Index2()
        {
            var employee = db.Employees.Find(2);


            return View(employee);
        }

    }
}