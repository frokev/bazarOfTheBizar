using System;
namespace BazarBizar
{
    public class Consumable : Product
    {
        public Consumable()
        {
        }

        public int Name { get; set; }
        public int Price { get; set; }
        public int Key { get; set; }
    }
}
