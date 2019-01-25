using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos z, c:");

            double z = double.Parse(Console.ReadLine());
            double cGrados = double.Parse(Console.ReadLine());
            double c = (cGrados * Math.PI) / 180;

            double t = (z / Math.Sin(c));
            double y = (t * Math.Cos(c));
            double a = (180 - 90 - cGrados);

            Console.WriteLine("t es igual a:" + t);
            Console.WriteLine("y es igual a:" + y);
            Console.WriteLine("a es igual a:" + a);
        }
    }
}
