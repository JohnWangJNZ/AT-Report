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
    public class CarparkController : Controller
    {
        private ATDataContext db = new ATDataContext();

        // GET: Carpark
        public ActionResult Index()
        {
            return View(db.Carparks.ToList());
        }

        // GET: Carpark/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carpark carpark = db.Carparks.Find(id);
            if (carpark == null)
            {
                return HttpNotFound();
            }
            return View(carpark);
        }

        // GET: Carpark/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carpark/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Address,MobilitySpace,Type,Latitude,Longitude")] Carpark carpark)
        {
            if (ModelState.IsValid)
            {
                db.Carparks.Add(carpark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carpark);
        }

        // GET: Carpark/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carpark carpark = db.Carparks.Find(id);
            if (carpark == null)
            {
                return HttpNotFound();
            }
            return View(carpark);
        }

        // POST: Carpark/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Address,MobilitySpace,Type,Latitude,Longitude")] Carpark carpark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carpark).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carpark);
        }

        // GET: Carpark/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carpark carpark = db.Carparks.Find(id);
            if (carpark == null)
            {
                return HttpNotFound();
            }
            return View(carpark);
        }

        // POST: Carpark/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Carpark carpark = db.Carparks.Find(id);
            db.Carparks.Remove(carpark);
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
