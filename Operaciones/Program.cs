using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;
            string linea;
            //pedir numeros

            Console.WriteLine("Ingresa el primero numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingresa el segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            //operaciones suma
            resultado = num1 + num2;
            Console.WriteLine("La suma es {0}: ", resultado);
            //operacion multip

            resultado = num1 * num2;
            Console.WriteLine("La multiplicacion es {0}: ", resultado);

            //operacion resta
            resultado = num1 - num2;
            Console.WriteLine("La resta es {0}: ", resultado);
            //operaciones division
            resultado = num1 / num2;
            Console.WriteLine("La division es {0}: ", resultado);

            resultado = num1 % num2;
            Console.WriteLine("El residuo es {0}: ", resultado);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
