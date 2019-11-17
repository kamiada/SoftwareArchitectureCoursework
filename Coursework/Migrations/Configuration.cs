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
            //var buy_now_pay_later = new List<BuyNowPayLater>
            //{
            //    new BuyNowPayLater{status="Enabled" },
            //    new BuyNowPayLater{status="Disabled"}
            //};
            //buy_now_pay_later.ForEach(s => context.Status.AddOrUpdate(p => p.status, s));
            //context.SaveChanges();

            //var customers1 = new List<Customer1>
            //{
            //    new Customer1{Name="Johnatan Harker",Loyalty_Card=false,
            //    customer_id = buy_now_pay_later.FirstOrDefault  (s=>s.status=="Disabled").bnpl_id},
            //    new Customer1{Name="Mina Harker",Loyalty_Card=false,
            //    customer_id = buy_now_pay_later.FirstOrDefault  (s=>s.status=="Enabled").bnpl_id },
            //    new Customer1{Name="Edgar Allan Poe",Loyalty_Card=false,
            //    customer_id = buy_now_pay_later.FirstOrDefault  (s=>s.status=="Disabled").bnpl_id }
            //};
            //customers1.ForEach(s => context.Customer1s.AddOrUpdate(p => p.bnpl_id, s));
            //context.SaveChanges();

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

            var customers = new List<Customer>
            {
                new Customer{Name="Edgar Poe", History="10 Shovels, 20 Chimneys, 50 beds", BuyNowPayLater=false,LoyaltyCard=false},
                new Customer{Name="Wilhelmina Harker", History="1000 Stakes, 100 Shovels", BuyNowPayLater=false,LoyaltyCard=false},
                new Customer{Name="Laura Le Fanu",History="1 bed, 3 white paints, 5 curtains in colour blue",BuyNowPayLater=false,LoyaltyCard=false },
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var reports = new List<Report>
            {
                new Report{customer_name="Ingrid",customer_surname="Bergsman",Date=DateTime.Parse("2018-08-12"),
                product_name="Chimney",product_quantity=10},
                new Report{customer_name="Ingrid",customer_surname="Bergsman",Date=DateTime.Parse("2018-08-21"),
                product_name="Mirror",product_quantity=1},
                new Report{customer_name="Ingrid",customer_surname="Bergsman",Date=DateTime.Parse("2018-09-01"),
                product_name="Vase",product_quantity=5},
                new Report{customer_name="Victor",customer_surname="Crumm",Date=DateTime.Parse("2018-09-25"),
                product_name="Ladder",product_quantity=1},
                new Report{customer_name="Victor",customer_surname="Crumm",Date=DateTime.Parse("2018-10-27"),
                product_name="Window frame",product_quantity=4},
               new Report{customer_name="Victor",customer_surname="Crumm",Date=DateTime.Parse("2018-10-30"),
                product_name="Box",product_quantity=120},
            };
            reports.ForEach(s => context.Reports.Add(s));
            context.SaveChanges();

        }
    }
}
