using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coursework.Models
{
    public class ReportAndAnalysis
    {
        [Key]
        public int report_and_analysis_ID { get; set; }
        [Display(Name = "Store location")]
        public string store_name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        [Display(Name = "Number of sold items")]
        public int no_sold_items { get; set; }
        [Display(Name ="Number of customers")]
        public int no_of_customers { get; set; }
    }
}