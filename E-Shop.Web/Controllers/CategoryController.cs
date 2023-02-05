using E_Shop.Entities;
using E_Shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService Catservices = new CategoriesService();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category Category)
        {
            Catservices.AddCategory(Category);
            return View();
        }

    }
}