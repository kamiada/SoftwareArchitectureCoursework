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
            var customers = new List<Customer>
            {
                new Customer{Name="Edgar Poe", History="In Testing", BuyNowPayLater=true,LoyaltyCard=true},
                new Customer{Name="Wilhelmina Harker", History="To be told", BuyNowPayLater=false,LoyaltyCard=false},
                new Customer{Name="Laura Le Fanu",History="I will figure it out later",BuyNowPayLater=false,LoyaltyCard=true },
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();


            //var products = new List<Product>
            //{
            //    new Product{Price=100, Name="Paint", Quantity=34,SaleType="Not Implemented Yet" },
            //    new Product{Price=50,Name="Christmas tree",Quantity=67,SaleType="Not Implemented Yet" },
            //    new Product{Price=20,Name="Wood cutter",Quantity=80,SaleType="Not Implemented Yet" },
            //    new Product{Price=10,Name="Chimney",Quantity=100,SaleType="Not Implemented Yet" },
            //};
            //  products.ForEach(s => context.Product.Add(s));
            context.SaveChanges();
        }
    }
}
