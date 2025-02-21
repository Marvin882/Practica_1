using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._1_6439059
{
    internal class auto
    {
     
     
        public string marca;
        public string modelo;
        public int velocidadActual;
        public int velocidadMAX;

        public void acelerar (int acelerar)
        {
            acelerar += 5;
            Console.WriteLine("Acelerare en " + acelerar);
        }
            public void decelerar (int acelerar)
        { 
            acelerar -= 5;
            Console.WriteLine("Deceleraré " + acelerar);
        }
       } 
    }

