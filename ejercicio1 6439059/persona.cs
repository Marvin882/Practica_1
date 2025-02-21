using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_6439059
{
    internal class persona
    {
        public persona(string ojos, string altura, string sexo, string peso) {
            this.ojos = ojos;
            this.altura = altura;
            this.sexo = sexo;
            this.peso = peso;
        }
        public string ojos;
        public string altura;
        public string sexo;
        public string peso;

        public void Hablar(string texto)
        {
            Console.WriteLine("voy a decir :" + texto);
        }
        public void Comer(double calorias)
        {
            Console.WriteLine("ganando " + calorias + " calorias");
            this.peso += calorias / 1000;
        }
        public void correr(double calorias)
        {
            Console.WriteLine("Perdiendo " + calorias + " calorias");
            this.peso = Convert.ToString(calorias / 1000);

        }
        
    }   
    
}
