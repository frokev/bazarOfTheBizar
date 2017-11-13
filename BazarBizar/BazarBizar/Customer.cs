using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarBizar
{
    class Customer
    {
        private int customerID;
        private String customerName;
        private String[] shoppingCart;
        private Booth booth;

        public Customer(int customerID, String customerName , Booth booth)
        {
            //Create Customer
            this.customerName = customerName;
            shoppingCart = new String[10];
            this.booth = booth;
        }

        public int GetCustomerID()
        {
            return customerID;
        }

        public String GetCustomerName()
        {
            return customerName;
        }

        public String[] getShoppingCartItems()
        {
            return shoppingCart;
        }

        public void addToCart(string productKey, int listingKey)
        {
            //Må fylles inn
        }

        public void checkout()
        {
            //booth.checkout();
        }
    }
}
