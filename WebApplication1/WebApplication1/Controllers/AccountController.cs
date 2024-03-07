using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string btnSubmit, BaseAccount baseAccount)
        {
            string LoginMsg = "";
            if (btnSubmit == "LOGIN")
            {
                bool VerifyStatus = baseAccount.VerifyLogin();
                if (VerifyStatus)
                {
                    Session["User"] = baseAccount.UserName;
                    LoginMsg = "Login Succes";
                    return RedirectToAction("Dashboard", "Home");
                }
                else
                {
                    LoginMsg = "Invalid Username or Password.";
                }
            }
            else if (btnSubmit == "Forget Password")
            {
                return RedirectToAction("Forget", "Account");
            }
            ViewBag.LoginMsg = LoginMsg;
            return View();
        }
        public ActionResult Forget()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Login", "Account");
        }
    }
}