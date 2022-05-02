using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class AuthorT
    {
        public AuthorT()
        {
            ItemTs = new HashSet<ItemT>();
        }

        public int AuthorId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int? ItemId { get; set; }

        public virtual ItemT Item { get; set; }
        public virtual ICollection<ItemT> ItemTs { get; set; }
    }
}
