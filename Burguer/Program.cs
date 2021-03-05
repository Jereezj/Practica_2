using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burguer
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadburguer, cantidadbebidas, cantidadpapas;
            double cantidadtotal;
            string linea;
            const double precioburguer = 45;
            const double preciobebida = 15;
            const double preciopapas = 20;

            //hamburguesa
            Console.WriteLine("Ingrese la cantidad de Hamburguesas");
            linea = Console.ReadLine();
            cantidadburguer = int.Parse(linea);

            //bebida
            Console.WriteLine("Ingrese la cantidad de Hamburguesas");
            linea = Console.ReadLine();
            cantidadbebidas = int.Parse(linea);

            //papas
            Console.WriteLine("Ingrese la cantidad de Hamburguesas");
            linea = Console.ReadLine();
            cantidadpapas = int.Parse(linea);

            //operacion cantidad

            cantidadtotal = (cantidadburguer * precioburguer) + (cantidadbebidas * preciobebida) + (cantidadpapas * preciopapas);

            Console.WriteLine("El precio a pagar es" + cantidadtotal);
            Console.WriteLine("Presione cualquier tecla para continuar");

            Console.ReadKey();



        }
    }
}
