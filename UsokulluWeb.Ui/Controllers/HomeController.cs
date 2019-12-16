using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsokulluWeb.Bll;
using UsokulluWeb.Model;

namespace UsokulluWeb.Ui.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Appointment(Appointments model)
        {
            using (AppointmentRepository repo = new AppointmentRepository())
            {
                model.IsDelete = false;
                model.CreateDate = DateTime.Now;
                var result = repo.Add(model);
                return RedirectToAction("Index", "Home");
            }
        }
    }
}