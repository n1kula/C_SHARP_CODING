using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CODING
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public int Quantity { get; set; }

        public int ProductId {  get; set; }

        public Decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Save
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Get data of specific order item
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem getData(int orderItemId)
        {
            //code to get data of order by id
            return new OrderItem();
        }

        public bool validate()
        {
            var valid = true;

            if (Quantity <= 0) valid = false;
            if (ProductId <= 0) valid = false;
            if (PurchasePrice == null) valid = false;
            return valid;
        }
    }

}
