using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public int? Zipcode { get; set; }
        public string Password { get; set; }
    }
}
