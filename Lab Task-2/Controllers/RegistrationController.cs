using Lab_Task_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_Task_2.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(student std) 
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success", "Registration");
            }
            return View(std);
        }

        public ActionResult Success() 
        {
            return View();
        }
    }
}