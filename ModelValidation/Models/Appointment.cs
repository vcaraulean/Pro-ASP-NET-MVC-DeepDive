using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ModelValidation.Infrastructure;

namespace ModelValidation.Models
{
    [NoJoeOnMondays]
    public class Appointment
    {
        [Required]
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        //[Required(ErrorMessage = "Please enter a date")]
        //[FutureDate(ErrorMessage = "Please enter a date in the future")]
        [Remote("ValidateDate", "Home")]
        public DateTime Date { get; set; }

        [MustBeTrue(ErrorMessage = "You must accept the terms")]
        public bool TermsAccepted { get; set; }
    }
}