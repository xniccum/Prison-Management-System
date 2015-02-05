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
        SQLhandler handler;

        [HttpGet]
        public ActionResult Index()
        {
            this.handler = new SQLhandler();
            List<Prison_Managment_System_Site.Models.Prisoner> prisoners = new List<Prison_Managment_System_Site.Models.Prisoner>();
            this.handler.openConnection();
            if (this.handler.verifyUsernamePassword((string)Session["UserName"], (string)Session["Password"]))
            {
                DataRowCollection rows = handler.getFullDetailPrisonersTable().Rows;
                foreach (DataRow dr in rows)
                {
                    Prisoner p = new Prisoner();
                    p.ID = int.Parse(dr.ItemArray[0].ToString());
                    p.first_name = dr.ItemArray[1].ToString();
                    p.middle_name = dr.ItemArray[2].ToString();
                    p.last_name = dr.ItemArray[3].ToString();
                    p.crime = dr.ItemArray[4].ToString();
                    p.crime_description= dr.ItemArray[5].ToString();
                    prisoners.Add(p);
                }
            }
            return View(prisoners);
        }

        // GET: Prisoner/Details/5
        public ActionResult Details(int id)
        {
            this.handler = new SQLhandler();
            this.handler.openConnection();
            if (this.handler.verifyUsernamePassword((string)Session["UserName"], (string)Session["Password"]))
            {
                Object[] temp = handler.getPrisoner(id).Rows[0].ItemArray;
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
