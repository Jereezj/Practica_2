using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir el caractér
            Console.WriteLine("Ingrese un caractér");
            char c = (char)Console.Read();

            if(char.IsLetter(c))
            {
                if (char.IsLower(c))

                {
                    Console.WriteLine("El caractér es letra minuscula");
                }

                else

                {
                    Console.WriteLine("El caractér es la letra mayuscula");

                }
                             
            }
            else

            {
                Console.WriteLine("El caractér es un numero");
            }

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
