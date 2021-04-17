namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve a single product by Id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Create instance of the Product class
            // Pass in the requested Id
            Product product = new Product(productId);

            // Code that retrieves the defined product

            // Temporary hard-coded values to return
            // a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of Bright Yellow mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            // code that saves the passed in product
            // assume that the saving is pass because focusing on OOP - not database access


            return true;
        }
    }
}
