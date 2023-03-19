using E_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Shop.Web.ViewModel
{
    public class Chekoutviewmodel
    {

        public List<Product> Cartproducts { get; set; }

        public List<int> productsid { get; set; }
    }
}