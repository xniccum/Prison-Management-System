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
    public class PrisonerController : Controller
    {
        private SQLhandler handler;

        [HttpGet]
        public ActionResult Index()
        {
            this.handler = new SQLhandler();
            List<Prison_Managment_System_Site.Models.Prisoner> prisoners = new List<Prison_Managment_System_Site.Models.Prisoner>();
            this.handler.openConnection();
            if (this.handler.verifyUsernamePassword((string)Session["UserName"], (string)Session["Password"]))
            {
                foreach (DataRow dr in this.handler.getPrisonersTable().Rows)
                {
                    Object[] prisoner_data = this.handler.getPrisoner(int.Parse(dr.ItemArray[0].ToString()));
                    Prisoner p = new Prisoner();
                    p.ID = int.Parse(prisoner_data[0].ToString());
                    p.first_name = prisoner_data[1].ToString();
                    p.middle_name = prisoner_data[2].ToString();
                    p.last_name = prisoner_data[3].ToString();
                    p.crime = prisoner_data[4].ToString();
                    prisoners.Add(p);
                }
            }
            else
                RedirectToAction("User");
            return View(prisoners);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            this.handler = new SQLhandler();
            this.handler.openConnection();
            if (this.handler.verifyUsernamePassword((string)Session["UserName"], (string)Session["Password"]))
            {
                if (!this.handler.verifyRelation(id))
                {
                    return View("Error");
                }
                Object[] temp = handler.getPrisoner(id);
                Prisoner p = new Prisoner();
                p.ID = int.Parse(temp[0].ToString());
                p.first_name = temp[1].ToString();
                p.middle_name = temp[2].ToString();
                p.last_name = temp[3].ToString();
                p.crime = temp[4].ToString();
                p.crime_description = temp[5].ToString();
                return View(p);
            }
            return View();
        }
    }
}
