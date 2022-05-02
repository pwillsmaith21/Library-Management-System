using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class LibrarianT
    {
        public int LibrarianId { get; set; }
        public string LibrarianFirstName { get; set; }
        public string LibrarianLastName { get; set; }
        public string LibrarianAddress { get; set; }
        public string LibrarianCity { get; set; }
        public int? LibrarianZipCode { get; set; }
        public string LibrarianState { get; set; }
        public string LibrarianPhone { get; set; }
        public DateTime? LibrarianDob { get; set; }
        public string LibrarianEmail { get; set; }
        public string LibrarianPassword { get; set; }
        public decimal? LibrarianSalary { get; set; }
    }
}
