using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Daterbase.Data;
using Daterbase.Models;
using Microsoft.AspNet.Identity;

namespace Daterbase.Controllers
{
    public class DaterProfileController : Controller
    {
        private TheDaterbase db = new TheDaterbase();

        // GET: Dater
        public ActionResult Index()
        {
            return View(db.DaterProfiles.ToList());
        }

        // GET: Dater/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaterProfile dater = db.DaterProfiles.Find(id);
            if (dater == null)
            {
                return HttpNotFound();
            }
            return View(dater);
        }

        // GET: Dater/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dater/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DaterProfileID,Username,Age,DMinimumAge,DMaximumAge,Gender,DGender,IsEmployed,IsStudent,DNoScrubs,ZipCode,DWillingToTravel")] DaterProfile dater)
        {
            dater.UserID = User.Identity.GetUserId();

            if (ModelState.IsValid)
            {
                db.DaterProfiles.Add(dater);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dater);
        }

        // GET: Dater/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaterProfile dater = db.DaterProfiles.Find(id);
            if (dater == null)
            {
                return HttpNotFound();
            }
            return View(dater);
        }

        // POST: Dater/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DaterProfileID,Username,Age,DMinimumAge,DMaximumAge,Gender,DGender,IsEmployed,IsStudent,DNoScrubs,ZipCode,DWillingToTravel")] DaterProfile dater)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dater).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dater);
        }

        // GET: Dater/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DaterProfile dater = db.DaterProfiles.Find(id);
            if (dater == null)
            {
                return HttpNotFound();
            }
            return View(dater);
        }

        // POST: Dater/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DaterProfile dater = db.DaterProfiles.Find(id);
            db.DaterProfiles.Remove(dater);
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
