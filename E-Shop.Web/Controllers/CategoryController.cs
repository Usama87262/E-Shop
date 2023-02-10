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
        public ActionResult Index()
        {
            var catlist = Catservices.GetCategory();
            return View(catlist);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category Category)
        {
            Catservices.AddCategory(Category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var catid = Catservices.getCatId(Id);
            return View(catid);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            Catservices.UpdateCat(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var catid = Catservices.getCatId(Id);
            return View(catid);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            Catservices.DeleteCat(category.Id);
            return RedirectToAction("Index");
            
            
        }
    }
}