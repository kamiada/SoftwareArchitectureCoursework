using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursework.Models
{
    public class Produkt
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string SaleType { get; set; }
    }
}