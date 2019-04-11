using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Githubexample.Controllers
{//Candidate release
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.Message = "Your application description page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult Test()
        {
            ViewBag.Message = "Your application description page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult TestMA()
        {
            ViewBag.Message = "Your application description page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult TestMA1()
        {
            ViewBag.Message = "Your application description page.";
            //comment view 1
            //comment by mohit

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}