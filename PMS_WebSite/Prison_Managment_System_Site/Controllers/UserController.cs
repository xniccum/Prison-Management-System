using Prison_Managment_System;
using Prison_Managment_System_Site.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prison_Managment_System_Site.Controllers
{
    public class UserController : Controller
    {
        private SQLhandler handler;

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            ViewBag.Message = "";
            if (!user.username.Equals("") && !user.password.Equals(""))
            {
                this.handler = new SQLhandler();
                this.handler.openConnection();
                if (handler.verifyUsernamePassword(user.username, user.password))
                {
                    Session["UserName"] = user.username;
                    Session["Password"] = user.password;
                    return RedirectToAction("Index", "Prisoner");
                }
            }
            ViewBag.Message = "*User name or Password is Invalid";
            return View(user);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                this.handler = new SQLhandler();
                this.handler.openConnection();
                handler.addUser(user);
                return RedirectToAction("Login", "User");
            }
            return View(user);
        }
    }
}