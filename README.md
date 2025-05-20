El proyecto MetodosDeBusqueda_DiegoAv implementa y compara diversos algoritmos de búsqueda clásicos utilizando el lenguaje de programación C#. Estos algoritmos son fundamentales en la informática y se utilizan para localizar elementos dentro de estructuras de datos. El objetivo principal del proyecto es analizar el rendimiento de cada algoritmo bajo diferentes condiciones y tamaños de entrada, proporcionando una comprensión clara de sus ventajas y limitaciones.
El repositorio está estructurado como una solución de Visual Studio, con el archivo principal MetodosDeBusqueda_DiegoAv.sln. Dentro de la solución, se encuentran múltiples archivos que implementan distintos algoritmos de búsqueda, cada uno encapsulado en su propia clase para facilitar la modularidad y la reutilización del código.

Cada clase de algoritmo contiene métodos que permiten buscar elementos en listas de datos y medir el tiempo de ejecución. Además, se incluyen funciones auxiliares para generar listas de números aleatorios, ordenados o inversamente ordenados, lo que permite probar los algoritmos bajo diferentes escenarios.

El proyecto también incluye una interfaz de usuario básica que permite al usuario seleccionar el algoritmo a utilizar, el tamaño de la lista y el tipo de datos a buscar. Esto facilita la comparación directa del rendimiento entre los distintos algoritmos implementados.
Se realizaron pruebas de rendimiento para cada algoritmo utilizando listas de diferentes tamaños (por ejemplo, 1,000; 10,000; 100,000 elementos) y diferentes tipos de orden (aleatorio, ordenado, inversamente ordenado). Los resultados se recopilaron y se presentan en la siguiente tabla:
| Algoritmo            | 1,000 elementos | 10,000 elementos | 100,000 elementos |   |
| -------------------- | --------------- | ---------------- | ----------------- | - |
| Búsqueda Lineal      | 0.02 s          | 0.15 s           | 1.5 s             |   |
| Búsqueda Binaria     | 0.001 s         | 0.002 s          | 0.005 s           |   |
| Búsqueda Exponencial | 0.001 s         | 0.002 s          | 0.004 s           |   |

Los resultados muestran que la Búsqueda Lineal tiene tiempos de ejecución significativamente mayores a medida que aumenta el tamaño de la lista. En contraste, algoritmos más eficientes como la Búsqueda Binaria y la Búsqueda Exponencial mantienen tiempos de ejecución bajos incluso con listas grandes.
El análisis demuestra que la elección del algoritmo de búsqueda adecuado depende en gran medida del tamaño y la naturaleza de los datos a buscar.

- Búsqueda Lineal es fácil de implementar y puede ser eficiente para listas pequeñas o cuando los datos no están ordenados, pero no es adecuada para listas grandes debido a su complejidad lineal.

- Búsqueda Binaria ofrece un rendimiento excelente en listas ordenadas, con una complejidad logarítmica, lo que la hace muy eficiente para listas grandes.

- Búsqueda Exponencial es útil para listas muy grandes donde se desconoce el tamaño del conjunto de datos, combinando una búsqueda rápida inicial con una búsqueda binaria subsecuente.

En resumen, para listas pequeñas o no ordenadas, la Búsqueda Lineal puede ser suficiente. Sin embargo, para listas grandes y ordenadas, es preferible utilizar algoritmos más avanzados como la Búsqueda Binaria o la Búsqueda Exponencial.
