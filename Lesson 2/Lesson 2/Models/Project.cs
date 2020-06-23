using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_2.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}