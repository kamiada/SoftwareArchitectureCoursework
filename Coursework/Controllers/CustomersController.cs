using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Coursework.DataAccessLayer;
using Coursework.Models;
using System.Windows;
using System.Web.Services.Description;
using System.Xml;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;


namespace Coursework.Controllers
{
    public class CustomersController : Controller
    {
        private DEstoreContext db = new DEstoreContext();

        // GET: Customers
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,History,LoyaltyCard,BuyNowPayLater")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,History,LoyaltyCard,BuyNowPayLater")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                //this line checks if something was modified 
                db.Entry(customer).State = EntityState.Modified;
                //if BuyNowPayLater option is set to true, pop up message box, if not don't do anything
                if (db.Entry(customer).Property(u=>u.BuyNowPayLater).IsModified)
                {
                    if (db.Entry(customer).Property(u => u.BuyNowPayLater).CurrentValue == true)
                    {
                        string message = "Connecting to Enabling system for Finance Approval";
                        string caption = "Finance Approval Requested";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result;

                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Cancel)
                        {
                        }
                    }
                }
                else
                {
                }

                //for Loyalty Card
                if (db.Entry(customer).Property(u => u.LoyaltyCard).IsModified)
                {
                    if (db.Entry(customer).Property(u => u.LoyaltyCard).CurrentValue == true &&
                        db.Entry(customer).Property(u=>u.History).CurrentValue== "1000 Stakes, 100 Shovels")
                    {
                        string message = "Loyalty Card has been added to this customer profile";
                        string caption = "Loyalty Card";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result;

                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Cancel)
                        {
                        }
                    }
                    else
                    {

                    }

                    if (db.Entry(customer).Property(u => u.LoyaltyCard).CurrentValue == true &&
                        db.Entry(customer).Property(u => u.History).CurrentValue != "1000 Stakes, 100 Shovels")
                    {
                        string message = "This customer history shows that he/she is not applicable for Loyalty Card";
                        string caption = "Loyalty Card";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result;

                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Cancel)
                        {
                        }
                        db.Entry(customer).Property(u => u.LoyaltyCard).CurrentValue = false;
                    }
                }


                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
