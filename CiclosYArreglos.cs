using System;

namespace CiclosYArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximo = 0;
            int indiceM = 0, indicem = 0, indicemedia = 0;
            int minimo = 200;
            int total = 0;
            double media = 200;
            double promedio = 0, desviacion = 0, des = 0;
            


            Console.WriteLine("Porfavor Ingrese el número de Sujetos de prueba");
            int n = int.Parse(Console.ReadLine());
            int[] edades = new int[n];
            string[] nombres = new string[n];

            for (int i = 0; i < n; i++)
            {

               Console.WriteLine("Ingrese el nombre del Sujeto " + (i+1));
                nombres[i] = Console.ReadLine();
               Console.WriteLine("Ahora ingrese la edad del Sujeto  " + (i + 1));
               edades[i] = int.Parse(Console.ReadLine());
                total += edades[i];
                

                if (edades[i] > maximo)
                {
                    maximo = edades[i];
                    indiceM = i;
                }
                if (edades [i] < minimo)
                {
                    minimo = edades[i];
                    indicem = i;
                }
            }
            Console.WriteLine("El sujeto " + nombres[indicem] + " Presenta altas probabilidades de morir, debido a ser el menor con " + minimo);
            Console.WriteLine("El sujeto " + nombres[indiceM] + " Es el mayor con " + maximo + " Pero sus capacidades Físicas están oxidadas, no se recomienda su uso ");
            promedio = (double)total / n;
            Console.WriteLine("El promedio es: " + promedio);
            for (int i = 0; i < n; i++)
            {
                des += Math.Pow((promedio - edades[i]), 2);
                if (media > (Math.Abs(edades[i]-promedio)))
                {
                    media = Math.Abs(edades[i] - promedio);
                    indicemedia = i;
                }

            }
            Console.WriteLine("El sujeto ideal esta mas cerca al promedio de edades es el " + nombres[indicemedia] + " con " + media + " de diferencia del promedio, se recomienda su uso para el experimento");
            desviacion = (Math.Sqrt(des / n));
            Console.WriteLine("La desviación es: " + desviacion);

        }
    }
}
