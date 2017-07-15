using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TejeratBankReporting.Core;

namespace TejeratBankReporting.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInstallmentService _productService;
        public HomeController(IInstallmentService ff)
        {
            _productService = ff;
        }
        public ActionResult Index()
        {
            var kk = _productService.List();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}