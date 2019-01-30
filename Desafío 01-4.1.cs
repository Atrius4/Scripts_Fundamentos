using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_01___4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los valores de las variables b,z,y:");
             double bGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double a = Math.Atan(y / z);

            double x = (z * Math.Atan(a + ((bGrados * Math.PI) / 180)) - y);
            Console.WriteLine("El valor de x es: " + x); 

        }
    }
}
