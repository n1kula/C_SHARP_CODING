namespace C_SHARP_CODING
{
    public class ProductRepository
    {
        /// <summary>
        /// Save
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var succsess = true;
            if (product.HasChanges && product.DataIsCorrect)
            {
                if (product.IsNew)
                {
                    //insert
                }
                else
                {
                    //update
                }
            }
            return succsess;
        }

        /// <summary>
        /// Get data of specific product
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Product getData(int productId)
        {
            Product product = new Product(productId);
            //code to get data of product by id

            //temp
            if (productId == 2) {
                product.ProductName = "Milk";
                product.Description = "Laciate 3,2%";
                product.CurrentPrice = 5;
            }
            return product;
        }
    }
}
