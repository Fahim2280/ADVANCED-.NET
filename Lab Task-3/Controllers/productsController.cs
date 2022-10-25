using Lab_Task_3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_Task_3.Content
{
    public class productsController : Controller
    {
        EcommerceEntities db = new EcommerceEntities();
        // GET: product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult show(product obj)
        {
            if (obj != null)
            {
                return View(obj);
            }
            else
            {
                return View();
            }
            
        }

        [HttpPost]

        public ActionResult addProduct(product model)
        {
            product obj = new product();

            if (ModelState.IsValid)
            {
                obj.Id = model.Id;
                obj.Name = model.Name;
                obj.Price = model.Price;
                obj.Qty = model.Qty;

                if (model.Id==0)
                {
                    db.products.Add(obj);
                    db.SaveChanges();
                }
                else
                {
                    db.Entry(obj).State= EntityState.Modified;
                    db.SaveChanges();
                }
               

            }
           
            ModelState.Clear();
            
            return View("show");
        }

        public ActionResult productList() 
        {
            var products = db.products.ToList();
            return View(products);
        }

        public ActionResult Delete(int id) 
        {
            var delete =db.products.Where(x=>x.Id == id).First();
            db.products.Remove(delete);
            db.SaveChanges();

            var product = db.products.ToList();
            return View("productList",product);
        }
 

    }
}