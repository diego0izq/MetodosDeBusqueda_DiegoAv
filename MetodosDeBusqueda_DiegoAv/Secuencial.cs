using System;
using System.Diagnostics;
using System.Linq;

namespace ProyectoBusquedaConsol
{
    public static class BusquedaSecuencial
    {
        public static int Buscar(int[] arreglo, int valor)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valor)
                    return i;
            }
            return -1;
        }
    }
}
