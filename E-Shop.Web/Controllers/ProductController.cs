using E_Shop.Entities;
using E_Shop.Services;
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
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product Category)
        {
            productservice.AddProduct(Category);
            return RedirectToAction("ProductTable");
        }
    }
}