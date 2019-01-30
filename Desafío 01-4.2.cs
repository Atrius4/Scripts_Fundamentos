using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_01_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los valores de las variables d,b,y:");

            double dGrados = double.Parse(Console.ReadLine());
            double bGrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double eGrados = (180 - bGrados - dGrados);
            double cGrados = (180 - eGrados);
            double c = ((cGrados * Math.PI) / 180);
            double z = y * Math.Tan(c);

            Console.WriteLine("El valor de Z es: " + z);
        }
    }
}
