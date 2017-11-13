using System;

namespace BazarBizar
{
    public class Clothing : Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Key { get; set; }

        public Clothing(string name, int price)
        {
        }
    }
}
