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
    public class PermissionUsersController : Controller
    {
        private ConapContext db = new ConapContext();

        // GET: /PermissionUsers/
        public ActionResult Index()
        {
            var permissionusers = db.PermissionUsers.Include(p => p.Page).Include(p => p.profile).Include(p => p.User);
            return View(permissionusers.ToList());
        }

        // GET: /PermissionUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermissionUser permissionUser = db.PermissionUsers.Find(id);
            if (permissionUser == null)
            {
                return HttpNotFound();
            }
            return View(permissionUser);
        }

        // GET: /PermissionUsers/Create
        public ActionResult Create()
        {
            ViewBag.PageId = new SelectList(db.Pages, "PageId", "PageName");
            ViewBag.ProfileId = new SelectList(db.Profiles, "ProfileId", "ProfileName");
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName");
            return View();
        }

        // POST: /PermissionUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="PermissionUserId,UserId,ProfileId,PageId,Access,Insert,Delete,Update")] PermissionUser permissionUser)
        {
            if (ModelState.IsValid)
            {
                db.PermissionUsers.Add(permissionUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PageId = new SelectList(db.Pages, "PageId", "PageName", permissionUser.PageId);
            ViewBag.ProfileId = new SelectList(db.Profiles, "ProfileId", "ProfileName", permissionUser.ProfileId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", permissionUser.UserId);
            return View(permissionUser);
        }

        // GET: /PermissionUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermissionUser permissionUser = db.PermissionUsers.Find(id);
            if (permissionUser == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageId = new SelectList(db.Pages, "PageId", "PageName", permissionUser.PageId);
            ViewBag.ProfileId = new SelectList(db.Profiles, "ProfileId", "ProfileName", permissionUser.ProfileId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", permissionUser.UserId);
            return View(permissionUser);
        }

        // POST: /PermissionUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="PermissionUserId,UserId,ProfileId,PageId,Access,Insert,Delete,Update")] PermissionUser permissionUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permissionUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PageId = new SelectList(db.Pages, "PageId", "PageName", permissionUser.PageId);
            ViewBag.ProfileId = new SelectList(db.Profiles, "ProfileId", "ProfileName", permissionUser.ProfileId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", permissionUser.UserId);
            return View(permissionUser);
        }

        // GET: /PermissionUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermissionUser permissionUser = db.PermissionUsers.Find(id);
            if (permissionUser == null)
            {
                return HttpNotFound();
            }
            return View(permissionUser);
        }

        // POST: /PermissionUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PermissionUser permissionUser = db.PermissionUsers.Find(id);
            db.PermissionUsers.Remove(permissionUser);
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
