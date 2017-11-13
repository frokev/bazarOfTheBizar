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

    }
}
