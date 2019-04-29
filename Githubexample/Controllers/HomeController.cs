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

        public ActionResult LoadData()
        {
           ViewData["Message"]="User ViewData";

            ViewBag.canI="Don't Use It. Its new method.";
            TempData["Temp"]="Data";
            return View();
        }

        public ActionResult LoadData1()
        {
           ViewData["Message"]="1";
            ViewBag.canI="1";
            TempData["Temp"]="1";

            return View();
        }


        public ActionResult TestApril()
            {
            ViewData["Merge"]="Merge";
            ViewData["Check"] = "Checking";
            return View();
}

        public ActionResult maraprfeaturemthod3()
        {
            ViewBag.Message = "Your application april feature3 page.";

            ViewBag.Message = "Your application april feature3 page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult maraprfeaturemthod2()
        {
            ViewBag.Message = "Your application april feature2 page.";

            ViewBag.Message = "Your application april feature2 page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult maraprfeaturemthod1()
        {
            ViewBag.Message = "Your application april feature page.";

            ViewBag.Message = "Your application april feature page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult testMethodStash4()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.Message = "Your application description page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult testMethodStash5()
        {
            ViewBag.Message = "Your testmethodstatsh5";

            ViewBag.Message = "Your application description page- testmethodstash5";
            //comment view 1
            //comment by mohit

            return View();
        }

        public ActionResult testMethodStash6()
        {
            ViewBag.Message = "Your testmethodstatsh6";

            ViewBag.Message = "Your application description page- testmethodstash7";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult testMethodStash7()
        {
            ViewBag.Message = "Your testmethodstatsh7";

            ViewBag.Message = "Your application description page- testmethodstash7";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult testMethodStash2()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.Message = "Your application description page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult testMethodStash1()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.Message = "Your application description page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult testMethod1()
        {
            ViewBag.Message = "Your application description page.";


            ViewBag.Message = "Your application description page.";
            //comment view 1
            //comment by mohit

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
        public ActionResult testbeta()
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