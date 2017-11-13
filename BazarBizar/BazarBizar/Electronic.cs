using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarBizar
{
    class Electronic : Product
    {
=======
namespace BazarBizar
{
    public class Electronics : Product
    {
        public Electronics()
        {
        }

        public int Name { get; set; }
        public int Price { get; set; }
        public int Key { get; set; }
        public int Amount { get; set; }
>>>>>>> da79ba60f61066d897e9e95568874a825f7844e9
    }
}
