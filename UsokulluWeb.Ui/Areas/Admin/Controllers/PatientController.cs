using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using UsokulluWeb.Bll;
using UsokulluWeb.Model;

namespace UsokulluWeb.Ui.Areas.Admin.Controllers
{
    public class PatientController : Controller
    {
        public ActionResult Index()
        {
            using (PatientRepository repo = new PatientRepository())
            {
                var model = repo.GetByFilter(x => x.IsDelete == false).ToList();
                return View(model);
            }

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Patients model)
        {
            using (PatientRepository repo = new PatientRepository())
            {
                model.IsDelete = false;
                model.CreateDate = DateTime.Now;
                var result = repo.Add(model);
                TempData["Message"] = result ? new TempDataDictionary { { "class", "alert-success" }, { "Msg", "Hasta başarıyla eklendi" } } : new TempDataDictionary { {"class","alert-danfer" }, { "Msg","Hasta eklenemedi"} };
                return View();
            }
        }
    }
}
