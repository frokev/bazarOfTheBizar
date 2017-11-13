using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarBizar
{
    class Program
    {
        const int limit = 50;

        Booth[] Booths = new Booth[limit];
        Customer[] Customers = new Customer[limit];

        static void Main(string[] args)
        {
            Program bazar = new Program();

            for (int i = 0; i < limit; i++)
            {
                bazar.Booths[i] = new Customer()
            }
        }
    }
}
