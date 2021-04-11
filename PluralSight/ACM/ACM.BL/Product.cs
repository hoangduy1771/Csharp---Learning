namespace ACM.BL
{
    class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }


        /// <summary>
        /// Retrieve one product 
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {


            return new Product();
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return true;
        }
    }
}
