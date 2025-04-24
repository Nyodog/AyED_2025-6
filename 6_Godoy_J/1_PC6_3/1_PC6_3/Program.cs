using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribir un programa que pida al usuario un número entero y muestre por pantalla si es par o impar.

             Y... ¿Si es 0?
             */
            Console.WriteLine("Ingrese un numero entero");
            int num = int.Parse(Console.ReadLine());
            if(num == 0)
            {
                Console.WriteLine("Error su numero el numero no puede ser 0");
            }
            else if(num % 2 == 0)
            {
                Console.WriteLine("Su numero es par");
            }
            else
            {
                Console.WriteLine("Su numero es impar");
            }

            Console.ReadKey();

        }
    }
}
