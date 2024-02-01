using System;
using Common;

namespace C_SHARP_CODING
{
    public class Product : BaseClass
    {
        public Product() { }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; private set; }
        private string _ProductName;

        public string ProductName
        {
            get
            {
                return StringSupport.AddSpace(_ProductName);
            }
            set
            {
                _ProductName = value;
            }
        }

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
        public override bool validate()
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
