﻿
using Store.Domain.Contracts;

namespace Store.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, int quantity)
        {           
            Product = product;
            Price = Product != null ? Product.Price : 0;
            Quantity = quantity;

            AddNotifications(new ProductContract(product, quantity));
        }

        public Product Product { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public decimal Total()
        {
            return Price * Quantity;
        }
    }
}
