using System;
using System.Collections.Generic;

namespace BazarBizar
{
    public class Customer
    {

        public string CustomerId { get; }
        public string CustomerName { get; set; }

        private readonly HashSet<string> _shoppingCart;

        public Customer(string customerId)
        {
            _shoppingCart = new HashSet<string>();
            CustomerId = customerId;
        }

        public void AddToCart(string productKey) => _shoppingCart.Add(productKey);

        public void RemoveFromCart(string productKey) => _shoppingCart.Remove(productKey);

        public void checkout()
        {
            //booth.checkout();
        }
    }
}
