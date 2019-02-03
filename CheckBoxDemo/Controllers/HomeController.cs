using CheckBoxDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckBoxDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewRecord()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult NewRecord(StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }


            return View();
        }
    }
}