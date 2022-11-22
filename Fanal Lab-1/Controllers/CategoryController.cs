using BAL.Services;
using BAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fanal_Lab_1.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CategoryRequest cat)
        {
            CategoryService.Add(cat);
            return View("Add");
        }
    }
}