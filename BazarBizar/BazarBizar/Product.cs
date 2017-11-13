using System;
namespace BazarBizar
{
    

    public interface Product
    {
        string Name { get; set; }
        int Price { get; set; }
        string Key { get; }

        Booth Booth { get; }
    }
}
