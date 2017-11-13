using System;

namespace BazarBizar
{
    public class Clothing : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Key { get; }

        public Booth Booth { get; }

        public Clothing(Booth booth, string name, int price)
        {
            Booth = booth;
            Key = GenerateKey();
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
