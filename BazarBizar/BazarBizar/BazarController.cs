using System;
using System.Collections.Generic;
using System.Threading;

namespace BazarBizar
{
    public class BazarController
    {
        private readonly Booth[] _booths;
        public View View { get; }

        private const int Amount = 3;

        public BazarController()
        {
            _booths = new Booth[Amount];
            View = new View();

            makeBooths();

            foreach (var booth in _booths)
                makeProducts(booth);

            //var customer1AddToCart = new Thread(Customer1PurchaseThread);
            //var customer2AddToCart = new Thread(Customer2PurchaseThread);

            //customer1AddToCart.Start();
            //customer2AddToCart.Start();
            runThreads();
        }

        private Customer[] GetCustomers()
        {
            var customers = new Customer[2];
            customers[0] = new Customer("Siv Jensen");
            customers[1] = new Customer("Jens Stoltenberg");
            return customers;
        }

        private void runThreads()
        {
            var customers = GetCustomers();
            foreach (var customer in customers)
                new Thread(() =>
                {
                    var products = new HashSet<IProduct>();
                    foreach (var item in _booths[0].Stock)
                        products.Add(item.Value);
                    Buy(customer, products);
                }).Start();
        }


        private void Buy(Customer customer, HashSet<IProduct> products)
        {
            foreach (var product in products)
                lock (product)
                {
                    customer.AddToCart(_booths[0], product.Key);
                }
        }

        /*
        private void Customer1PurchaseThread()
        {
            var customer = new Customer("Siv Jensen");
            var products = new HashSet<IProduct>();

            foreach (var item in _booths[0].Stock)
                products.Add(item.Value);

            var product1 = products.ElementAt(0);

            lock (product1)
            {
                customer.AddToCart(_booths[0], product1.Key);
            }

            var product2 = products.ElementAt(1);

            lock (product2)
            {
                customer.AddToCart(_booths[0], product2.Key);
            }
        }

        private void Customer2PurchaseThread()
        {
            var customer = new Customer("Jens Stoltenberg");
            var products = new HashSet<IProduct>();

            foreach (var item in _booths[0].Stock)
                products.Add(item.Value);

            var product1 = products.ElementAt(0);

            lock (product1)
            {
                customer.AddToCart(_booths[0], product1.Key);
            }

            var product2 = products.ElementAt(1);

            lock (product2)
            {
                customer.AddToCart(_booths[0], product2.Key);
            }
        }
        */

        private void makeBooths()
        {
            for (var i = 0; i < Amount; i++)
            {
                var boothName = GenerateUid();
                _booths[i] = new Booth(boothName);
            }
        }

        private IProduct[] makeProducts(Booth booth)
        {
            var itemKey1 = booth.AddToStock(
                ProductFactory.GetProduct(
                    booth,
                    ProductFactory.Category.Clothing,
                    "Sweather",
                    500
                )
            );

            IProduct item1;
            booth.Stock.TryGetValue(itemKey1, out item1);

            var itemKey2 = booth.AddToStock(
                ProductFactory.GetProduct(
                    booth,
                    ProductFactory.Category.Electronic,
                    "Mac PC",
                    1200
                )
            );

            IProduct item2;
            booth.Stock.TryGetValue(itemKey2, out item2);

            return new[] {item1, item2};
        }

        //Helper method for generating a unique Id.
        public static string GenerateUid()
        {
            var g = Guid.NewGuid();
            var uid = Convert.ToBase64String(g.ToByteArray());
            uid = uid.Replace("=", "");
            uid = uid.Replace("+", "");
            return uid;
        }
    }
}