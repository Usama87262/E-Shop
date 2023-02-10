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

        public List<Category> GetCategory()
        {
            using (var cat = new E_ShopContext())
            {
                return cat.Categories.ToList();
            }
        }

        public Category getCatId(int id)
        {
            using (var cat = new E_ShopContext())
            {
                return cat.Categories.Find(id);
            }
        }

        public void UpdateCat(Category category)
        {
            using (var cat = new E_ShopContext())
            {
                cat.Entry(category).State = System.Data.Entity.EntityState.Modified;
                cat.SaveChanges();
            }
        }

        public void DeleteCat (int Id)
        {
            using (var cat = new E_ShopContext())
            {
                var catid = cat.Categories.Find(Id);
                cat.Categories.Remove(catid);
                cat.SaveChanges();
            }
        }
    }
}
