namespace Lesson_2.Migrations
{
    using Lesson_2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lesson_2.Models.ApplicationDbContext>
    {
        public Configuration()
        {

            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Lesson_2.Models.ApplicationDbContext context)
        {
            Department D1 = new Department() { Id = 1, Name = "MIT" };
            Department D2 = new Department() { Id = 2, Name = "Oxford" };
            Department D3 = new Department() { Id = 3, Name = "Garfield" };

            context.Departments.AddOrUpdate(x => x.Name, D1, D2, D3);
            context.SaveChanges();

            Project p1 = new Project() { Title = "C#", StartDate = new DateTime(2020, 5, 5) };
            Project p2 = new Project() { Title = "Java", StartDate = new DateTime(2021, 6, 6) };
            Project p3 = new Project() { Title = "Python", StartDate = new DateTime(2022, 7, 8) };
            Project p4 = new Project() { Title = "Javascript", StartDate = new DateTime(2023, 9, 7) };




            Employee e1 = new Employee()
            {
                Name = "Hector",
                Salary = 50000,
                Age = 33,
                DepartmentId = 1,
                Projects = new List<Project>() { p1, p2, p3, p4 },
                Card = new Card() { Title = "AF 124" }
            };

            Employee e2 = new Employee()
            {

                Name = "Marios",
                Salary = 34000,
                Age = 25,
                DepartmentId = 2,
                Projects = new List<Project>() { p1, p2 },
                Card = new Card() { Title = "WB 264" }
            };

            Employee e3 = new Employee()
            {

                Name = "Petros",
                Salary = 35000,
                Age = 35,
                DepartmentId = 3,
                Projects = new List<Project>() { p1, p4 },
                Card = new Card() { Title = "XV 125" }
            };

            Employee e4 = new Employee()
            {

                Name = "Mitsos",
                Salary = 25000,
                Age = 26,
                DepartmentId = 1,
                Projects = new List<Project>() { p4 },
                Card = new Card() { Title = "SF 247" }
            };
            Employee e5 = new Employee()
            {

                Name = "Makis",
                Salary = 62000,
                Age = 27,
                DepartmentId = 3,
                Projects = new List<Project>() { p1, p4 },
                Card = new Card() { Title = "XC 472" }
            };

            Employee e6 = new Employee()
            {

                Name = "Aliki",
                Salary = 52000,
                Age = 26,
                DepartmentId = 3,
                Projects = new List<Project>() { p4 },
                Card = new Card() { Title = "ZB 357" }
            };

            Employee e7 = new Employee()
            {

                Name = "Giorgos",
                Salary = 25000,
                Age = 25,
                DepartmentId = 3,
                Projects = new List<Project>() { p1, p3, p4 },
                Card = new Card() { Title = "SD 347" }
            };

            Employee e8 = new Employee()
            {

                Name = "Fanis",
                Salary = 35000,
                Age = 35,
                DepartmentId = 2,
                Projects = new List<Project>() { p1, },
                Card = new Card() { Title = "FH 346" }
            };

            Employee e9 = new Employee()
            {

                Name = "Nikos",
                Salary = 40000,
                Age = 46,
                DepartmentId = 1,
                Projects = new List<Project>() { p3, p4 },
                Card = new Card() { Title = "BD 246" }
            };

            Employee e10 = new Employee()
            {

                Name = "Periklis",
                Salary = 55000,
                Age = 47,
                DepartmentId = 1,
                Projects = new List<Project>() { p1, p2, p3, p4 },
                Card = new Card() { Title = "BG 234" }
            };





            context.Employees.AddOrUpdate(x => x.Name, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10);
            context.SaveChanges();
        }
    }
}
