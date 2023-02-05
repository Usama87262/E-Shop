using E_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Database
{
    class E_ShopContext : DbContext
    {
        public E_ShopContext() : base("E-ShopConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
