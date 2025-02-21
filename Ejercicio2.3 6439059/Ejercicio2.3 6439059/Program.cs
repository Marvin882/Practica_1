using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._3_6439059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Características Personal = new Características("DELL", "INTEL core 5", "130 GB", "SSD");
            Console.WriteLine("descripcion de las caracteristicas del ordenador");
            Console.WriteLine("La marca es: " + Personal.marca);
            Console.WriteLine("El procesador es " + Personal.procesador);
            Console.WriteLine("La memoria es de " + Personal.memoria);
            Console.WriteLine("el disco duro es de " + Personal.discoDuro);

            Personal.mayorCapacidad("");
            Personal.MenorCapacidad("");
            Console.ReadKey();
            
        }
    }
}
