﻿using System;
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
    public class TimeworksController : Controller
    {
        private TheClinicEntities1 db = new TheClinicEntities1();

        // GET: /Timeworks/
        public ActionResult Index()
        {
            return View(db.Timeworks.ToList());
        }

        // GET: /Timeworks/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Timework timework = db.Timeworks.Find(id);
            if (timework == null)
            {
                return HttpNotFound();
            }
            return View(timework);
        }

        // GET: /Timeworks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Timeworks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="timework_id,session,begin_time,end_time")] Timework timework)
        {
            if (ModelState.IsValid)
            {
                db.Timeworks.Add(timework);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timework);
        }

        // GET: /Timeworks/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Timework timework = db.Timeworks.Find(id);
            if (timework == null)
            {
                return HttpNotFound();
            }
            return View(timework);
        }

        // POST: /Timeworks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="timework_id,session,begin_time,end_time")] Timework timework)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timework).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timework);
        }

        // GET: /Timeworks/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Timework timework = db.Timeworks.Find(id);
            if (timework == null)
            {
                return HttpNotFound();
            }
            return View(timework);
        }

        // POST: /Timeworks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Timework timework = db.Timeworks.Find(id);
            db.Timeworks.Remove(timework);
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
