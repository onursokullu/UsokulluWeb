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
    public class CategoryController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category model)
        {
            model.CreateDate = DateTime.Now;
            bool durum = false;
            using (CategoryRepository repo = new CategoryRepository())
            {

                repo.Add(model);
            }
            if (durum)
                TempData["Message"] = new TempDataDictionary { { "Message", "Kayıt eklendi" }, { "class", "alert-success" } };
            else
                TempData["Message"] = new TempDataDictionary { { "Message", "Kayıt eklenemedi" }, { "class", "alert-danger" } };

            return View();
        }

    }
}
