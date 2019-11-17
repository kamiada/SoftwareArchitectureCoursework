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

namespace Coursework.Controllers
{
    public class ReportAndAnalysisController : Controller
    {
        private DEstoreContext db = new DEstoreContext();

        // GET: ReportAndAnalysis
        public ActionResult Index()
        {
            return View(db.ReportsAndAnalysis.ToList());
        }

        // GET: ReportAndAnalysis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReportAndAnalysis reportAndAnalysis = db.ReportsAndAnalysis.Find(id);
            if (reportAndAnalysis == null)
            {
                return HttpNotFound();
            }
            return View(reportAndAnalysis);
        }

        // GET: ReportAndAnalysis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReportAndAnalysis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "report_and_analysis_ID,store_name,Date,no_sold_items,no_of_customers")] ReportAndAnalysis reportAndAnalysis)
        {
            if (ModelState.IsValid)
            {
                db.ReportsAndAnalysis.Add(reportAndAnalysis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reportAndAnalysis);
        }

        // GET: ReportAndAnalysis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReportAndAnalysis reportAndAnalysis = db.ReportsAndAnalysis.Find(id);
            if (reportAndAnalysis == null)
            {
                return HttpNotFound();
            }
            return View(reportAndAnalysis);
        }

        // POST: ReportAndAnalysis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "report_and_analysis_ID,store_name,Date,no_sold_items,no_of_customers")] ReportAndAnalysis reportAndAnalysis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reportAndAnalysis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reportAndAnalysis);
        }

        // GET: ReportAndAnalysis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReportAndAnalysis reportAndAnalysis = db.ReportsAndAnalysis.Find(id);
            if (reportAndAnalysis == null)
            {
                return HttpNotFound();
            }
            return View(reportAndAnalysis);
        }

        // POST: ReportAndAnalysis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReportAndAnalysis reportAndAnalysis = db.ReportsAndAnalysis.Find(id);
            db.ReportsAndAnalysis.Remove(reportAndAnalysis);
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
