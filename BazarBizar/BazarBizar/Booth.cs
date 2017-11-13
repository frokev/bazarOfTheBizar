using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarBizar
{
    public class Booth
    {
        public Dictionary<string, IProduct> Stock { get; }

        public Booth() {
            Stock = new Dictionary<string, IProduct>();
        }

        public void AddToStock(IProduct product)
        {
            Stock.Add(product.Key, product);
        }

        public void RemoveFromStock(string key) => Stock.Remove(key);
    }
}
