using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryEntities;
using TobeLibrary.ViewModels.Login;
using TobeLibraryBusinessLogic.Services;

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

        public ActionResult LoginUser(LoginDetails userDetails)
        {
            Users user = _loginSvc.LoginUser(userDetails.Username, userDetails.Password);

            return View(User);
        }
    }
}