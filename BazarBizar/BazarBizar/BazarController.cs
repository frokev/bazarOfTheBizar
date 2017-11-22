using System;
using System.Collections.Generic;
using System.Threading;

namespace BazarBizar
{
    public class BazarController
    {
        private readonly Booth[] _booths;
        private View View { get; }

        private const int Amount = 10;

        public BazarController()
        {
            _booths = new Booth[Amount];
            View = new View();

            makeBooths();

            foreach (var booth in _booths) { }
                

            for (var i = 0; i < 10; i++)
            {
                if (_booths.Length < i) return;

                var b = _booths[i];
                makeProducts(b);
                runThreads(i);
            }
                
        }

        private Customer[] GetCustomers()
        {
            var customers = new Customer[2];
            customers[0] = new Customer("Siv Jensen");
            customers[1] = new Customer("Jens Stoltenberg");
            return customers;
        }

        private void runThreads(int booth)
        {
            var customers = GetCustomers();
            foreach (var customer in customers)
                new Thread(() =>
                {
                    var products = new HashSet<IProduct>();
                    foreach (var item in _booths[booth].Stock)
                    {
                        products.Add(item.Value);
                    }
                    Buy(customer, products, booth);
                }).Start();
        }


        private void Buy(Customer customer, HashSet<IProduct> products, int booth)
        {
            foreach (var product in products)
                lock (product)
                {
                    customer.AddToCart(_booths[booth], product.Key);
                }
        }

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

            View.WriteLine("Booth: " + booth.Name + " added " + item1.Name + " for sale");

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

            View.WriteLine("Booth: " + booth.Name + " added " + item2.Name + " for sale");

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