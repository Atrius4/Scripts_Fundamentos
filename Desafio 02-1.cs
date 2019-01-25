using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos Y,Z");

            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());


            double t = (Math.Sqrt((y * y) + (z * z)));
            double aRad = (Math.Asin(y / t));
            double a = (aRad * 180) / Math.PI;
            double c = (180 - 90 - a);

            Console.WriteLine("t es igual a:" + t);
            Console.WriteLine("a es igual a:" + a);
            Console.WriteLine("c es igual a:" + c);
        }
    }
}
