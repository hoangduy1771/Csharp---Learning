﻿namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Retrieve one order item.
        /// </summary>
        /// <param name="orderItemID"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemID)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Saves current order item
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves order item

            return true;
        }


        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

    }
}
