using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            //.1 Pide el nombre de la persona por la consola
            Console.WriteLine("El nombre de la Persona es:");
            nombre = Console.ReadLine();

            // .2 Pedir la edad de la persona
            Console.WriteLine("Tu edad es");
            edad = Convert.ToInt32(Console.ReadLine());

            //.3 Mostrar el nombre en pantalla
            Console.WriteLine("Hola" +  nombre + "Tu edad es:" +  edad);
            Console.WriteLine("Presione cualquier tecla");
            Console.ReadKey();
        }
    }
}
