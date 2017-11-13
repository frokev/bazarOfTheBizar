using System;
using System.Collections.Generic;

namespace BazarBizar
{
    class Customer
    {
        public string CustomerID { get; private set; }
        public String CustomerName { get; set; }
        public HashSet<string> ShoppingCart { get; private set; }

        public Customer(string customerID)
        {
            ShoppingCart = new HashSet<string>();
        }

        public void AddToCart(string productKey)
        {
            ShoppingCart.Add(productKey);
        }

        public void RemoveFromCart(string productKey)
        {
            ShoppingCart.Remove(productKey);
        }

        public void checkout()
        {
            //booth.checkout();
        }
    }
}
