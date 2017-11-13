using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarBizar
{
    class Booth
    {
        private Dictionary<string, Product> Stock = new Dictionary<string, Product>();

        public Booth() { }

        public void AddToStock(Product product)
        {
            Stock.Add(product.Key, product);
        }

        public void removeFromStock(string key)
        {
            Stock.Remove(key);
        }
    }
}
