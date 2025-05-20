using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace ProyectoBusquedaConsol
{
    public static class BusquedaTransformacionClaves
    {
        public static int Buscar(int[] arreglo, int valor)
        {
            Dictionary<int, int> tabla = new Dictionary<int, int>();

            for (int i = 0; i < arreglo.Length; i++)
            {
                int clave = TransformarClave(arreglo[i]);
                if (!tabla.ContainsKey(clave))
                    tabla[clave] = i;
            }

            int claveBuscada = TransformarClave(valor);
            return tabla.ContainsKey(claveBuscada) ? tabla[claveBuscada] : -1;
        }

        private static int TransformarClave(int valor)
        {
            return valor % 100;
        }
    }
}
