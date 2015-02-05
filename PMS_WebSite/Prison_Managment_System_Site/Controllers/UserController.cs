using Prison_Managment_System_Site.Classes;
using Prison_Managment_System_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prison_Managment_System_Site.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                    SQLhandler.openConnection();
                    if (SQLhandler.verifyUsernamePassword(user.username, user.password))
                    {
                        return RedirectToAction("Index", "Prisoner");
                    }
                    SQLhandler.closeConnection();
                //create new user related things
                //Session["user-log"]
            }
            //ModelState.AddModelError("", "User name \"" + user.username + "\" is already Taken");
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
                SQLhandler.openConnection();
                if (SQLhandler)
                {
                    return RedirectToAction("Index", "Prisoner");
                }
                SQLhandler.closeConnection();
                //create new user related things
                //Session["user-log"]
            }
            //ModelState.AddModelError("", "User name \"" + user.username + "\" is already Taken");
            return View(user);
        }
    }
}