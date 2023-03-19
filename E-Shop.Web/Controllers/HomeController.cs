using E_Shop.Services;
using E_Shop.Web.Models;
using E_Shop.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Web.Controllers
{
    public class HomeController : Controller
    {
        CategoriesService Categoryservice = new CategoriesService();

        public ActionResult Index()
        {
            HomeViewModels model = new HomeViewModels();
            model.FeaturedCategories = Categoryservice.GetFeaturedCategory();

            return View(model);
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