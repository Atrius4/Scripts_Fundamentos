using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validación
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int x = 11;

            int a = aleatorio.Next(1, x), b = aleatorio.Next(1, x);
            int sumaCorrecta = a + b;
            int respuesta = 0, oportunidades = 0;

            Console.WriteLine("Porfavor ingrese el resultado de la siguiente suma: " + a + " + " + b);
            respuesta = int.Parse(Console.ReadLine());
            while (respuesta != sumaCorrecta)
            {
                oportunidades += 1;
                if (oportunidades == 3)
                {
                    Console.WriteLine("Te has equivocado demasiadas veces, Activando alarma");
                    break;
                }
                Console.WriteLine("Esa no es la respuesta Correcta");
                a = aleatorio.Next(1, 11);
                b = aleatorio.Next(1, 11);
                sumaCorrecta = a + b;
                Console.WriteLine("Porfavor ingrese el resultado de la siguiente suma: " + a + " + " + b);
                respuesta = int.Parse(Console.ReadLine());
                
            }
            if (respuesta == sumaCorrecta)
            {
                x += 5;
                Console.WriteLine("Respuesta correcta, Abriendo cerradura");
            }


        }
    }
}
