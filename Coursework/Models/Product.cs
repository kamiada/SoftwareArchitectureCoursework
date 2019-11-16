using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coursework.Models
{
    public class Product
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Display(Name = "Number")]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int sale_id { get; set; }

        public virtual Sale Sale { get; set; }
    }
}