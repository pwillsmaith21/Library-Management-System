using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class PublisherT
    {
        public PublisherT()
        {
            ItemTs = new HashSet<ItemT>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public int? ItemId { get; set; }

        public virtual ItemT Item { get; set; }
        public virtual ICollection<ItemT> ItemTs { get; set; }
    }
}
