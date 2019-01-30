using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_01_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los valores de las variables w,d,x:");

            double w = double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double d = ((dGrados * Math.PI) / 180);

            double y = ((w * Math.Cos(d)) - x);
            Console.WriteLine("El valor de Y es: " + y);


        }
    }
}
