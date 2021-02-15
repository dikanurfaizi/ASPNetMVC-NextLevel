using ASPNetMVC.Context;
using ASPNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetMVC.Controllers
{
    public class DivisionsController : Controller
    {
        private MyContext myContext = new MyContext();
        // GET: Divisions

        public ActionResult Index()
        {
            if (Session["Id"] != null)
            {
                return View(myContext.Divisions.ToList());
            }
            else
            {
                return RedirectToAction("Login", "Accounts");
            }
        }

        public ActionResult Details(int Id)
        {
            return View(myContext.Divisions.Find(Id));
        }

        public ActionResult Create()
        {
            return View(myContext.Divisions.Create());
        }

        [HttpPost]
        public ActionResult Create(Division division)
        {
            myContext.Divisions.Add(division);
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            return View(myContext.Divisions.Find(Id));
        }

        [HttpPost]
        public ActionResult Edit(Division division)
        {
            myContext.Entry(division).State = EntityState.Modified;
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            return View(myContext.Divisions.Find(Id));
        }

        [HttpPost]
        public ActionResult Delete(int Id, Division division)
        {
            var delete = myContext.Divisions.Find(Id);
            myContext.Divisions.Remove(delete);
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}