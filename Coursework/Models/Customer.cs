using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coursework.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string History { get; set; }
        [Display(Name = "Loyalty Card")]
        public bool LoyaltyCard { get; set; }
        [Display(Name = "Buy Now Pay Later")]
        public bool BuyNowPayLater { get; set; }
        //public virtual ICollection<Product> History_Of_Purchases { get; set; }
    }
}