using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public decimal Salary { get; set; }

        //Naviagation Properties
        public virtual Card Card { get; set; }

        public virtual int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Project> Projects { get; set; }


    }
}