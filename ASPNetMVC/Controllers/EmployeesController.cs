using ASPNetMVC.Context;
using ASPNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ASPNetMVC.FilterConfig;

namespace ASPNetMVC.Controllers
{
    public class EmployeesController : Controller
    {
        private MyContext myContext = new MyContext();
        // GET: Employees
        public ActionResult Index()
        {
            if (Session["Id"] != null)
            {
                return RedirectToAction("Edit", "Employees", new { Id = Session["Id"] });
            }
            else
            {
                return RedirectToAction("Login", "Accounts", new { area = "" });
            }
        }

        public ActionResult Details(int Id)
        {
            return View(myContext.Employees.Find(Id));
        }

        public ActionResult Create()
        {
            List<Division> list = myContext.Divisions.ToList();
            ViewBag.DivisionList = new SelectList(list,"Id","Name");
            return View(myContext.Employees.Create());
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            myContext.Employees.Add(employee);
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            if (Session["Id"] != null)
            {
                List<Division> list = myContext.Divisions.ToList();
                ViewBag.DivisionList = new SelectList(list, "Id", "Name");
                return View(myContext.Employees.Find(Id));
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            myContext.Entry(employee).State = EntityState.Modified;
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            return View(myContext.Employees.Find(Id));
        }

        [HttpPost]
        public ActionResult Delete(int Id, Employee employee)
        {
            var delete = myContext.Employees.Find(Id);
            myContext.Employees.Remove(delete);
            var deleteAcc = myContext.Accounts.Find(Id);
            myContext.Accounts.Remove(deleteAcc);
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}