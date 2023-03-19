using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E_Shop.Entities
{
    public class Category : BaseEntity
    {
        public List<Product> Products { get; set; }

        public string ImageUrl { get; set; }

        public bool IsChecked { get; set; }

    }
}
