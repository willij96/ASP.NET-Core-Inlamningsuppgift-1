using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Models
{
    public class Category
    {
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Category(int id)
        {
            Id = id;
        }

        public Category()
        {

        }

        public int Id { get; set; }  
        public string Name { get; set; }

        public List<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();


    }
}
