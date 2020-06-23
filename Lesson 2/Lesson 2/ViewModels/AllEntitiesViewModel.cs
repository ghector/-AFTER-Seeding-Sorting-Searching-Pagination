using Lesson_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_2.ViewModels
{
    public class AllEntitiesViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<Card> Cards { get; set; }
        public List<Department> Departments { get; set; }
        public List<Project> Projects { get; set; }

    }
}