﻿using System;
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
    public class SaleTypesController : Controller
    {
        private DEstoreContext db = new DEstoreContext();

        // GET: SaleTypes
        public ActionResult Index()
        {
            return View(db.SaleTypes.ToList());
        }

        // GET: SaleTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleType saleType = db.SaleTypes.Find(id);
            if (saleType == null)
            {
                return HttpNotFound();
            }
            return View(saleType);
        }

        // GET: SaleTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaleTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,saleType")] SaleType saleType)
        {
            if (ModelState.IsValid)
            {
                db.SaleTypes.Add(saleType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(saleType);
        }

        // GET: SaleTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleType saleType = db.SaleTypes.Find(id);
            if (saleType == null)
            {
                return HttpNotFound();
            }
            return View(saleType);
        }

        // POST: SaleTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,saleType")] SaleType saleType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(saleType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(saleType);
        }

        // GET: SaleTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleType saleType = db.SaleTypes.Find(id);
            if (saleType == null)
            {
                return HttpNotFound();
            }
            return View(saleType);
        }

        // POST: SaleTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SaleType saleType = db.SaleTypes.Find(id);
            db.SaleTypes.Remove(saleType);
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
