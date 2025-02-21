using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._1_6439059
{
    internal class Frenar
    {
        public void frenar(int decelerar)
        {
            decelerar -= 5;
            Console.WriteLine("Voy a decelerar y frenaré "+ decelerar);
        }
    }
}
