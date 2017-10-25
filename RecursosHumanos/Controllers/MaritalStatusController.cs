using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using A.Datos.Context;
using A.Datos.Models;

namespace RecursosHumanos.Controllers
{
    public class MaritalStatusController : Controller
    {
        private ConapContext db = new ConapContext();

        // GET: /MaritalStatus/
        public ActionResult Index()
        {
            return View(db.MaritalStatus.ToList());
        }

        // GET: /MaritalStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaritalStatus maritalStatus = db.MaritalStatus.Find(id);
            if (maritalStatus == null)
            {
                return HttpNotFound();
            }
            return View(maritalStatus);
        }

        // GET: /MaritalStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MaritalStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="MaritalStatusId,MaritalStatustName")] MaritalStatus maritalStatus)
        {
            if (ModelState.IsValid)
            {
                db.MaritalStatus.Add(maritalStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maritalStatus);
        }

        // GET: /MaritalStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaritalStatus maritalStatus = db.MaritalStatus.Find(id);
            if (maritalStatus == null)
            {
                return HttpNotFound();
            }
            return View(maritalStatus);
        }

        // POST: /MaritalStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="MaritalStatusId,MaritalStatustName")] MaritalStatus maritalStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maritalStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maritalStatus);
        }

        // GET: /MaritalStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaritalStatus maritalStatus = db.MaritalStatus.Find(id);
            if (maritalStatus == null)
            {
                return HttpNotFound();
            }
            return View(maritalStatus);
        }

        // POST: /MaritalStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MaritalStatus maritalStatus = db.MaritalStatus.Find(id);
            db.MaritalStatus.Remove(maritalStatus);
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
