using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.DB;


namespace Zero_Hunger.Controllers
{
    public class EmploveeController : Controller
    {

        Zero_HungerEntities2 obj = new Zero_HungerEntities2();

        // GET: Emplovee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddEmplovee() 
        { 
            return View();
        }

        [HttpPost]
        public ActionResult AddEmplovee(Employee model) 
        {
            Employee employee = new Employee();

            employee.EmId = model.EmId;
            employee.EmpName = model.EmpName;
            employee.Contact = model.Contact;

            obj.Employees.Add(employee);
            obj.SaveChanges();

            ModelState.Clear();
            return View("AddEmplovee");
        }

        public ActionResult ShowEmplovee() 
        {
            var show = obj.Employees.ToList();
            return View(show);
        }

        public ActionResult DeleteEmplovee(int Id) 
        {
            var Delete = (from i in obj.Employees
                          where i.EmId == Id
                          select i).FirstOrDefault();

            return View(Delete);
        }

        [HttpPost]
        public ActionResult DeleteEmplovee(Employee E)
        {
            var Delete = (from i in obj.Employees
                          where i.EmId == E.EmId
                          select i).FirstOrDefault();

            var delete = (from i in obj.EmployeeAssigns
                          where i.EmployeeId == E.EmId
                          select i).FirstOrDefault();

            if(Delete.EmId == delete.EmployeeId)
            {
                //delete.Id = null;
                obj.Employees.Remove(Delete);
                obj.SaveChanges();
            }
            else
            {
                obj.Employees.Remove(Delete);
                obj.SaveChanges();
            }

            return RedirectToAction("ShowEmplovee");
        }


        public ActionResult AssignEmplovee() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult AssignEmplovee(EmployeeAssign E) 
        {
            /*var Assign = (from i in obj.EmployeeAssigns 
                          where i.EmployeeId == E.EmployeeId
                          select i).FirstOrDefault();
            obj.Entry(Assign).CurrentValues.SetValues(E);*/
            obj.EmployeeAssigns.Add(E);
            obj.SaveChanges ();
            return RedirectToAction("AssignEmplovee");
        }

        public ActionResult ShowAssignEmplove() 
        {
            var show = obj.EmployeeAssigns.ToList();
            return View(show);
        }
    }
}