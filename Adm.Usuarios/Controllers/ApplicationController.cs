using A.Datos.Context;
using A.Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Adm.Usuarios.Controllers
{
    public class ApplicationController : Controller
    {
        private ConapContext db = new ConapContext();
        // GET: Application
        public ActionResult Index()
        {
            return View(db.Applications.ToList());
        }

        // GET: Application/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // GET: Application/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Application/Create
        [HttpPost]
        public ActionResult Create(Application application)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Applications.Add(application);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                    return View(application);
            }
            catch
            {
                return View(application);
            }
        }

        // GET: Application/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // POST: Application/Edit/5
        [HttpPost]
        public ActionResult Edit(Application application)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(application).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                    return View(application);
                
            }
            catch
            {
                return View(application);
            }
        }

        // GET: Application/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // POST: Application/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Application application)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    application = db.Applications.Find(id);
                    if (application == null)
                    {
                        return HttpNotFound();
                    }
                    db.Applications.Remove(application);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                    
                }
                else
                    return View(application);

            }
            catch
            {
                return View(application);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }
    }
}
