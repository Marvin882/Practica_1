using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._1_6439059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            auto auto1 = new auto();
            auto1.acelerar(5);

            Frenar cocheFrenado = new Frenar();
            cocheFrenado.frenar(0);

            auto1.velocidadMAX = 100;
            auto1.modelo = "Tacoma";
            Console.WriteLine("el modelo del auto es: "+ auto1.modelo);
            auto1.marca = "Toyota";
            Console.WriteLine("La marca es :" + auto1.marca);
            auto1.velocidadActual = 150;
            Console.ReadKey();


        }
    }
}
