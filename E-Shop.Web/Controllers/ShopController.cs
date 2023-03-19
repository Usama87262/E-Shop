using E_Shop.Services;
using E_Shop.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Web.Controllers
{
    public class ShopController : Controller
    {
        ProductsService productservice = new ProductsService();

       public ActionResult Checkout()
        {
            Chekoutviewmodel model = new Chekoutviewmodel();

            var cartproductscookie = Request.Cookies["cartproducts"];

            if(cartproductscookie !=null )
            {
                //var products = cartproductscookie.Value;
                //var ids = products.Split('-');
                //List<int> pids = ids.Select(x => int.Parse(x)).ToList();

                model.productsid = cartproductscookie.Value.Split('-').Select(x => int.Parse(x)).ToList();

                model.Cartproducts = productservice.GetCartProduct(model.productsid);
            }

            return View(model);
        }
    }
}