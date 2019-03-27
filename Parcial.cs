using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public static int codigo = 2; // 0 Primer simulacro. 1 Segundo simulacro

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        double sumatoria = 0, promedio = 0;
        double des = 0, desviacion = 0;
        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < notas.Length; i++)
        {
            sumatoria += notas[i];
        }
        promedio = sumatoria / notas.Length;
        for (int i = 0; i < notas.Length; i++)
        {
            des += Math.Pow((promedio - notas[i]), 2);
        }
        desviacion = Math.Sqrt(des / notas.Length);

        for (int i = 0; i < notas.Length; i++)
        {
            if(notas[i] >= (promedio + desviacion))
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
        double[] desviaciones = new double[notas.Length];
        string[] salida = new string[5];

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
            desviaciones[i] = Math.Sqrt(Math.Pow(promedio - notas[i], 2));
        }

        for (int i = 0; i < (desviaciones.Length-1); i++)
        {
            for (int y = 0; y < (desviaciones.Length-1); y++)
            {
                if (desviaciones[i] < desviaciones[i + 1])
                {
                    double tmp = desviaciones[i + 1];
                    desviaciones[i + 1] = desviaciones[i];
                    desviaciones[i] = tmp;

                    string tmp2 = nombres[i + 1];
                    nombres[i + 1] = nombres[i];
                    nombres[i] = tmp2;
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
        double sumatoria = 0, promedio = 0;
        double des = 0, desviacion = 0;
        string[] guardados = new string[nombres.Length];
        int counter = 0, guardado = 0;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < notas.Length; i++)
        {
            sumatoria += notas[i];
        }
        promedio = sumatoria / notas.Length;
        for (int i = 0; i < notas.Length; i++)
        {
            des += Math.Pow((promedio - notas[i]), 2);
        }
        desviacion = Math.Sqrt(des / notas.Length);
        for (int i = 0; i < notas.Length; i++)
        {
            if(notas[i] >= (promedio + desviacion))
            {
                counter++;
                guardados[guardado] = nombres[i];
                guardado++;
            }
        }
        string[] salida = new string[counter];
        for (int i = 0; i < salida.Length; i++)
        {
            salida[i] = guardados[i];
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        char[] vocales = { 'A', 'E', 'I', 'O', 'U' };
        string[] guardados = new string[nombres.Length];
        int counter = 0, save = 0, verificador = 0;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < nombres.Length; i++)
        {
            string name = nombres[i].ToUpper();
            verificador = 0;
            for (int y = 0; y < vocales.Length; y++)
            {
                if(name[0] != vocales[y])
                {
                    verificador++;
                }
                if(verificador == 5)
                {
                    counter++;
                    guardados[save] = name;
                    save++;
                }
            }
        }
        string[] salida = new string[counter];
        for (int i = 0; i < salida.Length; i++)
        {
            salida[i] = guardados[i];
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }
}


