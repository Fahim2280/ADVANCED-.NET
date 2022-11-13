using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.DB;

namespace Zero_Hunger.Controllers
{
    public class RequestController : Controller
    {
        Zero_HungerEntities2 obj = new Zero_HungerEntities2();

        // GET: Request
        public ActionResult Index()
        {
            return View();
        }

        public  ActionResult request()
        {
            return View();
        }

        [HttpPost]
        public ActionResult request(Request model)
        {
            Request request = new Request();

            request.RequestId = model.RequestId;    
            request.RestName = model.RestName;
            request.FoodName = model.FoodName;
            request.Qty = model.Qty;    
            request.PreserveTime = model.PreserveTime;

            obj.Requests.Add(request);
            obj.SaveChanges();

            ModelState.Clear();
            return View("request");
        }
    }
}