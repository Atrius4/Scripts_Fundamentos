using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 0, 3, 6, 6, 6, 9, 12, 12, 12, 15, 18, 18 };
            int[] B = { 0, 0, 2, 2, 4, 6, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };
            int[] U = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

            int[] union = new int[A.Length + B.Length];
            int[] repetido = new int[union.Length];
            int counter = 0;
            bool romper;

            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int y = 0; y < A.Length - 1; y++)
                {
                    if (A[y] > A[y + 1])
                    {
                        int tmp = A[y + 1];
                        A[y + 1] = A[y];
                        A[y] = tmp;

                    }
                }
            }
            for (int i = 0; i < B.Length - 1; i++)
            {
                for (int y = 0; y < B.Length - 1; y++)
                {
                    if (B[y] > B[y + 1])
                    {
                        int tmp = B[y + 1];
                        B[y + 1] = B[y];
                        B[y] = tmp;

                    }
                }
            }
            for (int i = 0; i<A.Length; i++)
            {
                union[i] = A[i];

            }
            for (int i = 0; i<B.Length; i++)
            {
                union[A.Length + i] = B[i];
            }



            Console.WriteLine("La union de ambos conjuntos es: ");

            
                for (int i = 0; i < union.Length; i++)
            {
                if (i + 1 == union.Length) { Console.WriteLine(union[i]); break; }
                if (union[i] != union[i + 1]) { Console.Write(union[i] + ", "); }

            }
        }
    }
}
