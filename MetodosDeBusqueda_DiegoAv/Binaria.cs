using System;
using System.Diagnostics;
using System.Linq;

namespace ProyectoBusquedaConsol
{
    public static class BusquedaBinaria
    {
        public static int Buscar(int[] arreglo, int valor)
        {
            Array.Sort(arreglo);
            int izquierda = 0, derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (arreglo[medio] == valor)
                    return medio;
                if (arreglo[medio] < valor)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
            return -1;
        }
    }
}
