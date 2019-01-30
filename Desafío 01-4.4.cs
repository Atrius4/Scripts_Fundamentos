using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_01_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa las variables w,t,c:");
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double cGrados = double.Parse(Console.ReadLine());

            double eGrados = 180 - cGrados;
            double e = eGrados * (Math.PI / 180);
            double d = Math.Asin((t * Math.Sin(e)) / w);
            double dGrados = d * (180 / Math.PI);

            double bGrados = 180 - dGrados - eGrados;
            double b = bGrados * (Math.PI / 180);
            double x = (w * Math.Sin(b)) / Math.Sin(e);

            Console.WriteLine("El valor de x es:" + x);
        }
    }
}
