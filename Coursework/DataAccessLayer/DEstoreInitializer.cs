using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Coursework.Models;

namespace Coursework.DataAccessLayer
{
    public class DEstoreInitializerpublic : System.Data.Entity.DropCreateDatabaseIfModelChanges<DEstoreContext>
    {
        protected override void Seed(DEstoreContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{Name="Edgar Alan Poe", History="In Testing", BuyNowPayLater=true,LoyaltyCard=true},
                new Customer{Name="Wilhelmina Harker", History="To be told", BuyNowPayLater=false,LoyaltyCard=false},
                new Customer{Name="Laura Le Fanu",History="I will figure it out later",BuyNowPayLater=false,LoyaltyCard=true },
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
        }
    }
}
