using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursework.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
       public string TypeOfSale { get; set; }

        public virtual SaleType GetSetSaleType { get; set; }
    }
}