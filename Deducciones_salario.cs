using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deducciones_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario mensual:");

            double salario = double.Parse(Console.ReadLine());
            double deducciones = 0;
            double Base = salario * 0.4;
            if (Base < 828116)
            {
                Base = 828116;
            }

            Console.WriteLine("Ahora ingrese '1' si su salario es dependiente, o '2' si su salario es independiente");

            int tipo = int.Parse(Console.ReadLine());

            if (tipo == 2)
            {
                Console.WriteLine("Ingrese un número del 1 al 5 equivalente al nivel de riesgo de su trabajo");

                int riesgo = int.Parse(Console.ReadLine());
                double arl = 0;

                if (riesgo == 1)
                {
                    arl = (0.522 / 100);
                }
                else if (riesgo == 2)
                {
                    arl = (1.044 / 100);
                }
                else if (riesgo == 3)
                {
                    arl = (2.436 / 100);
                }
                else if (riesgo == 4)
                {
                    arl = (4.350 / 100);
                }
                else if (riesgo == 5)
                {
                    arl = (6.96 / 100);
                }
                else
                {
                    Console.WriteLine("opción de riesgo invalida por favor reinicie e ingrese una opción valdida");
                }

                deducciones = (Base * 0.16) + (Base * 0.125) + arl;

                Console.WriteLine("Su salario real es: " + (salario - deducciones));
                Console.WriteLine("Su salario anual sin deducciones es: " + (salario * 12));

            }
            else if (tipo == 1)
            {
                deducciones = (Base * 0.04) + (Base * 0.04);
                Console.WriteLine("Su salario real es:" + (salario - deducciones));
                Console.WriteLine("Su ssalario anual es:" + (salario * 13));
            }
            else
            {
                Console.WriteLine("Opción de tipo de salario inválida, porfavor reinicie e ingrese una opción invalida");
            }
        }
    }
}
