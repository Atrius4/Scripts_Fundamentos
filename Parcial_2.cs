using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public static int codigo = 1; // 0 Primer simulacro. 1 Segundo simulacro

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        double sumatoria = 0;
        int salida = 0 ;
        double promedio = 0;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < notas.Length; i++)
        {
            sumatoria += notas[i];
        }
        promedio = sumatoria / notas.Length;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < promedio)
            {
                salida++;
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        double sumatoria = 0, promedio =0;

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < notas.Length; i++)
        {
            sumatoria += notas[i];
        }
        promedio = sumatoria / notas.Length;
        for (int i = 0; i < notas.Length; i++)
        {
            for (int y = 0; y < notas.Length-1; y++)
            {
                if (Math.Abs(notas[y] - promedio) > Math.Abs(notas[y+1] - promedio))
                {
                    double tmp = notas[y + 1];
                    notas[y + 1] = notas[y];
                    notas[y] = tmp;

                    string tmp2 = nombres[y + 1];
                    nombres[y + 1] = nombres[y];
                    nombres[y] = tmp2;
                }
            }
            
        }
        for (int i = 0; i < salida.Length; i++)
        {
            salida[i] = nombres[i];
        }

        

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        int counter = 0;
        int guardados = 0;
        double sumatoria = 0, promedio = 0;


        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length; i++)
        {
            sumatoria += notas[i];
        }
        promedio = sumatoria / notas.Length;
        for (int i = 0; i < notas.Length; i++)
        {
            if(notas[i] > promedio)
            {
                counter += 1;
            }
        }
        string[] salida = new string[counter];
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > promedio)
            {
                salida[guardados] = nombres[i];
                guardados++;
            }
        }
        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        string[] nombresGuardados = new string[nombres.Length];
        int counter = 0, guardados = 0;
        char[] vocales = { 'A', 'E', 'I', 'O', 'U' };
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < nombres.Length; i++)
        {
            string name = nombres[i];

            for (int y = 0; y < vocales.Length; y++)
            {
                if(name[0] == vocales[y])
                {
                    counter++;
                    nombresGuardados[guardados] = name;
                    guardados++;
                    break;
                }

            }
        }
        string[] salida = new string[counter];
        for (int i = 0; i < counter; i++)
        {
            salida[i] = nombresGuardados[i];
        }

        


        //- Arriba de esta línea va su código --------
        return salida;
    }
}


