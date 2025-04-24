using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese sus ingresos: ");
            int ing = int.Parse(Console.ReadLine());
            if (edad == 19 && ing <= 50000)
            {
                Console.WriteLine("Puede cobrar la beca");
            }
            else if (edad < 19 && ing == 0)
            {
                Console.WriteLine("Puede cobrar la beca");
            }
            else if (edad > 19 && ing <= 100000)
            {
                Console.WriteLine("Puede cobrar la beca");
            }

            else
            {
                Console.WriteLine("No puede cobrar la beca");
            }


            Console.ReadKey();
        }
    }
}
