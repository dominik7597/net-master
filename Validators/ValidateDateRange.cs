using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcGame.Controllers
{
    public class ValidateDateRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime thisDay = DateTime.Today;
            if (Convert.ToDateTime(value) >= thisDay)
            {
                return new ValidationResult("Enter data before " + thisDay.ToShortDateString() + " !");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
