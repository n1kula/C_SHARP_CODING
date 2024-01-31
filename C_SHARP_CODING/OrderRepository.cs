using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODING
{
    public class OrderRepository
    {
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
            //temp
            Order order = new Order(orderId);

            if (orderId == 3) {
                order.OrderDate = new DateTimeOffset(2024, 1, 31, 10, 00,00, new TimeSpan(7,0,0));
               
            }
            //code to get data of order by id
            return order;
        }
    }
}
