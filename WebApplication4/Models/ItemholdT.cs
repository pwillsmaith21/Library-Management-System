using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class ItemholdT
    {
        public int? UserId { get; set; }
        public int? ItemHold1 { get; set; }
        public int? ItemHold2 { get; set; }
        public int? ItemHold3 { get; set; }
        public int? ItemHold4 { get; set; }
        public int? ItemHold5 { get; set; }

        public virtual ItemT ItemHold1Navigation { get; set; }
        public virtual ItemT ItemHold2Navigation { get; set; }
        public virtual ItemT ItemHold3Navigation { get; set; }
        public virtual ItemT ItemHold4Navigation { get; set; }
        public virtual ItemT ItemHold5Navigation { get; set; }
    }
}
