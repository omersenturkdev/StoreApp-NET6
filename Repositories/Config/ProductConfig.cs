using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p=> p.Price).IsRequired();
            builder.HasData(
                new Product()
                {
                    ProductId = 1,
                    CategoryId = 2,
                    ProductName = "Computer",
                    ImageUrl = "/images/1.jpg",
                    Price = 15000
                },
                new Product()
                {
                    ProductId = 2,
                    CategoryId = 2,
                    ProductName = "Keyboard",
                    ImageUrl = "/images/2.jpg",
                    Price = 9000
                },
                new Product()
                {
                    ProductId = 3,
                    CategoryId = 2,
                    ProductName = "Mouse",
                    ImageUrl = "/images/3.jpg",
                    Price = 8000
                },
                new Product()
                {
                    ProductId = 4,
                    CategoryId = 1,
                    ProductName = "Little Prence",
                    ImageUrl = "/images/4.jpg",
                    Price = 80
                },
                new Product()
                {
                    ProductId = 5,
                    CategoryId = 1,
                    ProductName = "Hamlet",
                    ImageUrl = "/images/5.jpg",
                    Price = 120
                }
             );
        }
    }
}
