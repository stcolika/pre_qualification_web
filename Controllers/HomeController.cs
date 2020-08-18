using pre_qualification_web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pre_qualification_web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*
                *Application that queries a server and displays the current date/time hour in local and UTC timezones.
                        Server URL: http://worldclockapi.com/api/json/utc/now*
                *REST server returning a JSON*
            */

            ViewBag.Title = "Get DateTime";
            return View();
        }

        public ActionResult Data()
        {
            /*
             * Given a string, check if it looks like a CNPJ 
            */

            ViewBag.Title = "Validate Data";
            return View();
        }

    }
}

