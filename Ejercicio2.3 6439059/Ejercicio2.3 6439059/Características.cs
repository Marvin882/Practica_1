using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._3_6439059
{
    internal class Características
    {
         
        public Características(string marca, string procesador, string memoria, string discoDuro )
        {
            this.marca = marca;
            this.procesador = procesador;
            this.memoria = memoria;
            this.discoDuro = discoDuro;
        }
        public string marca;
        public string procesador;
        public string memoria;
        public string discoDuro;

        public void mayorCapacidad(string MAYORcapacidad)
        {
            Console.WriteLine("la capacidad aumentará de 100GB a 1000GB");
        }
        public void MenorCapacidad(string MENORcapacidad)
        {
            Console.WriteLine("La capacidad se reduce a 100GB");
        }

    }
}
