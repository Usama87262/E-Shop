using E_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Shop.Web.ViewModel
{
    public class CategoryViewModels
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public int CatId { get; set; }


    }

    public class CategorySearchViewModel
    {
        public List<Category> categories { get; set; }
        public string Searchterm { get; set; }
    }
}