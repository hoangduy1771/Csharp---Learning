using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            ProductRepository productRepository = new ProductRepository();
            Product expected = new Product(2)
            {
                ProductName = "Sunflowers",
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size Set of Bright Yellow mini Sunflowers",
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(actual.ProductDescription, expected.ProductDescription);
            Assert.AreEqual(actual.ProductName, expected.ProductName);
            Assert.AreEqual(actual.CurrentPrice, expected.CurrentPrice);
        }
    }
}
