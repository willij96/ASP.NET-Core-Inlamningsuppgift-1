using System;
using System.Collections.Generic;
using System.Text;
using FreakyFashion1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=FreakyFashion1;Trusted_Connection=True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(x => new { x.ProductId, x.CategoryId });

            var products = new List<Product>
            {
                new Product(1, "Klänning", "100", "Lorem ipsum dolor", new Uri("/images/beicheDress.jpg", 
                UriKind.Relative), 499,"Lorem-ipsum-dolor-1"),
                new Product(2, "T-shirt", "100", "Lorem ipsum dolor", new Uri("/images/Prada.jpg",
                UriKind.Relative), 499,"Lorem-ipsum-dolor-2"),
                new Product(3, "Klänning", "200", "Lorem ipsum dolor", new Uri("/images/beicheDress.jpg", 
                UriKind.Relative), 399,"Lorem-ipsum-dolor-3"),
                new Product(4, "Byxor", "100", "Lorem ipsum dolor", new Uri("/images/jeans.jpg",
                UriKind.Relative), 499,"Lorem-ipsum-dolor-4"),
                new Product(5, "Klänning", "100", "Lorem ipsum dolor", new Uri("/images/beicheDress.jpg",
                UriKind.Relative), 499,"Lorem-ipsum-dolor-5"),
                new Product(6, "Byxor", "100", "Lorem ipsum dolor", new Uri("/images/jeans.jpg",
                UriKind.Relative), 499,"Lorem-ipsum-dolor-6"),
                new Product(7, "T-shirt", "100", "Lorem ipsum dolor", new Uri("/images/Prada.jpg",
                UriKind.Relative), 499,"Lorem-ipsum-dolor-7"),
                new Product(8, "Klänning", "100", "Lorem ipsum dolor", new Uri("/images/beicheDress.jpg",
                UriKind.Relative), 499,"Lorem-ipsum-dolor-8"),


                new Product(9, "Byxor", "200", "Lorem ipsum dolor", new Uri("/images/jeans.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-9"),
                new Product(10, "Klänning", "200", "Lorem ipsum dolor", new Uri("/images/beicheDress.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-10"),
                new Product(11, "T-shirt", "200", "Lorem ipsum dolor", new Uri("/images/Prada.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-11"),                
                new Product(12, "Byxor", "200", "Lorem ipsum dolor", new Uri("/images/jeans.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-12"),
                new Product(13, "T-shirt", "200", "Lorem ipsum dolor", new Uri("/images/Prada.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-13"),
                new Product(14, "Klänning", "200", "Lorem ipsum dolor", new Uri("/images/beicheDress.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-14"),
                new Product(15, "T-shirt", "200", "Lorem ipsum dolor", new Uri("/images/Prada.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-15"),
                new Product(16, "Byxor", "100", "Lorem ipsum dolor", new Uri("/images/jeans.jpg",
                UriKind.Relative), 499,"Lorem-ipsum-dolor-16"),


                new Product(17, "T-shirt", "200", "Lorem ipsum dolor", new Uri("/images/Prada.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-17"),
                new Product(18, "Klänning", "200", "Lorem ipsum dolor", new Uri("/images/beicheDress.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-18"),
                new Product(19, "Byxor", "200", "Lorem ipsum dolor", new Uri("/images/jeans.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-19"),                
                new Product(20, "T-shirt", "100", "Lorem ipsum dolor", new Uri("/images/Prada.jpg",
                UriKind.Relative), 499,"Lorem-ipsum-dolor-20"),
                new Product(21, "T-shirt", "200", "Lorem ipsum dolor", new Uri("/images/Prada.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-21"),
                new Product(22, "Byxor", "200", "Lorem ipsum dolor", new Uri("/images/jeans.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-22"),
                new Product(23, "Klänning", "200", "Lorem ipsum dolor", new Uri("/images/beicheDress.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-23"),
                new Product(24, "Byxor", "200", "Lorem ipsum dolor", new Uri("/images/jeans.jpg",
                UriKind.Relative), 399,"Lorem-ipsum-dolor-24"),

            };

            products.ForEach(x => modelBuilder.Entity<Product>().HasData(x));

       

            var categories = new List<Category>
            {
                new Category(1, "Klänning"),
                new Category(2, "T-shirt"),
                new Category(3, "Byxor"),
                new Category(4, "Rea")


            };

            categories.ForEach(x => modelBuilder.Entity<Category>().HasData(x));


            var productCategory = new List<ProductCategory>
            {
                new ProductCategory(products[0].Id,categories[0].Id),
                new ProductCategory(products[1].Id,categories[1].Id),
                new ProductCategory(products[2].Id,categories[0].Id),
                new ProductCategory(products[3].Id,categories[2].Id),
                new ProductCategory(products[4].Id,categories[0].Id),
                new ProductCategory(products[5].Id,categories[2].Id),
                new ProductCategory(products[6].Id,categories[1].Id),
                new ProductCategory(products[7].Id,categories[0].Id),

                new ProductCategory(products[8].Id,categories[2].Id),
                new ProductCategory(products[9].Id,categories[0].Id),
                new ProductCategory(products[10].Id,categories[1].Id),
                new ProductCategory(products[11].Id,categories[2].Id),
                new ProductCategory(products[12].Id,categories[1].Id),
                new ProductCategory(products[13].Id,categories[0].Id),
                new ProductCategory(products[14].Id,categories[1].Id),
                new ProductCategory(products[15].Id,categories[2].Id),

                new ProductCategory(products[16].Id,categories[1].Id),
                new ProductCategory(products[17].Id,categories[0].Id),
                new ProductCategory(products[18].Id,categories[2].Id),
                new ProductCategory(products[19].Id,categories[1].Id),
                new ProductCategory(products[20].Id,categories[1].Id),
                new ProductCategory(products[21].Id,categories[2].Id),
                new ProductCategory(products[22].Id,categories[0].Id),
                new ProductCategory(products[23].Id,categories[2].Id),
                new ProductCategory(products[1].Id,categories[3].Id),
                new ProductCategory(products[2].Id,categories[3].Id),


            };

            productCategory.ForEach(x => modelBuilder.Entity<ProductCategory>().HasData(x));
        }
    }
}
