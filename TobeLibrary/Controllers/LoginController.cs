using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryEntities;
using TobeLibrary.ViewModels.Login;
using TobeLibraryBusinessLogic.Services;
using System.Web.Routing;

namespace TobeLibrary.Controllers
{
    public class LoginController : Controller
    {
        private LoginService _loginSvc;

        public LoginController()
        {
            _loginSvc = new LoginService();
        }

        public LoginController(LoginService loginSvc)
        {
            _loginSvc = loginSvc;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(LoginDetails userDetails)
        {
            Administrators admin = _loginSvc.LoginAdmin(userDetails.Username, userDetails.Password);
            if (admin == null)
            {
                ModelState.AddModelError("", "");
                return RedirectToAction("Index");
            }

            TempData["admin"] = admin;

            return RedirectToAction("Index", "Home");    //, new RouteValueDictionary(admin));
        }

        public bool IsLoggedIn()
        {
            return true;
        }

        protected override void Dispose(bool disposing)
        {
            _loginSvc.Dispose();
            base.Dispose(disposing);
        }
    }
}