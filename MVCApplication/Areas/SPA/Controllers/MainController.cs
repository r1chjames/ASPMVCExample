using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MVCApplication.Filters;
using MVCApplication.Models;
using MVCApplication.ViewModels.SPA;
using OldViewModel = MVCApplication.ViewModels;

namespace MVCApplication.Areas.SPA.Controllers
{
    public class MainController : Controller
    {

        public ActionResult Index()
        {
            MainViewModel v = new MainViewModel();
            v.UserName = User.Identity.Name;
            v.FooterData = new OldViewModel.FooterViewModel();
            v.FooterData.CompanyName = "RichJames";//Can be set to dynamic value
            v.FooterData.Year = DateTime.Now.Year.ToString();
            return View("Index", v);
        }
    }
}