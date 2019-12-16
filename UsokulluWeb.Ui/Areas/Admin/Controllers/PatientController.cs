using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using UsokulluWeb.Bll;
using UsokulluWeb.Model;
using UsokulluWeb.Ui.Filters;

namespace UsokulluWeb.Ui.Areas.Admin.Controllers
{
    public class PatientController : Controller
    {
        [AdminLoginFilter]
        public ActionResult Index()
        {
            using (PatientRepository repo = new PatientRepository())
            {
                var model = repo.GetByFilter(x => x.IsDelete == false).ToList();
                return View(model);
            }

        }
        [AdminLoginFilter]
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
                return View();
            }
        }
        [AdminLoginFilter]
        public ActionResult Edit(int id)
        {
            using (PatientRepository repo = new PatientRepository())
            {
                ViewBag.Patients = repo.GetByFilter(x => x.IsDelete == false);
                var result = repo.GetById(id);
                return View(result);
            }
        }
        [HttpPost]
        public ActionResult Edit(Patients model)
        {
            using (PatientRepository repo = new PatientRepository())
            {
                var result = repo.Update(model);
                TempData["Message"] = result ? new TempDataDictionary { { "class", "alert-success" }, { "Msg", "Hasta eklendi." } } : new TempDataDictionary { { "class", "alert-danger" }, { "Msg", "Hasta eklenemedi." } };
                return RedirectToAction(nameof(Index));
            }
        }
        [AdminLoginFilter]
        public ActionResult Delete(int id)
        {
            using (PatientRepository repo= new PatientRepository())
            {
                bool result = repo.SoftDelete(id);
                TempData["Message"] = result ? new TempDataDictionary { { "class", "alert-success" }, { "Msg", "Hasta Silindi." } } : new TempDataDictionary { { "class", "alert-success" }, { "Msg", "Hasta Silindi." } };
                return RedirectToAction(nameof(Index));
            }
        }
        [AdminLoginFilter]
        public ActionResult Detail(int id)
        {
            using (PatientRepository repo = new PatientRepository())
            {
                var result = repo.GetById(id);
                return View(result);
            }
        }
    }
}
