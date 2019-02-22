using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0;
            int puntos = 0;
            int con = 0;
            int vicon = 0;
            string respuesta = "s";


            dado = aleatorio.Next(1, 13);
            puntos += dado;
            Console.WriteLine("Has Sacado" + dado);
            Console.WriteLine("Tus puntos: " + puntos);
            respuesta = Console.ReadLine();
            if (dado == 10)
            {
                con = con + 1;
            }

            if (respuesta == "s")
            {

                dado = aleatorio.Next(1, 13);
                puntos += dado;
                if (dado == 10)
                {
                    con = con + 1;
                }
                if (dado != 12 && dado != 10)
                {
                    con = 0;
                }
                if (dado == 12 && con >= 1)
                {
                    Console.WriteLine("Has Tirado: " + dado);
                    Console.WriteLine("Tus puntos: " + puntos);

                    Console.WriteLine("Has ganado");
                    vicon = vicon + 2;


                }
                if (vicon < 2)
                {
                    Console.WriteLine("Has tirado " + dado);
                    Console.WriteLine("Puntos: " + puntos);
                    Console.WriteLine("Quiere continuar? ");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s")
                    {

                        dado = aleatorio.Next(1, 13);
                        puntos += dado;
                        if (dado == 10)
                        {
                            con = con + 1;
                        }
                        if (dado != 12 && dado != 10)
                        {
                            con = 0;
                        }
                        if (dado == 12 && con >= 1)
                        {
                            Console.WriteLine("Has ganado");
                            vicon = vicon + 2;
                        }
                        if (vicon < 2)
                        {
                            Console.WriteLine("Has tirado" + dado);
                            Console.WriteLine("Puntos: " + puntos);
                            Console.WriteLine("Quiere continuar? ");
                            respuesta = Console.ReadLine();
                        }
                    }
                }
            }

            dado = 2;

            while (respuesta == "s" && puntos < 100 && dado % 2 == 0 && vicon < 2)
            {

                dado = aleatorio.Next(1, 11);
                Console.WriteLine("Has tirado: " + dado);
                if (dado == 10)
                {
                    con = con + 1;
                }
                if (dado != 12 && dado != 10)
                {
                    con = 0;
                }
                if (dado == 12 && con >= 1)
                {
                    puntos += dado;
                    Console.WriteLine("Has ganado");
                    vicon = vicon + 2;
                }
                if (dado % 2 != 0)
                {
                    puntos += dado;
                    Console.WriteLine("Perdiste");
                }
                if (puntos >= 100)
                {
                    Console.WriteLine("Has ganado ");
                    puntos += dado;
                }
                if (dado % 2 == 0 && vicon < 2)
                {
                    puntos += dado;
                    Console.WriteLine("Tus puntos" + puntos);
                    if (puntos < 100)
                    {
                        Console.WriteLine("Quieres continuar? ");
                        respuesta = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("Se acabo");
            Console.WriteLine("Tus puntos " + puntos);
        }

    }
}
