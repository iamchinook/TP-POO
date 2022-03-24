using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPOO
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese su nombre: ");
            string _nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su sueldo: ");
            string _sueldo = Console.ReadLine();

            Console.WriteLine("Ingrese su sexo: ");
            string _sexo = Console.ReadLine();

            Console.WriteLine("Ingrese su peso: ");
            string _peso = Console.ReadLine();

            Console.WriteLine("Ingrese su altura: ");
            string _altura = Console.ReadLine();

            Persona Persona1 = new Persona(_nombre, _sueldo, _sexo, _peso, _altura);

            Console.Clear();
            Console.WriteLine("Datos del usuario: \n\n- Nombre: " + Persona1.Nombre + "\n- Mail: " + Persona1.Mail +  "\n- Sueldo: " + Persona1.Sueldo + " ARS\n- Sexo: " + Persona1.Sexo + "\n- Peso: " + Persona1.Peso + " Kg.\n- Altura: " + Persona1.Altura + "cm");
            Console.ReadLine();
        }

        public class Persona
        {
            public string Nombre;
            public string Sueldo;
            public string Mail;
            public string Sexo;
            public string Peso;
            public string Altura;

            public Persona(string _nombre, string _sueldo, string _sexo, string _peso, string _altura)
            {
                Nombre = _nombre;
                Sueldo = _sueldo;
                Sexo = _sexo;
                Peso = _peso;
                Altura = _altura;
                Mail = _nombre + "@ejercito.mil.ar";
            }
        }
    }
}
