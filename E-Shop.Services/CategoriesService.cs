using E_Shop.Database;
using E_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Services
{
   public class CategoriesService
    {
        public void AddCategory(Category Category)
        {
            using (var cat = new E_ShopContext())
            {
                cat.Categories.Add(Category);
                cat.SaveChanges();
            }
            
        }
    }
}
