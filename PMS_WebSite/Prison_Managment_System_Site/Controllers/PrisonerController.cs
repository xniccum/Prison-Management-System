using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prison_Managment_System_Site.Controllers
{
    public class PrisonerController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new List<Prison_Managment_System_Site.Models.Prisoner>());
        }

        // GET: Prisoner/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
