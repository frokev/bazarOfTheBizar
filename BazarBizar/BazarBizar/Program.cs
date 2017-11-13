using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarBizar
{
    internal class Program
    {
        private const int Limit = 50;

        private readonly Booth[] _booths = new Booth[Limit];
        private readonly Customer[] _customers = new Customer[Limit];

        private static void Main(string[] args)
        {
            var bazar = new Program();

            for (var i = 0; i < Limit; i++)
            {
                var uid = Guid.NewGuid().ToString();
                bazar._customers[i] = new Customer(uid);

                bazar._booths[i] = new Booth();
            }
        }
    }
}
