using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los coheficientes de las variables(a,b,c)");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double dis = (b * b) - (4 * a * c);

            if (dis == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("La variable x es igual a: " + x);
            }
            else if (dis > 0)
            {
                double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                double x2 = (-b - Math.Sqrt(dis)) / (2 * a);
                Console.WriteLine("Las posibles soluciones son:" + x1, "ó" + x2);
            }
            else if (dis < 0)
            {
                Console.WriteLine("No es posible calcular la solución");
            }
        }
    }
}
