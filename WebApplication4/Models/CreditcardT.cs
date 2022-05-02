using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class CreditcardT
    {
        public int? UserId { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public DateTime? CardExpDate { get; set; }
        public int? CardCvv { get; set; }
        public string CardAddress { get; set; }
        public string CardCity { get; set; }
        public int? CardZipCode { get; set; }
        public string CardState { get; set; }

        public virtual UserT User { get; set; }
    }
}
