using Lesson_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PagedList;
using Antlr.Runtime.Misc;

namespace Lesson_2.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Employee
        public ActionResult Index(string searchName, int? searchSalaryMin, int? searchSalaryMax, int? page)
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

        //Gia petama
        public ActionResult Index2()
        {
            var employee = db.Employees.Find(2);


            return View(employee);
        }

        public ActionResult IndexAdmin(string sortOrder,string searchname,string searchcard,string searchdepartment,int? searchAgeMin,int? searchAgeMax,string searchproject, int? page,int? size)
        {
            var employees = db.Employees.ToList();


      






            var maxAge= employees.Max(x => x.Age);

            ViewBag.searchname = searchname;
            ViewBag.searchcard = searchcard;
            ViewBag.searchdepartment = searchdepartment;
            ViewBag.searchAgeMin = searchAgeMin;
            ViewBag.searchAgeMax = searchAgeMax;
            ViewBag.searchproject = searchproject;
            ViewBag.maxAge = maxAge;
            ViewBag.size = size;


            ViewBag.NameSortParam = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.AgeSortParam = sortOrder== "age_asc" ? "age_desc" : "age_asc";
            ViewBag.CardSortParam = sortOrder== "card_asc" ? "card_desc" : "card_asc";
            ViewBag.IdSortParam = sortOrder== "id_asc" ? "id_desc" : "id_asc";
            ViewBag.SalarySortParam = sortOrder== "salary_asc" ? "salary_desc" : "salary_asc";
            ViewBag.DepartmentSortParam = sortOrder== "department_asc" ? "department_desc" : "department_asc";
            ViewBag.ProjectSortParam = sortOrder== "project_asc" ? "project_desc" : "project_asc";


            if(!string.IsNullOrWhiteSpace(searchname))
            {
                employees = employees.Where(x => x.Name.ToUpper().Contains(searchname.ToUpper())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(searchcard))
            {
                employees = employees.Where(x =>x.Card.Title.ToUpper().Contains(searchcard.ToUpper())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(searchdepartment))
            {
                employees = employees.Where(x => x.Department.Name.ToUpper().Contains(searchdepartment.ToUpper())).ToList();
            }


            if (!(searchAgeMin is null))
            {
                employees = employees.Where(x => x.Age>=searchAgeMin).ToList();
            }

            if (!(searchAgeMax is null))
            {
                employees = employees.Where(x => x.Age <= searchAgeMax).ToList();
            }

            if (!string.IsNullOrWhiteSpace(searchproject))
            {
                employees = employees.Where(x => x.Projects.Any(y => y.Title.Contains(searchproject))).ToList();
            }




            switch (sortOrder)
            {
                case "name_desc": employees = employees.OrderByDescending(x => x.Name).ToList(); break;
                case "age_desc": employees = employees.OrderByDescending(x => x.Age).ToList(); break;
                case "age_asc": employees = employees.OrderBy(x => x.Age).ToList(); break;
                case "card_desc": employees = employees.OrderByDescending(x => x.Card.Title).ToList(); break;
                case "card_asc": employees = employees.OrderBy(x => x.Card.Title).ToList(); break;
                case "id_desc": employees = employees.OrderByDescending(x => x.Id).ToList(); break;
                case "id_asc": employees = employees.OrderBy(x => x.Id).ToList(); break;
                case "salary_desc": employees = employees.OrderByDescending(x => x.Salary).ToList(); break;
                case "salary_asc": employees = employees.OrderBy(x => x.Salary).ToList(); break;
                case "department_desc": employees = employees.OrderByDescending(x => x.Department.Name).ToList(); break;
                case "department_asc": employees = employees.OrderBy(x => x.Department.Name).ToList(); break;
                case "project_desc": employees = employees.OrderByDescending(x => x.Projects.First().Title).ToList();break;
                case "project_asc": employees = employees.OrderBy(x => x.Projects.First().Title).ToList();break;
                

                default: employees = employees.OrderBy(x => x.Name).ToList(); break;

            }




            int pageSize = size ?? 3;
            int pageNumber = page ?? 1;
            return View(employees.ToPagedList(pageNumber, pageSize));
        }



    }












}