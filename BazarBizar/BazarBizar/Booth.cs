using System.Collections.Generic;

namespace BazarBizar
{
    public class Booth
    {
        public string Name { get; }
        public Dictionary<string, IProduct> Stock { get; }
        public HashSet<string> InCustomerCart { get; }

        public Booth(string name)
        {
            Name = name;
            InCustomerCart = new HashSet<string>();
            Stock = new Dictionary<string, IProduct>();
        }

        public string AddToStock(IProduct product)
        {
            Stock.Add(product.Key, product);
            return product.Key;
        }

        public void RemoveFromStock(string key) => Stock.Remove(key);
    }
}
