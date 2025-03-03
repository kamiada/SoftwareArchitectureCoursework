﻿using System;
using Coursework.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Coursework.DataAccessLayer
{
    public class DEstoreContext : DbContext
    {
        public DEstoreContext() : base("DEstoreContext")
        { 
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> SaleTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ReportAndAnalysis> ReportsAndAnalysis { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Coursework.Models.Report> Reports { get; set; }
    }

}