using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coursework.Models
{
    public class Sale
    {   [Key]
    //foreign and prime key in one(?) - relationship 1 to * with Product class
        public int sale_id { get; set; }
        public string type { get; set; }
        //Navigation property 
        public virtual ICollection<Product> Products { get; set; }
    }
}