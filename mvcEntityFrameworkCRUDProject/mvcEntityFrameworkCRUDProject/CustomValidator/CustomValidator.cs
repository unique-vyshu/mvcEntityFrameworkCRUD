using System;
using System.ComponentModel.DataAnnotations;

namespace mvcEntityFrameworkCRUDProject.CustomValidator
{
    public class DOBCustomValidator:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int year = ((DateOnly)value).Year;
                if (year >= 1990 && year <= 2005)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult( ErrorMessage ?? "Year must be between 1990 and 2005");
        }
    }

    public class DOJCustomValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime today = DateTime.Now;
                DateOnly dateOnlytoday = DateOnly.FromDateTime(today);
                DateOnly doj = (DateOnly)value;


                if (doj <= dateOnlytoday)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "Date Of Joining should be less than today's date");

        }

    }


    public class DeptCustomValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
              string dept = value.ToString();
                if (dept == "IT" || dept=="HR")
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "The Department should be either IT or HR");

        }

    }
}
