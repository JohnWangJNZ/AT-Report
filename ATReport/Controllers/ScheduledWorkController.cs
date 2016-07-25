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
    public class ScheduledWorkController : Controller
    {
        private ATDataContext db = new ATDataContext();

        // GET: ScheduledWork
        public ActionResult Index()
        {
            return View(db.ScheduledWorks.ToList());
        }

        // GET: ScheduledWork/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduledWork scheduledWork = db.ScheduledWorks.Find(id);
            if (scheduledWork == null)
            {
                return HttpNotFound();
            }
            return View(scheduledWork);
        }

        // GET: ScheduledWork/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScheduledWork/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Code,Type,Name,Address,Suburb,Region,Description,StartDate,EndDate,LastUpdated,ContractorCompany,Latitude,Longitude,GeometryType,GeometryEncoded")] ScheduledWork scheduledWork)
        {
            if (ModelState.IsValid)
            {
                db.ScheduledWorks.Add(scheduledWork);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scheduledWork);
        }

        // GET: ScheduledWork/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduledWork scheduledWork = db.ScheduledWorks.Find(id);
            if (scheduledWork == null)
            {
                return HttpNotFound();
            }
            return View(scheduledWork);
        }

        // POST: ScheduledWork/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Code,Type,Name,Address,Suburb,Region,Description,StartDate,EndDate,LastUpdated,ContractorCompany,Latitude,Longitude,GeometryType,GeometryEncoded")] ScheduledWork scheduledWork)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scheduledWork).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scheduledWork);
        }

        // GET: ScheduledWork/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduledWork scheduledWork = db.ScheduledWorks.Find(id);
            if (scheduledWork == null)
            {
                return HttpNotFound();
            }
            return View(scheduledWork);
        }

        // POST: ScheduledWork/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ScheduledWork scheduledWork = db.ScheduledWorks.Find(id);
            db.ScheduledWorks.Remove(scheduledWork);
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
