﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult MakeBooking()
        {
            return View(new Appointment() {Date = DateTime.Now});
        }

        [HttpPost]
        public ViewResult MakeBooking(Appointment appt)
        {
            //if (string.IsNullOrEmpty(appt.ClientName))
            //{
            //    ModelState.AddModelError("ClientName", "Please enter your name");
            //}
            //if (ModelState.IsValidField("Date") && DateTime.Now > appt.Date)
            //{
            //    ModelState.AddModelError("Date", "enter a date in the future");
            //}
            //if (!appt.TermsAccepted)
            //{
            //    ModelState.AddModelError("TermsAccepted", "Resistance id futile");
            //}
            //if (ModelState.IsValidField("ClientName") && ModelState.IsValidField("Date"))
            //{
            //    if (appt.ClientName == "Andy" && appt.Date.DayOfWeek == DayOfWeek.Monday)
            //    {
            //        ModelState.AddModelError("", "No monday appts for andy");
            //    }
            //}





            if (ModelState.IsValid)
            {
                return View("Compleated", appt);
            }

            return View();
        }
    }
}