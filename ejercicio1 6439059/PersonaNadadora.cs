using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_6439059
{
    internal class PersonaNadadora : persona
    {
        public PersonaNadadora(String ojos, string altura, string sexo, string peso) : base(ojos, altura, sexo, peso)
        {
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando para volver el pesp ideal");
            this.peso = "85";
        }
    }
}