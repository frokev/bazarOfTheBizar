using System;

namespace BazarBizar
{
    public class Consumable : Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Key { get; set; }

        public Consumable(string name, int price)
        {
        }

    }
}
