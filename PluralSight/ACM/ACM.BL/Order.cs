﻿using System;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }


        /// <summary>
        /// Retrieve one order 
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {


            return new Order();
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return true;
        }


    }
}
