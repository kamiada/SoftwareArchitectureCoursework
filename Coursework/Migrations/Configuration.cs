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
            var sale_types = new List<Sale>
            {
                new Sale{type="3 for 2"},
                new Sale{type = "Buy one get one free"},
                new Sale{type="Free delivery charges" },
                new Sale{type = "No sale"}
            };
            sale_types.ForEach(s => context.SaleTypes.AddOrUpdate(p => p.type, s));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{Price=100, Name="Paint", Quantity=34,
                sale_id = sale_types.Single(s=>s.type=="Buy one get one free").sale_id},

                new Product{Price=50,Name="Christmas tree",Quantity=67,
                sale_id = sale_types.Single(s=>s.type=="Free delivery charges").sale_id},


                new Product{Price=20,Name="Wood cutter",Quantity=80,
                sale_id = sale_types.Single(s=>s.type=="No sale").sale_id},


                new Product{Price=10,Name="Chimney",Quantity=100,
                sale_id = sale_types.Single(s =>s.type=="3 for 2").sale_id}
            };
            products.ForEach(s => context.Products.AddOrUpdate(p => p.sale_id, s));
            context.SaveChanges();
        }
    }
}
