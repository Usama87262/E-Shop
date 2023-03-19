using E_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Shop.Web.ViewModel
{
    public class ProductViewModels
    {
    }

    public class EditProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CatId { get; set; }
        public string ImageUrl { get; set; }

        public List<Category> AvailableCategories { get; set; }
    }
}