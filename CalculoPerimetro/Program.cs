using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Medidas del triangulo con var INT
            int lado_a = 10;
            int lado_b = 10;
            int lado_c = 7;

            // Se hace la operación para sacar la medida
            int perimetro = lado_a + lado_b + lado_c;
            Console.WriteLine("La suma del perimetro es: " + perimetro);
            Console.WriteLine("Presione cualquier tecla:");
            Console.ReadKey();

        }
    }
}
