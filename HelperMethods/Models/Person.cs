using System;

namespace HelperMethods.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Address Address { get; set; }
        public bool IsApproved { get; set; }
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