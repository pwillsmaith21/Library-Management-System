using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class UserT
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserAddress { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public int? UserZipCode { get; set; }
        public string UserPhone { get; set; }
        public DateTime? UserDob { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
