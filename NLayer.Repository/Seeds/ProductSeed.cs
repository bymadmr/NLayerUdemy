using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id =1,
                CategoryId = 1,
                Price =100,
                Stock =20,
                CreateDate=DateTime.Now,
                Name="Kalem1"
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Price = 200,
                Stock = 20,
                CreateDate = DateTime.Now,
                Name = "Kalem2"
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Price = 300,
                Stock = 20,
                CreateDate = DateTime.Now,
                Name = "Kalem3"
            },
             new Product
             {
                 Id = 4,
                 CategoryId =2,
                 Price = 150,
                 Stock = 20,
                 CreateDate = DateTime.Now,
                 Name = "Kitap1"
             },
              new Product
              {
                  Id = 5,
                  CategoryId = 2,
                  Price = 140,
                  Stock = 20,
                  CreateDate = DateTime.Now,
                  Name = "Kitap2"
              });
        }
    }
}
