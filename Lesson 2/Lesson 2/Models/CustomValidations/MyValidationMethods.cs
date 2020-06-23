using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson_2.Models.CustomValidations
{
    public class MyValidationMethods
    {
        public static ValidationResult ValidateGreaterOrEqualToZero(decimal value,ValidationContext context)
        {
            bool isValid = true;

            if(value<=0)
            {
                isValid = false;
            }

            if(isValid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format("To pedio {0} prepei na einai megaliteros apo miden", context.MemberName), new List<string> { context.MemberName });
            }



        }


    }
}