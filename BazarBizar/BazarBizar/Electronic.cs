using System;

namespace BazarBizar
{
    public class Electronic : Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Key { get; set; }

        public Electronic(string name, int price)
        {
        }
    }
}
