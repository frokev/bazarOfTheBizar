using System;
namespace BazarBizar
{
    public static class ProductFactory
    {
        public enum Category
        {
            Consumable,
            Electronic,
            Clothing

        }

        public static Product GetProduct(Booth booth, Category category, string name, int price)
        {
            switch (category)
            {
                case Category.Consumable:
                    return new Consumable(booth, name, price);
                case Category.Electronic:
                    return new Electronic(booth, name, price);
                case Category.Clothing:
                    return new Clothing(booth, name, price);
                default:
                    return null;
            }
        }

    }
}