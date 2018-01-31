using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SystemMngmt.Models;

namespace SystemMngmt.Controllers
{
    public class TimeWorksController : Controller
    {
        private DrNguyenClinicEntities1 db = new DrNguyenClinicEntities1();

        // GET: /TimeWorks/
        public ActionResult Index()
        {
            return View(db.TimeWorks.ToList());
        }

        // GET: /TimeWorks/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeWork timework = db.TimeWorks.Find(id);
            if (timework == null)
            {
                return HttpNotFound();
            }
            return View(timework);
        }

        // GET: /TimeWorks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /TimeWorks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Session,Begin_time,End_time")] TimeWork timework)
        {
            if (ModelState.IsValid)
            {
                db.TimeWorks.Add(timework);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timework);
        }

        // GET: /TimeWorks/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeWork timework = db.TimeWorks.Find(id);
            if (timework == null)
            {
                return HttpNotFound();
            }
            return View(timework);
        }

        // POST: /TimeWorks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Session,Begin_time,End_time")] TimeWork timework)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timework).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timework);
        }

        // GET: /TimeWorks/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeWork timework = db.TimeWorks.Find(id);
            if (timework == null)
            {
                return HttpNotFound();
            }
            return View(timework);
        }

        // POST: /TimeWorks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TimeWork timework = db.TimeWorks.Find(id);
            db.TimeWorks.Remove(timework);
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
