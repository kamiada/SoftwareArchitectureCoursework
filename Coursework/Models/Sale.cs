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
        public int sale_id { get; set; }
        public string type { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}