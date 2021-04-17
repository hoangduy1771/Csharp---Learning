using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve a single order by Id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Create instance of the order class
            // Pass in the requested Id
            Order order = new Order(orderId);

            // Code that retrieves the defined order

            // Temporary hard-coded values to return
            // a populated order
            if (orderId == 10)
            {
                // use current year in hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));

            }

            return order;
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            // code that saves the passed in order
            // assume that the saving is pass because focusing on OOP - not database access


            return true;
        }
    }
}
