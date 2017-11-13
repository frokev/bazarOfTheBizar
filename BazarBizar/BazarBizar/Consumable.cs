using System;

namespace BazarBizar
{
    public class Consumable : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Key { get; }
        public string Category { get; }

        public Booth Booth { get; }

        public Consumable(Booth booth, string name, int price)
        {
            Booth = booth;
            Key = GenerateKey();
            Name = name;
            Price = price;
            Category = "Consumable";
        }

        private string GenerateKey()
        {
            var g = Guid.NewGuid();
            var key = Convert.ToBase64String(g.ToByteArray());
            key = key.Replace("=", "");
            key = key.Replace("+", "");

            while (Booth.Stock.ContainsKey(key))
            {
                key = GenerateKey();
            }

            return key;
        }

    }
}
