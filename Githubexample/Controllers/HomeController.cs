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

        public ActionResult UpdateGridData()
        {
            return PartialView();
        }

        public ActionResult UpdateUserInfo()
        {
            return PartialView();
        }

        public ActionResult CherryPick()
        {
            return PartialView();
        }



        public ActionResult SaveActivities()
        {
            return PartialView();
        }



        public ActionResult LoadData()
        {
            ViewData["Message"] = "User ViewData";
            ViewBag.canI = "Don't Use It12";
            return View();
        }

        public ActionResult MohitFunction()
        {
            ViewData["Info"] = "This is test method";
            return View();
        }

        public ActionResult LoadData1()
        {
            ViewData["Info"] = "This is test method";
            return View();
        }

        public ActionResult LoadData1()
        {
            ViewBag.Message = "Your application april marBranch4 page.";

            ViewBag.Message = "Your application april marBranch4 page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult marcandidate()
        {
            ViewBag.Message = "Your application april marcandidate page.";

            ViewBag.Message = "Your application april marcandidate page.";
            //comment view 1
            //comment by mohit

            return View();
        }

        public ActionResult maraprfeaturebrach4()
        {
            ViewBag.Message = "Your application april maraprfeaturebrach3 page.";

            ViewBag.Message = "Your application april maraprfeaturebrach3 page.";
            //comment view 1
            //comment by mohit

            return View();
        }
        public ActionResult maraprfeaturebrach3()
        {
            ViewBag.Message = "Your application april maraprfeaturebrach3 page.";

            ViewBag.Message = "Your application april maraprfeaturebrach3 page.";
            //comment view 1
            //comment by mohit

            return View();
        }

            public ActionResult maraprcandidate()
            {
                ViewBag.Message = "Your application april feature3 page.";

                ViewBag.Message = "Your application april feature3 page.";
                //comment view 1
                //comment by mohit

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