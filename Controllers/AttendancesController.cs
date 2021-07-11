using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bigschool1.Controllers
{
    public class AttendancesController : Controller
    {
        // GET: Attendances
        public ActionResult Index()
        {
            return View();
        }
    }
}