using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPago
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir el precio del producto
            Console.WriteLine("Ingrese el precio del producto");
            double precioproducto = Convert.ToDouble(Console.ReadLine());
            //pedir el tipo de pago 
            Console.WriteLine("Ingrese la forma de pago");
            string tipodepago = (Console.ReadLine()).ToLower();
            //Si es tarjeta debera pedir el numero de tarjeta
            if (tipodepago.Equals("tarjeta"))
            {
                Console.WriteLine("Introduce el numero de la tarjeta");
                int numero_tarjeta = Convert.ToInt32(Console.ReadLine());
                //imprimir mensaje " " el producto con precio
                //<precio> se ha pagado con el numero de cuenta: <cuenta>
                Console.WriteLine("El producto con precio" + precioproducto + "se ha pagado con el numero de tarjeta" + numero_tarjeta);

            }
            else if (tipodepago.Equals("efectivo"))
            {
                Console.WriteLine("El producto con precio" + tipodepago + "se ha pagado");
            }
            else
            {
                Console.WriteLine("No es un metodo de pago correcto");
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
