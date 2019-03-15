using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacion_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su texto");
            string frase  = Console.ReadLine();
            frase = frase.ToUpper();
            Console.WriteLine("Que palabra desea buscar?");
            string palabra = Console.ReadLine();
            palabra = palabra.ToUpper();
            int counter = 0;
            int[] posición = new int[frase.Length];
            int guardado = 0;
            int repeticiones = 0;

            for (int i = 0; i < frase.Length - (palabra.Length -1); i++)
            {
                char letraInicial = palabra[0];
                if (letraInicial == frase[i])
                {
                    for (int y = 0; y < palabra.Length; y++)
                    {
                        if(palabra[y] == frase[i + y] && (i+y)<frase.Length)
                        {
                            counter++;
                        }
                    }
                }
                if (counter == palabra.Length)
                {
                    posición[guardado] = i;
                    guardado++;
                    repeticiones++;
                }
                counter = 0;
            }
            Console.WriteLine("Su texto: " + frase);
            Console.WriteLine("Palabra a buscar: " + palabra);
            Console.WriteLine("La palabra se repite " + repeticiones + " Veces en las posiciones: ");
            for (int i = 0; i < guardado; i++)
            {
                Console.Write(posición[i] + ", ");
            }
        }
    }
}
