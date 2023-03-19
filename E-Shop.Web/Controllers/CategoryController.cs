using E_Shop.Entities;
using E_Shop.Services;
using E_Shop.Web.ViewModel;
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
            return View();
        }

        public ActionResult CategoryTable(string search)
        {

            CategorySearchViewModel model = new CategorySearchViewModel();
            model.Searchterm = search;

            var catlist = Catservices.GetCategory();

            return PartialView(catlist);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Category Category)
        {
            Catservices.AddCategory(Category);
            return RedirectToAction("CategoryTable");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var catid = Catservices.getCatId(Id);
            return PartialView(catid);
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