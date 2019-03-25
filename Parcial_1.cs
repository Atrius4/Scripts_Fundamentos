using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public static int codigo = 0; // 0 Primer simulacro. 1 Segundo simulacro

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < notas.Length; i++)
        {
            if(notas[i] <= 3)
            {
                salida += 1;
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length; i++)
        {
            for (int y = 0; y < notas.Length-1; y++)
            {
                if (notas[y] > notas[y + 1])
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

        for (int i = 0; i < 5; i++)
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

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length; i++)
        {
            if(notas[i] < 3)
            {
                counter += 1;
            }
        }
        string[] salida = new string[counter];
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < 3)
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
        int counter = 0;
        int guardado = 0;
        string[] nombresGuardados = new string[nombres.Length];
        
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < nombres.Length; i++)
        {
            string name = nombres[i].ToUpper();
            for (int y = 0; y < name.Length; y++)
            {
                char letra = 'A';
                if(name[y] == letra)
                {
                    counter++;
                    nombresGuardados[guardado] = name;
                    guardado++;
                    break;
                }
            }
        }
        string[] salida = new string[counter];
        for (int i = 0; i < salida.Length; i++)
        {
            salida[i] = nombresGuardados[i];
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }
}


