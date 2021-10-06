using System;

namespace SalesTaxes
{
    internal class Product : ProductsCart
    {
        internal Product(string name, Category category, bool isImported, decimal price, int productsCount)
        {
            Name = name;
            Category = category;
            IsImported = isImported;
            Price = price;
            ProductsCount = productsCount;
        }

        public override decimal CalculateTax()
        {
            decimal importedTax = 0;
            decimal salesTax = 0;

            if (IsImported)
            {
                importedTax = Convert.ToDecimal(Convert.ToDouble(Price * ProductsCount) * 0.05);
            }

            if (Category == Category.Other)
            {
                salesTax = Convert.ToDecimal(Convert.ToDouble(Price * ProductsCount) * 0.1);
            }

            return Math.Ceiling((importedTax + salesTax) * 20) / 20;
        }

        public override string ToString()
        {
            return $"{ProductsCount} {Name}: {Price}";
        }
    }
}