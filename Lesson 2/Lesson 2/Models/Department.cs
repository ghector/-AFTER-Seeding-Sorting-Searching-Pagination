using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

     
        public virtual ICollection<Employee> Employees { get; set; }
    }
}