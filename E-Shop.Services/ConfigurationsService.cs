using E_Shop.Database;
using E_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Services
{
   public class ConfigurationsService
    {

        public Config GetConfigration(string key)
        {
            using (var context = new E_ShopContext())
            {
                return context.Configrations.Find(key);
            }
        }

    }
}
