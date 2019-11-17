using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coursework.Models
{
    public class Report
    {   
        [Key]
        public int report_id { get; set; }
        [Display(Name = "Name")]
        public string customer_name { get; set; }
        [Display(Name = "Surname")]
        public string customer_surname { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        [Display(Name = "Product")]
        public string product_name { get; set; }
        [Display(Name = "Quantity of sold items")]
        public int product_quantity { get; set; }
    }
}