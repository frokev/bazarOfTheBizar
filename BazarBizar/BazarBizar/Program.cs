using System;

namespace BazarBizar
{
    class Program
    {

        private static void Main()
        {
            const int limit = 10;

            var booths = new Booth[limit];
            var customers = new Customer[limit];

            for (var i = 0; i < limit-1; i++)
            {
                //Making Customers and Boots
                var customerUid = GenerateUid();
                if (i == 0) customers[i] = new Customer(customerUid);
                customers[i+1] = new Customer(customerUid);

                var boothName = GenerateUid();
                booths[i] = new Booth(boothName);
                //-----------------------------------------------------END

                //Making products and putting them for sale
                var itemKey1 = booths[i].AddToStock(
                    ProductFactory.GetProduct(
                        booths[i],
                        ProductFactory.Category.Clothing,
                        "product",
                        500
                    )
                );

                IProduct item1;
                booths[i].Stock.TryGetValue(itemKey1, out item1);

                if (item1 != null)
                    Console.WriteLine(
                        "Booth " + booths[i].Name + " put " + item1.Category + " item for sale, " +
                                      " product UId: " + item1.Key
                                      );

                var itemKey2 = booths[i].AddToStock(
                    ProductFactory.GetProduct(
                        booths[i],
                        ProductFactory.Category.Electronic,
                        "product",
                        500
                    )
                );

                IProduct item2;
                booths[i].Stock.TryGetValue(itemKey2, out item2);

                if (item2 != null)
                    Console.WriteLine(
                        "Booth " + booths[i].Name + " put " + item2.Category + " item for sale, " +
                                      " product UId: " + item2.Key
                                      );
                //---------------------------------------------END


                //Trying to make a conflict... Two customers trying to add the exact same product to cart
                customers[i].AddToCart(booths[i], itemKey1);
                customers[i+1].AddToCart(booths[i], itemKey1);

                customers[i + 1].AddToCart(booths[i], itemKey2);
                customers[i].AddToCart(booths[i], itemKey2);
                //---------------------------------------------END
            }

            Console.ReadKey(true);
        }

        //Helper method for generating a unique Id.
        private static string GenerateUid()
        {
            var g = Guid.NewGuid();
            var uid = Convert.ToBase64String(g.ToByteArray());
            uid = uid.Replace("=", "");
            uid = uid.Replace("+", "");
            return uid;
        }

    }
}
