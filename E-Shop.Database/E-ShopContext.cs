using E_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Database
{
   public class E_ShopContext : DbContext,IDisposable
    {
        public E_ShopContext() : base("E-ShopConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Config> Configrations { get; set; }
    }
}
