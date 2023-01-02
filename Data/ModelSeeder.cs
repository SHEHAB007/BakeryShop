using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BakeryShop.Data
{
    public static class ModelSeeder
    {
        public static ModelBuilder Seed (this ModelBuilder modelBuilder)
        {
            Product[] products =
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Bread",
                    ProductDescription = "Normal Bread",
                    ImageName = "Bread.jpeg",
                    ProductPrice = 5
                    
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Brown Bread",
                    ProductDescription = "Brown Fresh Bread",
                    ImageName = "BrownBread.jpeg",
                    ProductPrice = 10


                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Corwasant",
                    ProductDescription = "Fresh Corwasant",
                    ImageName = "Corwasant.jpeg",
                    ProductPrice = 7.5M

                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "CupCakes",
                    ProductDescription = "Fresh CupCakes",
                    ImageName = "CupCakes.jpeg",
                    ProductPrice = 15

                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "DarkTost",
                    ProductDescription = "Fresh DarkTost",
                    ImageName = "DarkTost.jpeg",
                    ProductPrice = 7.5M

                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "FrenchBread",
                    ProductDescription = "Fresh FrenchBread",
                    ImageName = "FrenchBread.jpeg",
                    ProductPrice = 35

                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "ItalianBread",
                    ProductDescription = "Fresh ItalianBread",
                    ImageName = "ItalianBread.jpeg",
                    ProductPrice = 45

                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "Sandwiches",
                    ProductDescription = "Fresh Sweet Sandwiches",
                    ImageName = "Sandwiches.jpeg",
                    ProductPrice = 10

                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "WhiteTost",
                    ProductDescription = "Fresh WhiteTost",
                    ImageName = "WhiteTost.jpeg",
                    ProductPrice = 7.5M

                }
            }; 
            modelBuilder.Entity<Product>().HasData(products);
            return modelBuilder;
        }
    }
}
