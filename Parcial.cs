using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        int salida = 0 ;

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
 


        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        string[] salida = new string[5];

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        string[] salida = new string[0];

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        int counter = 0;
        string[] NombreA = new string[nombres.Length];





        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for (int i = 0; i < nombres.Length; i++)
        {
            string nombreComparado = nombres[i];
            for (int y = 0; y < nombres[i].Length; y++)
            {
                char letras = nombreComparado[y];
                if (letras == 'A')
                {
                    NombreA[counter] = nombres[i];
                    counter++;
                    break;
                    
                }
            }
        }
        string[] salida = new string[counter];
        for (int i = 0; i < salida.Length; i++)
        {
            salida[i] = NombreA[i];
        }



        //- Arriba de esta línea va su código --------

        return salida;
    }
}

