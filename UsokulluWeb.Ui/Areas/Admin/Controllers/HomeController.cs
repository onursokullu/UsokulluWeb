using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using UsokulluWeb.Ui.Filters;

namespace UsokulluWeb.Ui.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [AdminLoginFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}
