using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5Arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración e inicialización del arreglo
            int[] numeros = { 10, 5, 20, 15, 3, 8 };

            // Inicialización de variables
            int maximo = numeros[0];
            int minimo = numeros[0];

            // Recorrido del arreglo
            for (int i = 1; i < numeros.Length; i++)
            {
                // Actualización del valor máximo
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
                // Actualización del valor mínimo
                if (numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }
            }
            // Impresión de resultados
            Console.WriteLine("El número mayor es: " + maximo);
            Console.WriteLine("El número menor es: " + minimo);
        }
    }
}
   