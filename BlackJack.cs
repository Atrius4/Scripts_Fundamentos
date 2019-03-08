using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, cartaRobada = 0;
            int total = 0;
            Console.WriteLine("ingrese el número de jugadores:");
            int n = int.Parse(Console.ReadLine());
            string[] jugadores = new string[n];
            int[] puntajes = new int[n];
            string Robar = "";

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el nombre del jugador " + (i+1));
                jugadores[i] = Console.ReadLine();
                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("Tu primera carta: " + carta1);
                Console.WriteLine("Tu segunda carta: " + carta2);
                total = carta1 + carta2;
                Console.WriteLine("Tus puntos: " + total);
                Console.WriteLine("Desea Robar mas cartas? s/n");
                Robar = Console.ReadLine();
                while (Robar == "s" && total < 21)
                {
                    cartaRobada = aleatorio.Next(1, 11);
                    total = total + cartaRobada;
                    if (total >= 22)
                    {
                        Console.WriteLine("You Lose! La suerte no está de tu lado");
                        Console.WriteLine("Has robado un " + cartaRobada + " Pero te pasaste de 21");
                        Console.WriteLine("perdiste con " + carta1 + " " + carta2 + " " + cartaRobada + " para un total de " + total);
                        total = 0;
                        break;
                    }
                    else if (total == 21)
                    {
                        Console.WriteLine("Congratulations, Has robado un " + cartaRobada + " Para un limpio BlackJack");
                        Console.WriteLine("Has Ganado con " + carta1 + " " + carta2 + " " + cartaRobada);
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Acabas de robar un " + cartaRobada);
                        Console.WriteLine("posees: " + carta1 + " " + carta2 + " " + cartaRobada + " para un total de " + total);
                        Console.WriteLine("Deseas Robar mas cartas?");
                        Robar = Console.ReadLine();
                    }
                }
                puntajes[i] = total;
                Console.WriteLine("Tu puntaje fue de: " + total);


            }

            for (int i = 0; i < n-1; i++)
            {
                for (int y = 0; y < n-1; y++)
                {
                    if (puntajes[y] < puntajes[y + 1])
                    {
                        int tmp = puntajes[y + 1];
                        puntajes[y+1] = puntajes[y];
                        puntajes[y] = tmp;

                        string tmp2 = jugadores[y + 1];
                        jugadores[y + 1] = jugadores[y];
                        jugadores[y] = jugadores[y + 1];
                    }
                }
            }

            Console.WriteLine("Tabla de Posiciones: ");
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Jugador " + jugadores[i] + " Con " + puntajes[i] + " Puntos ");
            }
            Console.WriteLine("El Ganador es el jugador " + jugadores[0] + " Con " + puntajes[0] + " Puntos");



            Console.ReadLine();


        }
    }
}
