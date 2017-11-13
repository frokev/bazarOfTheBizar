using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarBizar
{
    interface Product
    {
        string Name { get; set; }
        int Price { get; set; }
        string Key { get; set; }
    }
}
