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
            Persona Persona1 = new Persona("Alejandro", 40000, "M", 70, 165);
            string nombre = Persona1.Nombre;
            int sueldo = Persona1.Sueldo;
            string sexo = Persona1.Sexo;
            int peso = Persona1.Peso;
            int altura = Persona1.Altura;
            //string mail = CrearMail();
            string mail = Persona1.Mail;
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public string Mail { get; set; }
            public int Sueldo { get; set; }
            public string Sexo { get; set; }
            public int Peso { get; set; }
            public int Altura { get; set; }

            public Persona (string _nombre, int _sueldo, string _sexo, int _peso, int _altura)
            {
                Nombre = _nombre;
                Sueldo = _sueldo;
                Sexo = _sexo;
                Peso = _peso;
                Altura = _altura;
                //Mail = _nombre + "@ejercito.mil.ar";
                private string CrearMail()
                {
                    Mail = _nombre + "@ejercito.mil.ar";
                    return Mail;
                }
                Mail = CrearMail();
            }


        }
    }
}
