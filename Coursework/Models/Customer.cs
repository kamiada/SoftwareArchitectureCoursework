using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursework.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string History { get; set; }
        public bool LoyaltyCard { get; set; }
        public bool BuyNowPayLater { get; set; }
    }
}