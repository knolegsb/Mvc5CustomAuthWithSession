using Mvc5CustomAuthWithSession.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5CustomAuthWithSession.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorize(Roles = "sumeradmin")]
        public ActionResult Work1()
        {
            return View("");
        }
    }
}