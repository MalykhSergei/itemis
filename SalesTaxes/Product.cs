using System;

namespace SalesTaxes
{
    public class Product : ProductsCart
    {
        public Product(string name, Category category, bool isImported, decimal price, int productsCount)
        {
            Name = name;
            Category = category;
            IsImported = isImported;
            Price = price;
            ProductsCount = productsCount;
        }

        public override decimal CalculateTax()
        {
            decimal importedProductsTax = 0;
            decimal basicSalesTax = 0;

            if (IsImported)
            {
                importedProductsTax = Convert.ToDecimal(Convert.ToDouble(Price * ProductsCount) * 0.05);
            }

            if (Category == Category.Other)
            {
                basicSalesTax = Convert.ToDecimal(Convert.ToDouble(Price * ProductsCount) * 0.1);
            }

            return Math.Ceiling((importedProductsTax + basicSalesTax) * 20) / 20;
        }

        public override string ToString()
        {
            return $"{ProductsCount} {Name}: {Price}";
        }
    }
}