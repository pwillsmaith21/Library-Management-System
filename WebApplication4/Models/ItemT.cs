using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class ItemT
    {
        public ItemT()
        {
            AuthorTs = new HashSet<AuthorT>();
            PublisherTs = new HashSet<PublisherT>();
        }

        public int ItemId { get; set; }
        public string Title { get; set; }
        public int? Author { get; set; }
        public int? Publisher { get; set; }
        public DateTime? DatePublished { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? RentalPrice { get; set; }
        public string ItemType { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }

        public virtual AuthorT AuthorNavigation { get; set; }
        public virtual PublisherT PublisherNavigation { get; set; }
        public virtual ItemstockT ItemstockT { get; set; }
        public virtual ICollection<AuthorT> AuthorTs { get; set; }
        public virtual ICollection<PublisherT> PublisherTs { get; set; }
    }
}
