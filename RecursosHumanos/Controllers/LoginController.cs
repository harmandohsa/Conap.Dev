using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A.Datos.Models;
using A.Datos.Context;
using System.Web.UI;

namespace RecursosHumanos.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            using (ConapContext db = new ConapContext())
            {
                var usr = db.Users.Where(u => u.UserName == user.UserName && u.Password == user.Password).FirstOrDefault();
                if (usr !=  null)
                {
                    Session["UserId"] = user.UserId.ToString();
                    Session["UserName"] = user.UserName.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Usuario o clave incorrecto");
                    
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}