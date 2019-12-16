using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsokulluWeb.Bll;
using UsokulluWeb.Model;

namespace UsokulluWeb.Ui.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Users model)
        {
            UserRepository repo = new UserRepository();
            var user = repo.Login(model.UserEmail, model.Password);
            if (user != null)
            {
                Session["LoginUser"] = user;
                return RedirectToAction("Index","Home");
            }
            else
            {
                TempData["Message"] = new TempDataDictionary { { "class", "alert-danger" }, { "Msg", "Email veya şifre hatalı!" } };
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Login", "User");
        }
    }
}