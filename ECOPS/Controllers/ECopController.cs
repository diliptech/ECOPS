using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECOPS.Controllers
{
    public class ECopController : Controller
    {
        // GET: ECop
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}