using System;
using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Infrastructure
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value is DateTime && DateTime.Now < (DateTime)value;
        }
    }
}