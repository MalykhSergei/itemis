using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxes;

namespace TestSalesTaxes
{
    [TestClass]
    public class ProductTests
    {
        public Product Product { get; set; }

        [TestMethod]
        public void TestCalculateBooksTax()
        {
            Product = new Product("Clean code", Category.Book, false, 45M, 1);

            var bookTax = Product.CalculateTax();

            Assert.AreEqual(0, bookTax);
        }

        [TestMethod]
        public void TestCalculateFoodTax()
        {
            Product = new Product("Potato", Category.Food, false, 3M, 1);

            var foodTax = Product.CalculateTax();

            Assert.AreEqual(0, foodTax);
        }

        [TestMethod]
        public void TestCalculateMedicalProductsTax()
        {
            Product = new Product("Aspirin", Category.MedicalProducts, false, 10M, 1);

            var medicalProductsTax = Product.CalculateTax();

            Assert.AreEqual(0, medicalProductsTax);
        }

        [TestMethod]
        public void TestCalculateBasicTax()
        {
            Product = new Product("Keyboard", Category.Other, false, 100M, 1);

            var basicTax = Product.CalculateTax();

            Assert.AreEqual(10, basicTax);
        }

        [TestMethod]
        public void TestCalculateImportedNonExemptProductsTax()
        {
            Product = new Product("Mouse", Category.Other, true, 15M, 1);

            var importedNonExemptProductsTax = Product.CalculateTax();

            Assert.AreEqual(2.25M, importedNonExemptProductsTax);
        }

        [TestMethod]
        public void TestCalculateImportedFoodProductsTax()
        {
            Product = new Product("Apple", Category.Food, true, 2M, 1);

            var importedFoodProductsTax = Product.CalculateTax();

            Assert.AreEqual(0.1M, importedFoodProductsTax);
        }

        [TestMethod]
        public void TestCalculateImportedMedicalProductsTax()
        {
            Product = new Product("Nose drops", Category.MedicalProducts, true, 4M, 1);

            var importedMedicalProductsTax = Product.CalculateTax();

            Assert.AreEqual(0.2M, importedMedicalProductsTax);
        }

        [TestMethod]
        public void TestCalculateImportedBookProductsTax()
        {
            Product = new Product("Nose drops", Category.Book, true, 20M, 1);

            var importedBookProductsTax = Product.CalculateTax();

            Assert.AreEqual(1, importedBookProductsTax);
        }
    }
}
