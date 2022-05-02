using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class AdminT
    {
        public int AdminId { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string AdminAddress { get; set; }
        public string AdminCity { get; set; }
        public int? AdminZipCode { get; set; }
        public string AdminState { get; set; }
        public string AdminPhone { get; set; }
        public DateTime? AdminDob { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
        public decimal? AdminSalary { get; set; }
    }
}
