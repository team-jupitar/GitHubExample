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

        public ActionResult CheckPullRequest()
        {
            return PartialView();
        }

        public ActionResult CherryPick()
        {
            return PartialView();
        }


        public ActionResult PullReq()
        {
            return PartialView();
        }

        public ActionResult MohitNiManda()
        {
            return PartialView();
        }


        public ActionResult TestCherryPick()
        {
            return PartialView();
        }

        public ActionResult TestCherryPickAgain()
        {
            return PartialView();
        }



        public ActionResult TestCherryPickFerToh()
        {
            return PartialView();
        }


        public ActionResult LoadData()
        {
           ViewData["Message"]="User ViewData";


            ViewBag.canI="Don't Use It. Its new method.";
            ViewBag.can2="Don't Use It. Its new method.2";
            TempData["Temp"]="Data";

            ViewBag.canI="Its new method. Not tested yet";
            ViewBag.canI = "Changes in Mohit Branch.";
            return View();
        }

        public ActionResult MohitFunction()
        {
            ViewData["Info"] = "This is test method";
            return View();
        }

        public ActionResult MohitFunctionFirst()
        {
            ViewData["Info"] = "This is test method";
            return View();
        }

        public ActionResult MohitTest123()
        {
            ViewData["Info"] = "This is test method";
            return View();
        }

        public ActionResult MohitTest456()
        {
            ViewData["Info"] = "This is test method";
            return View();
        }

        public ActionResult MohitTest789()
        {
            ViewData["Info"] = "This is test method";
            return View();
        }

        public ActionResult MohitFunctionSecond()
        {
            ViewData["Info"] = "This is test method";
            return View();
        }

        public ActionResult LoadData1()
        {
           ViewData["Message"]="1";
            ViewBag.canI="1";
            TempData["Temp"]="1";

            return View();
        }


           public ActionResult LoadData2()
        {
           ViewData["Message"]="2";
            ViewBag.canI="2";
            TempData["Temp"]="2";

            return View();
        }


            public ActionResult LoadData3()
        {
           ViewData["Message"]="3";
            ViewBag.canI="3";
            TempData["Temp"]="3";

            return View();
        }


           public ActionResult LoadData4()
        {
           ViewData["Message"]="4";
            ViewBag.canI="4";
            TempData["Temp"]="4";

            return View();
        }


        public ActionResult Feature1()
        {
            TempData["Data"] = "Temp Data is important";
            return View();
        }

        public ActionResult Feature2()
        {
            ViewData["Data"] = "So View Data is.";
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