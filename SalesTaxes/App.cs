using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesTaxes
{
    internal class App
    {
        private static void Main()
        {
            var products = new List<ProductsCart>()
            {
                new Product("imported bottle of perfume", Category.Other, true, 27.99M, 1),
                new Product("bottle of perfume", Category.Other, false, 18.99M, 1),
                new Product("packet of headache pills", Category.MedicalProducts, false, 9.75M, 1),
                new Product("box of imported chocolates", Category.Food, true, 11.25M, 1)
            };

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine($"Sales Taxes: {products.Sum(product => product.CalculateTax()):.00}");
            Console.WriteLine($"Total: {products.Sum(product => (product.Price * product.ProductsCount) + product.CalculateTax()):.00}");
        }
    }
}