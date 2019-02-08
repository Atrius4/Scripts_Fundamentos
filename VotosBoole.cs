using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotosBoole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de votos para el primer partido"); //Datos ingresados por el usuario
            int votos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos para el segundo partido");
            int votos2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos en blanco");
            int votosBlanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos anulados");
            int votosAnulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la población total");
            int poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Que porcentaje de la población es mayor de edad?");
            double mEdad = double.Parse(Console.ReadLine());
            int numeroVotantes = votos1 + votos2 + votosBlanco + votosAnulados;
            int abstencion = (int)(poblacion * (mEdad / 100)) - numeroVotantes;

            if (((numeroVotantes> poblacion) || (Math.Abs(votos1-votos2)<(0.1* numeroVotantes))) && (numeroVotantes < (0.3 * poblacion)))
            {
                Console.WriteLine("Las elecciones deben repetirse");
            }
            else
            {
                if ( votos1>votos2){
                    Console.WriteLine("El ganador es el primer partido");
                   }
                else
                {
                    Console.WriteLine("El ganador es el segundo partido");
                }
        }
    }
}
