using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODING
{
    public class Order
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int OrderId { get; private set; }

        public DateTimeOffset? OrderDate { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public int ClientId { get; set; }

        public int DeliveryAddresID { get; set; }

        /// <summary>
        /// Save
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Get data of specific order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order getData(int orderId)
        {
            //code to get data of order by id
            return new Order();
        }

        public bool validate()
        {
            var valid = true;

            if (null == OrderDate) valid = false;
            return valid;
        }
    }
}
