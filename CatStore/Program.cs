using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mensaje de Bienvenida
            string ordencliente;
            int cantidad;
            double totalpago; 

            const double normal = 2.00, descuento1 = 1.75, descuento2 = 1.5;
            Console.WriteLine("    ^  ^                                 ^  ^");
            Console.WriteLine("   =·x·=    Bienvenidos a CatStore   =·_·=");
            Console.WriteLine("==============Promociónes=================");
            Console.WriteLine("        1 a  50  latas: $" + normal + "    c/u");
            Console.WriteLine("       51 a 100  latas: $" + descuento1 + " c/u");
            Console.WriteLine("      101 o más  latas: $" + descuento2 + "  c/u");
            Console.WriteLine("**************************************************");
            Console.WriteLine("");

            //Pedir la cantidad de latas
            Console.WriteLine("Cuantas latas desea comprar?");
            ordencliente = Console.ReadLine();

            //Guardar en una variable la cantidad de latas
            cantidad = Convert.ToInt32(ordencliente);

            //Hacer una operacion que multiplique la cantidad * precio de cada lata

            Console.WriteLine("--------------------Ticket--------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("  Cantidad      Precio      Total");

            if (cantidad < 50) //el cliente pidió 50 o menos
            {
                totalpago = cantidad * normal;
                Console.WriteLine("        {0} latas        ${1}        =  $ {2}", cantidad, normal, totalpago);
            }

            if (cantidad > 50 && cantidad < 101) //mas de 50 latas
            {
                totalpago = cantidad * descuento1;
                Console.WriteLine("        {0} latas       ${1}        =  $ {2}", cantidad, descuento1, totalpago);
            }

            if (cantidad > 100)
            {
                totalpago = cantidad * descuento2;
                Console.WriteLine("        {0} latas       ${1}        =  $ {2}", cantidad, descuento2, totalpago);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Preciona cualquier tecla para confirmar su compra");
            Console.ReadKey();
        }
    }
}
