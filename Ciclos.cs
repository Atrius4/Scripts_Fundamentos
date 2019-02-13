using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "s";
            int contador = 0;
            double total = 0;
            int max = 0;
            int min = 150;
            string nMayor = "";
            string nMenor = "";
            while (respuesta == "s")
            {
                Console.WriteLine("Ingrese Su nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su edad");
                int edad = int.Parse(Console.ReadLine());
                total += edad;
                contador += 1;
                if (edad > max)
                {
                    max = edad;
                    nMayor = nombre;
                }
                if (edad < min)
                {
                    nMenor = nombre;
                    min = edad;
                }
                Console.WriteLine("Desea Ingresar otro dato?");
                respuesta = Console.ReadLine();
            }
            double promedio = (total / contador);
            Console.WriteLine("La edad Promedio es:" + promedio);
            Console.WriteLine("La persona con menor edad es: " + nMenor + "con" + min + "años");
            Console.WriteLine("La persona con mayor edad es: " + nMayor + "con" + max + "años");
        }
    }
}
