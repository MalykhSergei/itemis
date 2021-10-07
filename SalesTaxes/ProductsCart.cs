namespace SalesTaxes
{
    public abstract class ProductsCart
    {
        public string Name { get; set; }

        public Category Category { get; set; }

        public decimal Price { get; set; }

        public bool IsImported { get; set; }

        public int ProductsCount { get; set; }

        public abstract decimal CalculateTax();
    }
}