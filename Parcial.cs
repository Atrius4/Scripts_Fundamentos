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
 
        for(int i = 0; i < notas.Length; i++) {
            if ( notas[i]<= 3) {
                salida++;
            }
        }

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

        for (int i = 0; i < notas.Length-1; i++) {
            for(int y = 0; y < notas.Length - 1; y++) {
                if(notas[y] > notas[y + 1]) {
                    double tmp = notas[y + 1];
                    notas[y + 1] = notas[y];
                    notas[y] = tmp;

                    string tmp2 = nombres[y + 1];
                    nombres[y + 1] = nombres[y];
                    nombres[y] = tmp2;
                }
            }
        }

        for(int i = 0; i< salida.Length; i++) {
            salida[i] = nombres[i];
        }


        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length];
        names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length];
        data.CopyTo(notas, 0);
        int tamaño = 0;
        int counter = 0;
 

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length; i++) {
            if (notas[i] < 3) {
                tamaño += 1;
            }
        }
        Console.WriteLine("Tamaño " + tamaño);


        string[] salida = new string[tamaño];
        for (int i = 0; i < notas.Length; i++) {
            if(notas[i] < 3) {
                salida[counter] = nombres[i];
                counter++;
            }
        }

        //- Arriba de esta línea va su código --------

        return salida;
    }

    public string[] CuartoPunto() {
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
}

