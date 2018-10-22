using lendmyautoinfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public ActionResult Contact(int scroll = 0)
        {
            ContactUsData model = new ContactUsData();
            if (scroll == 1) {
                model.Scroll = true;
            }
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(ContactUsData model)
        {
            if (ModelState.IsValid) {
                ModelState.Clear();
                ContactUsData returnModel = new ContactUsData()
                {
                    AlertName = model.Name,
                    Success = true,
                };
                 SendEmail(model.EmailAddress, model.Name, model.Reason, model.Message);
                return View(returnModel);
            }
           
            
            return View(model);
        }
        public void SendEmail(string emailAddress, string Name, string Reason, string Message)
        {
            GMailer.GmailUsername = "bfhchicken@gmail.com";
            GMailer.GmailPassword = "mateoreyrosa";
            if (Reason == "SignUP")
            {
                Reason = "Sign Up";
            }
            else {
                Reason = "Learn More";
            }
            GMailer mailer = new GMailer
            {
                ToEmail = "bfhchicken@gmail.com",
                Subject = Reason,
                Body = "The following message is from the Lend My Auto website: " + Environment.NewLine +  Name + " wants to " + Reason + ". They left the following message: " + Message + Environment.NewLine + " Their email address is: " + emailAddress,
                IsHtml = true
            };
              mailer.Send();
        }

        public ActionResult Sharing()
        {
            return View();
        }

        public ActionResult FAQ() {
            return View();
        }
        public ActionResult TermsAndConditions() {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public void UpdateSurvey() {

            Session["Survey"] = 0; 
        }
    }
}