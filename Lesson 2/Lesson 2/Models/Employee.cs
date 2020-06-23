using Lesson_2.Models.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson_2.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 30, ErrorMessage = "To onoma prepei na einai metaksi 2 eos 30 xaraktiron", MinimumLength = 2)]
        public string Name { get; set; }

        [Range(minimum: 0, maximum: 120, ErrorMessage = "I ilikia prepei na einai apo 0 eos 120")]
        public byte Age { get; set; }

        [CustomValidation(typeof(MyValidationMethods), "ValidateGreaterOrEqualToZero")]
        public decimal Salary { get; set; }

        //Naviagation Properties
        public virtual Card Card { get; set; }

        public virtual int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Project> Projects { get; set; }


    }
}