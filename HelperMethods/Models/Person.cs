using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HelperMethods.Models
{
    [DisplayName("New person")]
    public class Person
    {
        [HiddenInput(DisplayValue = false)]
        public int PersonId { get; set; }
        [DisplayName("First")]
        public string FirstName { get; set; }
        [DisplayName("Last")]
        public string LastName { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public Address Address { get; set; }
        
        [DisplayName("Approuved")]
        public bool IsApproved { get; set; }
        [UIHint("Enum")]
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin, User, Guest
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}