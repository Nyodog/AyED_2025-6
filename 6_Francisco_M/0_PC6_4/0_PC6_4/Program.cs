using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa en C# que calcule el resultado de sumar dos números introducidos por el usuario
            Console.Write("¿Cual es el numero 1?");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("¿Y el numero 2?");
            int n2 = int.Parse(Console.ReadLine());
            int Res = n1 + n2;
            Console.WriteLine("La suma entre los 2 números ingresados es: " + Res);
            Console.ReadKey();
        }
    }
}
