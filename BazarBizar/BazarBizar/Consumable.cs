using System;

namespace BazarBizar
{
    public class Consumable : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Key { get; }

        public Booth Booth { get; }

        public Consumable(Booth booth, string name, int price)
        {
            this.Booth = booth;
            Key = GenerateKey();
            Name = name;
            Price = price;
        }

        private string GenerateKey()
        {
            Guid g = Guid.NewGuid();
            string key = Convert.ToBase64String(g.ToByteArray());
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
