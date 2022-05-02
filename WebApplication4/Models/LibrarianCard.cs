using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class LibrarianCard
    {
        public int? CardNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string AccountStatus { get; set; }

        public virtual LibrarianT CardNumberNavigation { get; set; }
    }
}
