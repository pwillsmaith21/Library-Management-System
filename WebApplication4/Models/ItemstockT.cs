using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class ItemstockT
    {
        public int ItemNumber { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }

        public virtual ItemT ItemNumberNavigation { get; set; }
    }
}
