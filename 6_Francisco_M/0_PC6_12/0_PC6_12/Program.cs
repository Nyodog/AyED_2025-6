using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC6_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escriba un programa en C# que solicite al usuario tres letras y los muestre al revés.
            Console.WriteLine("Ponga 3 letras dejando");
            string input = Console.ReadLine();
            Console.WriteLine("Las letras a la inversa son: " + input[2] + input[1] + input[0]);
            Console.ReadKey();

        }
    }
}
