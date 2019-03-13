using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersección
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 3, 6, 9, 12, 15, 18 };
            int[] B = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            int[] interseccion = new int[31];
            int espacio = 0;


            Console.WriteLine("La intersección de los conjuntos");

            for (int i = 0; i < B.Length; i += 1)
            {
                for (int j = 0; j < A.Length; j += 1)
                {


                    if (B[i] == A[j])
                    {



                        interseccion[espacio] = B[i];
                        Console.Write(interseccion[espacio] + ", ");
                        espacio += 1;

                    }


                }

            }

        }

    }
}

