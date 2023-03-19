using E_Shop.Database;
using E_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace E_Shop.Services
{
   public class ProductsService
    {
        public void AddProduct(Product product)
        {
            using (var prd = new E_ShopContext())
            {
                prd.Entry(product).State = System.Data.Entity.EntityState.Unchanged;

                prd.products.Add(product);
                prd.SaveChanges();
            }
            
        }

        public List<Product> GetProduct()
        {

            using (var prd = new E_ShopContext())
            {
                return prd.products.Include(x=>x.Category).ToList();
            }
        }


        public List<Product> GetCartProduct(List<int> prdids)
        {
            using (var prd = new E_ShopContext())
            {
                return prd.products.Where(x => prdids.Contains(x.Id)).ToList();
            }
        }


        public Product GetPrdId(int id)
        {
            using (var prd = new E_ShopContext())
            {
                return prd.products.Find(id);
            }
        }

        public void UpdatePrd(Product product)
        {
            using (var prd = new E_ShopContext())
            {
                prd.Entry(product).State = System.Data.Entity.EntityState.Modified;
                prd.SaveChanges();
            }
        }

        public void DeletePrd (int Id)
        {
            using (var prd = new E_ShopContext())
            {
                var prdid = prd.products.Find(Id);
                prd.products.Remove(prdid);
                prd.SaveChanges();
            }
        }
    }
}
