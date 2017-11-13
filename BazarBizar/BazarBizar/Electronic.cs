using System;

namespace BazarBizar
{
    public class Electronic : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Key { get; }

        public Booth Booth { get; }

        public Electronic(Booth booth, string name, int price)
        {
            Booth = booth;
            Key = GenerateKey();
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
