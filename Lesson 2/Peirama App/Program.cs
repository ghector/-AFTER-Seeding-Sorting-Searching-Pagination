using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Lesson_2;
using Lesson_2.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Peirama_App
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            #region Connected Senario

            //Connected Senario

            // (1) Insert or Create
            //Department d1 = new Department() { Name = "Mixalis" };
            //db.Departments.Add(d1);  //Insert or Create

            // (2) Find ela kai bres

            //var result1 = db.Departments.Find(1);
            //var result2 = db.Departments.First(x => x.Name == "Mixalis2");  //Problem : An den breis to Mixalis2 
            //var result3 = db.Departments.FirstOrDefault(x => x.Id == 5);  //Problem : An den breis to Mixalis2 

            //if(!(result3==null))
            //{
            //    Console.WriteLine(result3.Name);
            //}

            // (3) Edit or Modify or Update
            //var result1 = db.Departments.Find(1);
            //result1.Name = "Ektoras2";
            //db.SaveChanges();

            // (4) Delete
            //var result1 = db.Departments.Find(1);
            //db.Departments.Remove(result1);
            //db.SaveChanges();

            #endregion

            #region Disconnected Senario
            // (1) Apodiksi tou State added & unchanged
            //Department d1 = new Department() { Name = "Mily Cyrous" };
            //Department d2 = new Department() { Name = "Mily Cyrous" };
            //Department d3= new Department() { Name = "Mily Cyrous" };

            //db.Entry(d1).State = EntityState.Added;
            //db.Entry(d2).State = EntityState.Added;
            //db.Entry(d2).State = EntityState.Added;
            //db.Entry(d2).State = EntityState.Added;
            //db.Entry(d2).State = EntityState.Added;
            //db.Entry(d2).State = EntityState.Added;

            // (2) To entity den parakolouthei pia!
            //db.Entry(result).State = EntityState.Detached;   

            // (3) Edit or Update
            //var result = db.Departments.Find(1);
            //result.Name = "Lila Paouzer";
            //db.Entry(result).State = EntityState.Modified;

            // (4) Delete
            //var result = db.Departments.Find(1);
            //db.Entry(result).State = EntityState.Deleted;
            //db.SaveChanges();

            #endregion


            Department D1 = new Department() { Id = 1, Name = "MIT2020" };
            Department D2 = new Department() { Id = 2, Name = "Oxford2020" };
            Department D3 = new Department() { Id = 3, Name = "Garfield2020" };




            Project p1 = new Project() { Title = "C#2020", StartDate = new DateTime(2020, 5, 5) };
            Project p2 = new Project() { Title = "Java2020", StartDate = new DateTime(2021, 6, 6) };
            Project p3 = new Project() { Title = "Python2020", StartDate = new DateTime(2022, 7, 8) };
            Project p4 = new Project() { Title = "Javascript2020", StartDate = new DateTime(2023, 9, 7) };




            Employee e1 = new Employee()
            {
                Name = "Hector2020",
                Salary = 500002020,
                Age = 33,
                Department = D1,
                Projects = new List<Project>() { p1, p2, p3, p4 },
                Card = new Card() { Title = "AF 124" }
            };

            db.Employees.Add(e1);





            foreach (var entity in db.ChangeTracker.Entries())
            {
                Console.WriteLine("{0}: {1}", entity.Entity.GetType().Name, entity.State);
            }

            //db.SaveChanges();



            //foreach (var entity in db.ChangeTracker.Entries())
            //{
            //    Console.WriteLine("{0}: {1}", entity.Entity.GetType().Name, entity.State);
            //}



            //Console.WriteLine("=============================");
            //foreach (var dep in db.Departments)
            //{
            //    Console.WriteLine(dep.Name);
            //}






            ////Console.WriteLine(db.Employees.Count());
            ////Console.WriteLine(db.Departments.Count());
            ////Console.WriteLine(db.Projects.Count());

            //var lista = from emp in db.Employees
            //            from pro in emp.Projects
            //            select new
            //            {
            //                employeeName = emp.Name,
            //                projectName = pro.Title
            //            };

            //var lista2 = from i in lista
            //             group i.employeeName by i.projectName into y
            //             select y;

            ////foreach (var item in lista2)
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
