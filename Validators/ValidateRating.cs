using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MvcGame.Validators
{
    public class ValidateRating : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null)
                return new ValidationResult("");
            Regex rgx = new Regex(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$");
            if(rgx.IsMatch(value.ToString()) && value.ToString().Length <= 5)
            {
                    return ValidationResult.Success;
            }
            else
            {
                    return new ValidationResult("Wrong rating value (" + @"^[A-Z]+[a-zA-Z0-9""'\s-]*$" + ").");
            }
         }
    }
}
