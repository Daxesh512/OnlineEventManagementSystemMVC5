using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using OnlineEventManagementSystemMVC5.Models;


namespace OnlineEventManagementSystemMVC5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registartion(TblUser r1)
        {
            using (EventDTOEntities db = new EventDTOEntities())
            {
                if (ModelState.IsValid)
                {
                    db.TblUsers.Add(r1);
                    db.SaveChanges();
                    ViewBag.message("Registration Sucessfully");
                    ModelState.Clear();
                }
            }
            return View(r1);
        }
        [HttpPost]
        public ActionResult Login(TblUser r1)
        {
            using (EventDTOEntities db = new EventDTOEntities())
            {
                if (ModelState.IsValid)
                {
                    var log = db.TblUsers.Where(a => a.userName.Equals(r1.userName) && a.pass.Equals(r1.pass)).FirstOrDefault();
                    if (log != null)
                    {
                        return RedirectToAction("Contact");
                    }

                    ViewBag.message("Login Sucessfully");
                    ModelState.Clear();
                }
            }
            return View(r1);
        }


    }
}