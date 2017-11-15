using System;
using System.Collections.Generic;

namespace BazarBizar
{
    public class Customer
    {
        public string CustomerId { get; }

        private readonly HashSet<string> _shoppingCart;

        public Customer(string customerId)
        {
            _shoppingCart = new HashSet<string>();
            CustomerId = customerId;
        }

        public void AddToCart(Booth booth, string productKey)
        {
            if (booth.InCustomerCart.Contains(productKey))
            {

                View.WriteLine(
                        "\t\t\tCustomer " + CustomerId + 
                        " tried to add " + "(" + productKey + ") to cart, but the item does not exist anymore"
                    );

                return;
            }

            _shoppingCart.Add(productKey);
            booth.InCustomerCart.Add(productKey);

            IProduct product;
            booth.Stock.TryGetValue(productKey, out product);

            if (product != null)
                View.WriteLine(
                        "\t\t\tCustomer " + CustomerId + " added " + product.Category + 
                        " product " + "(" + productKey + ")" + " to cart"
                    );
        }

        public void RemoveFromCart(Booth booth, string productKey)
        {
            _shoppingCart.Remove(productKey);
            booth.InCustomerCart.Remove(productKey);
        }
    }
}
