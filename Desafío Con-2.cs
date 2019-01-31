using System;

namespace Desafío_Con_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario en COP");

            double sm = double.Parse(Console.ReadLine()) / 828116;

            if (sm < 2)
            {
                Console.WriteLine("Según su salario su tarifa es la A: $3200 mensuales");
            }
            else if (sm < 5)
            {
                Console.WriteLine("Según su salario su tarifa es la B: $12700 mensuales");
            }
            else
            {
                Console.WriteLine("Según su salario su tarifa es la C: $33500");
            }
        }
    }
}
