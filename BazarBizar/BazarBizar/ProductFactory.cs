using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarBizar
{
    class ProductFactory
    {
        public enum Category { Consumable, Clothing, Electronic }

        public Product GetProduct(Category cat, string name, int price)
        {
            switch(cat)
            {
                case Category.Consumable:
                    return new Consumable(name, price);
                case Category.Clothing:
                    return new Clothing(name, price);
                case Category.Electronic:
                    return new Electronic(name, price);
                default:
                    return null;
            }

        }
    }
}
