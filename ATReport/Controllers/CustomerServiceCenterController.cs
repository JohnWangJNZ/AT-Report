using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ATReport.DAL;
using ATReport.Models;

namespace ATReport.Controllers
{
    public class CustomerServiceCenterController : Controller
    {
        private ATDataContext db = new ATDataContext();

        // GET: CustomerServiceCenter
        public ActionResult Index()
        {
            return View(db.CustomerServiceCenters.ToList());
        }

        // GET: CustomerServiceCenter/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerServiceCenter customerServiceCenter = db.CustomerServiceCenters.Find(id);
            if (customerServiceCenter == null)
            {
                return HttpNotFound();
            }
            return View(customerServiceCenter);
        }

        // GET: CustomerServiceCenter/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerServiceCenter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Address,Suburb,Phone,OpenHours,HopServices,Latitude,Longitude")] CustomerServiceCenter customerServiceCenter)
        {
            if (ModelState.IsValid)
            {
                db.CustomerServiceCenters.Add(customerServiceCenter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerServiceCenter);
        }

        // GET: CustomerServiceCenter/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerServiceCenter customerServiceCenter = db.CustomerServiceCenters.Find(id);
            if (customerServiceCenter == null)
            {
                return HttpNotFound();
            }
            return View(customerServiceCenter);
        }

        // POST: CustomerServiceCenter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Address,Suburb,Phone,OpenHours,HopServices,Latitude,Longitude")] CustomerServiceCenter customerServiceCenter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerServiceCenter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerServiceCenter);
        }

        // GET: CustomerServiceCenter/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerServiceCenter customerServiceCenter = db.CustomerServiceCenters.Find(id);
            if (customerServiceCenter == null)
            {
                return HttpNotFound();
            }
            return View(customerServiceCenter);
        }

        // POST: CustomerServiceCenter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerServiceCenter customerServiceCenter = db.CustomerServiceCenters.Find(id);
            db.CustomerServiceCenters.Remove(customerServiceCenter);
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
