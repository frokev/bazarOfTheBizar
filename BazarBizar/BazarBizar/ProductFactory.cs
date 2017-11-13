using System;
<<<<<<< HEAD
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
=======
namespace BazarBizar
{
    public class ProductFactory
    {
        public enum Category
        {
            Consumable,
            Electronic,
            Clothing

        }

        public ProductFactory()

        {

        }

        public Product GetProduct(Category category)
        {
            switch (category)
            {
                case Category.Consumable:
                    return new Consumable();
                    break;
                case Category.Electronic:
                    return new Electronic();
                    break;
                case Category.Clothing:
                    return new Clothing();
                    break;

            }
            return null;
        }

>>>>>>> da79ba60f61066d897e9e95568874a825f7844e9
    }
}
