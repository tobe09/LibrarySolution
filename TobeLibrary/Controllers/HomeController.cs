using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryEntities;
using System.Web.Mvc;
using TobeLibraryBusinessLogic.Services;

namespace TobeLibrary.Controllers
{
    public class HomeController : Controller
    {
        private HomeService _homeSvc;

        public HomeController()
        {
            _homeSvc = new HomeService();
        }

        public HomeController(HomeService loginSvc)
        {
            _homeSvc = loginSvc;
        }

        // GET: Home
        public ActionResult Index() 
        {
            Administrators admin = TempData["admin"] as Administrators;
            return View(admin);
        }

        public ActionResult Edit(int id)
        {
            Administrators admin = _homeSvc.GetAdminForEdit(id);
            return View(admin);
        }
    }
}