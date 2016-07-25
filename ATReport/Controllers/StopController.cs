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
    public class StopController : Controller
    {
        private ATDataContext db = new ATDataContext();

        // GET: Stop
        public ActionResult Index()
        {
            return View(db.Stops.ToList());
        }

        // GET: Stop/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stop stop = db.Stops.Find(id);
            if (stop == null)
            {
                return HttpNotFound();
            }
            return View(stop);
        }

        // GET: Stop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stop/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,Latitude,Longitude,ZoneID,Url,Code,Street,City,Region,Country,PostCode,LocationType,ParentSation,TimeZone,WheelChairBoarding,Direction,Position,GeometryCode")] Stop stop)
        {
            if (ModelState.IsValid)
            {
                db.Stops.Add(stop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stop);
        }

        // GET: Stop/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stop stop = db.Stops.Find(id);
            if (stop == null)
            {
                return HttpNotFound();
            }
            return View(stop);
        }

        // POST: Stop/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,Latitude,Longitude,ZoneID,Url,Code,Street,City,Region,Country,PostCode,LocationType,ParentSation,TimeZone,WheelChairBoarding,Direction,Position,GeometryCode")] Stop stop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stop);
        }

        // GET: Stop/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stop stop = db.Stops.Find(id);
            if (stop == null)
            {
                return HttpNotFound();
            }
            return View(stop);
        }

        // POST: Stop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stop stop = db.Stops.Find(id);
            db.Stops.Remove(stop);
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
