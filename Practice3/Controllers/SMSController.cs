using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.AspNet.Core;

namespace Practice3.Controllers
{
    public class SMSController : TwilioController
    {
        // GET: SMS
        public ActionResult Index()
        {
            return View();
        }
    }
}