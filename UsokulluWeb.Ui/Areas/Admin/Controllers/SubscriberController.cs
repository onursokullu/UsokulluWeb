using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using UsokulluWeb.Bll;
using UsokulluWeb.Model;
using UsokulluWeb.Ui.Filters;

namespace UsokulluWeb.Ui.Areas.Admin.Controllers
{
    public class SubscriberController : Controller
    {
        [AdminLoginFilter]
        public ActionResult Subscriber()
        {
            return View();
        }
        [AdminLoginFilter]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Subscribers model)
        {
            model.CreateDate = DateTime.Now;
            bool durum = false;
            using (SubscriberRepository repo = new SubscriberRepository())
            {
                repo.Add(model);
            }
            if (durum)
                TempData["Subscriber"] = new TempDataDictionary { { "Subscriber", "Kayıt eklendi" }, { "class", "alert-success" } };
            else
                TempData["Subscriber"] = new TempDataDictionary { { "Subscriber", "Kayıt eklenemedi" }, { "class", "alert-danger" } };

            return View();
        }
    }
}
