using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "X", "O" };
            int n = 10;
            int m = 15;

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");
            }

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1) - 2; j++)
                {
                    int indice = j;
                    if (tablero[i, j] == "X" || tablero[i, j] == "O")
                    {
                        if (tablero[i, j] == tablero[i, j + 1] && tablero[i, j + 1] == tablero[i, j + 2])
                        {
                            while (j + 1 < salida.GetLength(1) && tablero[i, j] == tablero[i, j + 1])
                            {
                                if (tablero[i, j] == "X")
                                {
                                    salida[i, j] = "1";
                                    salida[i, j + 1] = "1";
                                }
                                if (tablero[i, j] == "O")
                                {
                                    salida[i, j] = "2";
                                    salida[i, j + 1] = "2";
                                }
                                j++;
                            }
                            j = indice;
                        }
                    }
                }
            }
                for (int i = 0; i < tablero.GetLength(0)-2; i++)
                {
                    for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        int indice = i;
                        if (tablero[i, j] == "X" || tablero[i, j] == "O")
                        {
                            if (tablero[i, j] == tablero[i+1, j] && tablero[i+1, j] == tablero[i+2, j])
                            {
                                while (i + 1 < salida.GetLength(0) && tablero[i, j] == tablero[i+1, j])
                                {
                                    if (tablero[i, j] == "X")
                                    {
                                        salida[i, j] = "1";
                                        salida[i+1,j] = "1";
                                    }
                                    if (tablero[i, j] == "O")
                                    {
                                        salida[i, j] = "2";
                                        salida[i+1, j] = "2";
                                    }
                                    i++;
                                }
                                i = indice;
                            }
                        }
                    }
                }
                Console.Write("\n");
            for (int i = 0; i < salida.GetLength(0); i++)
            {
                for (int j = 0; j < salida.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
            
        }
    }
}
