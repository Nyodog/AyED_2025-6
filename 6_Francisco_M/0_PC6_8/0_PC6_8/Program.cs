using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa en C# que calcule el RESTO de la división entre dos números introducidos por el usuario.

            Console.WriteLine("Ingrese el numero 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            int n2 = int.Parse(Console.ReadLine());
            int Res = n1 % n2;
            Console.WriteLine("El resto de la division es: " + Res);
            Console.ReadKey();
        }

    }
}
