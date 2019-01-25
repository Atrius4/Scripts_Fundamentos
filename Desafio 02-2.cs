using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos t, a:");

            double t = double.Parse(Console.ReadLine());
            double aGrados = double.Parse(Console.ReadLine());
            double a = (aGrados * Math.PI) / 180;

            double y = (t * Math.Sin(a));
            double z = (t * Math.Cos(a));
            double c = (180 - 90 - aGrados);

            Console.WriteLine("y es igual a:" + y);
            Console.WriteLine("z es igual a:" + z);
            Console.WriteLine("c es igual a:" + c);
        }
    }
}
