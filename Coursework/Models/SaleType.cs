using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coursework.Models
{
    public class SaleType
    {
        [Key]
        public int ID { get; set; }
        public string saleType { get; set; }
        public virtual ICollection<Product>Products { get; set; }

    }
}