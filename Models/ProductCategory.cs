using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Models
{
    public class ProductCategory
    {
        public int ProductId { get; protected set; }
        public int CategoryId { get; protected set; }
        public Product Product { get; protected set; }
        public Category Category { get; protected set; }

        public ProductCategory(int productId, int categoryId)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }

        public ProductCategory(int categoryId, Product product)
        {
            CategoryId = categoryId;
            Product = product;
            
        }
    }
}
