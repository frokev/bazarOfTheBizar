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
        public Dictionary<string, Product> Stock { get; set; }

        public Booth() {
            Stock = new Dictionary<string, Product>();
        }

        public void AddToStock(Product product)
        {
            Stock.Add(product.Key, product);
        }

        public void RemoveFromStock(string key) => Stock.Remove(key);
    }
}
