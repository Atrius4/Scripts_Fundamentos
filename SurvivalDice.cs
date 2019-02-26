using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();        //Variables
            int dado1 = aleatorio.Next(1,7), dado2 = 0;
            int vidas = 3, daño = 0, curas = 0,puntos = 0;

            Console.WriteLine("Vamos a empezar");       //Primer lanzamiento
            Console.WriteLine("Tu primer tiro ha sido: " + dado1);
            puntos += dado1;
            Console.WriteLine("Quieres seguir? s/n");
            string continuar = Console.ReadLine();


            while (continuar == "s" && vidas > 0)       //Comienzo del ciclo
            {
                dado1 = aleatorio.Next(1, 7);
                daño += 1;
                curas += 1;
                puntos += dado1;
                Console.WriteLine("Has tirado un:" + dado1);

                if (curas == 3)
                {
                    Console.WriteLine("Te has Ganado una oportunidad para vivir");
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("Tu segundo dado es: " + dado2);
                    puntos += dado2;
                    if (dado1 == dado2)
                    {
                        vidas += 1;
                        Console.WriteLine("felicidades te ganaste una vida extra, no te quitaré vidas este turno daño este turno");
                        daño = 0;
                    }
                    else
                    {
                        Console.WriteLine("Es una lastima, pero no sacaste par");
                    }
                    dado2 = 0;
                    curas = 0;
                }
                if (daño == 2)
                {
                    Console.WriteLine("Ya han pasado dos turnos! Así que voy a tomar una de tus vidas");
                    vidas -= 1;
                    Console.WriteLine("Tus vidas:" + vidas);
                    daño = 0;

                }
                if (vidas == 0)
                {
                    Console.WriteLine("Lo siento, no te quedan mas vidas. HAS PERDIDO");
                    Console.WriteLine("Has terminado con: " + puntos + " puntos");
                    break;
                }
               

                Console.WriteLine("Tus puntos son: " + puntos);
                Console.WriteLine("Deseas Continuar? s/n");
                continuar = Console.ReadLine();
                

            }

        }
    }
}
