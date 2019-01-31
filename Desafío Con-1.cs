using System;

namespace Desafio_Con_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Igrese su salario en COP");

                double salario = double.Parse(Console.ReadLine());
                double SM = salario/ 828116;

            if (SM < 2)
            {
                Console.WriteLine("Su Tarifa es la Tarifa A");
            }
            else if (SM < 4)
            {
                Console.WriteLine("Su Tarifa es la Tarifa B");
            }
            else
            {
                Console.WriteLine("Su Tarifa es la Tarifa C");
            }


        }
    }
}
