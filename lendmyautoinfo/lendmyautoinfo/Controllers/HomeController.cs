using lendmyautoinfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace lendmyautoinfo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ContactUsData model = new ContactUsData();
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(ContactUsData model)
        {
            return View();
        }

        public ActionResult Sharing()
        {
            return View();
        }
    }
}