﻿using PMS_WebSite.Classes;
using PMS_WebSite.Context;
using PMS_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS_WebSite.Controllers
{
    public class UserController : Controller
    {
        private UserContext db = new UserContext();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login(User user)
        {
            
            if(SQLhandler.openConnection())
            {
                if (SQLhandler.verifyUsernamePassword(user.username,user.password))
                {
                    ViewBag.Message = "Login Worked";
                    SQLhandler.closeConnection();
                    return RedirectToAction("Create");
                }
                ViewBag.Message = "Login Failed";
                SQLhandler.closeConnection();
            }
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
