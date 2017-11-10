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

namespace Adm.Usuarios.Controllers
{
    public class PermissionProfilesController : Controller
    {
        private ConapContext db = new ConapContext();

        // GET: /PermissionProfiles/
        public ActionResult Index()
        {
            var permissionprofiles = db.PermissionProfiles.Include(p => p.Page).Include(p => p.profile);
            return View(permissionprofiles.ToList());
        }

        // GET: /PermissionProfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermissionProfile permissionProfile = db.PermissionProfiles.Find(id);
            if (permissionProfile == null)
            {
                return HttpNotFound();
            }
            return View(permissionProfile);
        }

        // GET: /PermissionProfiles/Create
        public ActionResult Create()
        {
            ViewBag.PageId = new SelectList(db.Pages, "PageId", "PageName");
            ViewBag.ProfileId = new SelectList(db.Profiles, "ProfileId", "ProfileName");
            return View();
        }

        // POST: /PermissionProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="PermissionProfileId,ProfileId,PageId,Access,Insert,Delete,Update")] PermissionProfile permissionProfile)
        {
            if (ModelState.IsValid)
            {
                db.PermissionProfiles.Add(permissionProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PageId = new SelectList(db.Pages, "PageId", "PageName", permissionProfile.PageId);
            ViewBag.ProfileId = new SelectList(db.Profiles, "ProfileId", "ProfileName", permissionProfile.ProfileId);
            return View(permissionProfile);
        }

        // GET: /PermissionProfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermissionProfile permissionProfile = db.PermissionProfiles.Find(id);
            if (permissionProfile == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageId = new SelectList(db.Pages, "PageId", "PageName", permissionProfile.PageId);
            ViewBag.ProfileId = new SelectList(db.Profiles, "ProfileId", "ProfileName", permissionProfile.ProfileId);
            return View(permissionProfile);
        }

        // POST: /PermissionProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="PermissionProfileId,ProfileId,PageId,Access,Insert,Delete,Update")] PermissionProfile permissionProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permissionProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PageId = new SelectList(db.Pages, "PageId", "PageName", permissionProfile.PageId);
            ViewBag.ProfileId = new SelectList(db.Profiles, "ProfileId", "ProfileName", permissionProfile.ProfileId);
            return View(permissionProfile);
        }

        // GET: /PermissionProfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermissionProfile permissionProfile = db.PermissionProfiles.Find(id);
            if (permissionProfile == null)
            {
                return HttpNotFound();
            }
            return View(permissionProfile);
        }

        // POST: /PermissionProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PermissionProfile permissionProfile = db.PermissionProfiles.Find(id);
            db.PermissionProfiles.Remove(permissionProfile);
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
