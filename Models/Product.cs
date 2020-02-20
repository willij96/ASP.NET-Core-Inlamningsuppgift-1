using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Models
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string name, string articleNumber, string description, Uri imageUrl, decimal price, string urlSlug)
        {
            Name = name;
            ArticleNumber = articleNumber;
            Description = description;          
            ImageUrl = imageUrl;
            Price = price;
            UrlSlug = urlSlug;
        }

        public Product(int id, string name, string articleNumber, string description, Uri imageUrl, decimal price, string urlSlug)
        {
            Id = id;
            Name = name;
            ArticleNumber = articleNumber;
            Description = description;           
            ImageUrl = imageUrl;
            Price = price;
            UrlSlug = urlSlug;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ArticleNumber { get; set; }
        public string Description { get; set; }       
        public Uri ImageUrl { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string UrlSlug { get; set; }

        public List<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    }
}
