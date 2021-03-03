using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar 3 variables de tipo INT
            int numero_1 = 5;
            int numero_2 = 20;
            int numero_3 = 10;

            // Crear una variable INT que guarde las 3 sumas
            int suma = numero_1 + numero_2 + numero_3;

            // Mostrar en pantalla el mensaje del resultado
            Console.WriteLine("El valor de suma es: " + suma);
            Console.WriteLine("Presione cualquier tecla");
            Console.ReadKey();
        }
    }
}
