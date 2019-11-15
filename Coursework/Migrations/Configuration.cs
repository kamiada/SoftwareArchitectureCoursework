namespace Coursework.Migrations
{
    using Coursework.Models;
    using Coursework.DataAccessLayer;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<Coursework.DataAccessLayer.DEstoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Coursework.DataAccessLayer.DEstoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var sale_types = new List<SaleType>
            {
                new SaleType{saleType="3 for 2"},
                new SaleType{saleType = "Buy one get one free"},
                new SaleType{saleType="Free delivery charges" }
            };
            sale_types.ForEach(s => context.SaleTypes.AddOrUpdate(p => p.saleType, s));
            context.SaveChanges();
        }
    }
}
