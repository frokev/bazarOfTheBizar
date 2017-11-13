using System;
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

        public Product GetProduct(Category category, string name, int price)
        {
            switch (category)
            {
                case Category.Consumable:
                    return new Consumable(name, price);
                    break;
                case Category.Electronic:
                    return new Electronic(name, price);
                    break;
                case Category.Clothing:
                    return new Clothing(name, price);
                    break;

            }
            return null;
        }

    }
}