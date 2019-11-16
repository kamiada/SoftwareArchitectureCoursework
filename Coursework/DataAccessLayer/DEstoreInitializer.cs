using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Coursework.Models;

namespace Coursework.DataAccessLayer
{
    public class DEstoreInitializerpublic : DropCreateDatabaseIfModelChanges<DEstoreContext>
    {
        protected override void Seed(DEstoreContext context)
        {
            //var customers = new List<Customer>
            //{
            //    new Customer{Name="Edgar Poe", History="10 Shovels, 20 Chimneys, 50 beds", BuyNowPayLater=false,LoyaltyCard=false},
            //    new Customer{Name="Wilhelmina Harker", History="1000 Stakes, 100 Shovels", BuyNowPayLater=false,LoyaltyCard=false},
            //    new Customer{Name="Laura Le Fanu",History="1 bed, 3 white paints, 5 curtains in colour blue",BuyNowPayLater=false,LoyaltyCard=false },
            //};

            //customers.ForEach(s => context.Customers.Add(s));
            //context.SaveChanges();


            var products = new List<Product>
            {
                new Product{Price=100, Name="Paint", Quantity=34},
                new Product{Price=50,Name="Christmas tree",Quantity=67 },
                new Product{Price=20,Name="Wood cutter",Quantity=80 },
                new Product{Price=10,Name="Chimney",Quantity=100},
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            
        }
    }
}
