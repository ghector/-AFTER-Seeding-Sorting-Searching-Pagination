using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson_2.Models
{
    public class Project
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 30, ErrorMessage = "To onoma prepei na einai metaksi 2 eos 30 xaraktiron", MinimumLength = 2)]
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}