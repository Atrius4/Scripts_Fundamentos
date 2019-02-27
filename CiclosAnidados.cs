using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, jugadores = 0, loseCon = 0, turnos = 1;

            Console.Write("Ingrese el número de jugadores: ");
            jugadores = int.Parse(Console.ReadLine());

            while (turnos < jugadores)
            {
                Console.WriteLine("Empieza jugador " + turnos);
                while (true)
                {
                    dado = aleatorio.Next(1, 7);
                    if (dado == 1)
                    {
                        loseCon++;
                        Console.WriteLine("Llevas " + loseCon + "turnos que has sacado 1");
                    }
                    else
                    {
                        loseCon = 0;
                    }
                    if (loseCon == 3)
                    {
                        Console.WriteLine("Has sido eliminado no puedes continuar");
                        break;
                    }

                    total += dado;

                    if (total >= 100)
                    {
                        Console.WriteLine("Has Sacado un: " + dado);
                        Console.WriteLine("felicidades has ganado con " + total + "puntos");
                        break;
                    }
                    Console.WriteLine("Has Sacado un: " + dado);
                    Console.WriteLine("Tus puntos son: " + total);
                    Console.Write("Deseas continuar? s/n ");
                    if (Console.ReadLine() != "s")
                    {
                        break;
                    }

                }
                if (total >= 100)
                {
                    Console.WriteLine("El jugador :" + turnos + "Ha ganado, FIN DEL JUEGO");
                    break;
                }
                turnos++;
                total = 0;
            }

        }
    }
}
