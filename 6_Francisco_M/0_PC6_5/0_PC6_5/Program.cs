using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa en C# que calcule el resultado de restar dos números introducidos por el usuario.
            Console.Write("Ingrese el numero 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("E ingrese el numero 2: ");
            int n2 = int.Parse(Console.ReadLine());
            int Res = n1 - n2;
            Console.WriteLine("El resultado de la resta es: " + Res);
            Console.ReadKey();
        }
    }
}
