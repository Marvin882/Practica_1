using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_6439059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona Personal = new persona("verdes", "1.87", "85", "V");
            Console.WriteLine("Descripcion de la persona");
            Console.WriteLine("Ojos" + Personal.ojos);
            Console.WriteLine("Altura " + Personal.altura);
            Console.WriteLine("sexo " + Personal.peso);
            Console.WriteLine("peso " + Personal.sexo);

            Personal.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos: " + Personal.ojos);
            Personal.correr(1000);
            Console.WriteLine("Mi peso actual es " + Personal.peso);
            Console.ReadKey();
        
       
        }
    }
}
