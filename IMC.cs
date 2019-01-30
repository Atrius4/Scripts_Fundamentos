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
            Console.WriteLine("Inrese su estatura en metros y su peso en Kilogramos");

            double h = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double IMC = p / (h * h);

            if (IMC < 18.5)
            {
                Console.WriteLine("Usted Tiene peso inferior al normal");
            }
            else if (IMC > 30)
            {
                Console.WriteLine("Usted Tiene Obesidad");
            }
            else if (IMC > 25)
            {
                Console.WriteLine("Usted tiene Sobrepeso");
            }
            else
            {
                Console.WriteLine("Su peso es adecuado");
            }
        }
    }
}
