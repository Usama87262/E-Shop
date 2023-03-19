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
    public class ProductController : Controller
    {
        ProductsService productservice = new ProductsService();
        CategoriesService categoryservice = new CategoriesService();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string search)
        {
            var products = productservice.GetProduct();

           if(!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name !=null && p.Name.ToLower() .Contains(search.ToLower())).ToList();
            }
           
            return PartialView(products);
        }

        [HttpGet]  
        public ActionResult Create()
        {
            CategoriesService categories = new CategoriesService();
            var catlist = categories.GetCategory();

            return PartialView(catlist);
        }

        [HttpPost]
        public ActionResult Create(CategoryViewModels model)
        {
            CategoriesService categoriesService = new CategoriesService();

            var newproduct = new Product();
            newproduct.Name = model.Name;
            newproduct.Description = model.Description;
            newproduct.Price = model.price;
            newproduct.Category = categoriesService.getCatId(model.CatId);
            productservice.AddProduct(newproduct);
            return RedirectToAction("ProductTable");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EditProductViewModel model = new EditProductViewModel();

            var product = productservice.GetPrdId(id);

            model.Id = product.Id;
            model.Name = product.Name;
            model.Description = product.Description;
            model.Price = product.Price;
            model.CatId = product.Category != null ? product.Category.Id : 0;
            //model.ImageUrl = product.ImageURL;
            model.AvailableCategories = categoryservice.GetCategory();

            return PartialView(model);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productservice.UpdatePrd(product);
            return RedirectToAction("ProductTable");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            productservice.DeletePrd(id);
            return RedirectToAction("ProductTable");
        }
    }
}