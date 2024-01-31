using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODING
{
    public class Product
    {
        public Product() { }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        public Decimal? CurrentPrice { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Save
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Get data of specific product
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Product getData(int productId)
        {
            //code to get data of product by id
            return new Product();
        }

        /// <summary>
        /// Check product data
        /// </summary>
        /// <returns></returns>
        public bool validate()
        {
            var valid = true;

            if (string.IsNullOrEmpty(ProductName))
            {
                valid = false;
            }

            return valid;
        }
    }
}
