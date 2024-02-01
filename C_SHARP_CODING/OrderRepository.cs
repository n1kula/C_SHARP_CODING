using System;
using System.Collections.Generic;

namespace C_SHARP_CODING
{
    public class OrderRepository
    {
        /// <summary>
        /// Save
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            var succsess = true;
            if (order.HasChanges && order.DataIsCorrect)
            {
                if (order.IsNew)
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

        /// <summary>
        /// Get one order to show
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public ShowOrder getOrderToShow(int orderId)
        {
            ShowOrder showOrder = new ShowOrder();

            //temp data

            if (orderId == 10)
            {
                showOrder.FirstName = "Tomasz";
                showOrder.LastName = "Nowak";
                showOrder.OrderDate = new DateTimeOffset(2024, 1, 31, 10, 00, 00, new TimeSpan(7, 0, 0));
                showOrder.DeliveryAddress = new Address()
                {
                    AddressType = 1,
                    Street = "Testowa",
                    City = "Testowe",
                    PostalCode = "00-000",
                    Country = "Polska"
                };
            }
            showOrder.ShowOrderItems = new List<ShowOrderItems>();
            
            if (orderId == 10)
            {
                var showOrderItems = new ShowOrderItems()
                {
                    Productname = "Test",
                    quantity = 1,
                    Price = 100,
                };
                showOrder.ShowOrderItems.Add(showOrderItems);

                showOrderItems = new ShowOrderItems()
                {
                    Productname = "Test 2",
                    quantity = 2,
                    Price = 50,
                };
                showOrder.ShowOrderItems.Add(showOrderItems);
            }
            return showOrder;
        }
    }
}
