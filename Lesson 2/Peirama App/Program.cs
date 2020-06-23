using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_2;
using Lesson_2.Models;

namespace Peirama_App
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            //Console.WriteLine(db.Employees.Count());
            //Console.WriteLine(db.Departments.Count());
            //Console.WriteLine(db.Projects.Count());

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

            //foreach (var item in lista2)
            //{
            //    Console.WriteLine(string.Format("{0,-15}{1,-15}", item.Key,item.Count()));
            //}







         


            ////Gia petama
            //var foo = (from emp in db.Employees
            //          group emp by emp.Department into y
            //          select y).SelectMany(x=>x.Key.;

            //foreach (var item in foo)
            //{
            //    Console.WriteLine(item.Key.Name +"  ");
            //    foreach (var k in item)
            //    {
            //        Console.WriteLine(k.Name);
            //    }
            //}
        }
    }
}
