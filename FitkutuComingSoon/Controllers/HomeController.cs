using MailLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FitkutuComingSoon.Controllers
{
    public class HomeController : Controller
    {
        Mail Mail;

        public HomeController()
        {
            Mail = new Mail();
        }

        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmailSender()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmailSender(string email)
        {
            Mail.SendMail(email);
            return View();
        }
    }
}