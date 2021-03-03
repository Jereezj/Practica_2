using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string ciudad;

            //.1 Pide el nombre de la persona por la consola
            Console.WriteLine("El nombre de la Persona es:");
            nombre = Console.ReadLine();
            // .2 Pedir el nombre de la ciudad
            Console.WriteLine("El nombre de la Ciudad es");
            ciudad = Console.ReadLine();
            //.3 Mostrar el nombre en pantalla
            Console.WriteLine("Hola" + nombre + "Bienvenido a" + ciudad);
            Console.WriteLine("Presione cualquier tecla");
            Console.ReadKey();
            

        }

    }
}
