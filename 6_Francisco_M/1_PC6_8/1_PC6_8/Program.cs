using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos años tenes? ");
            int edad = int.Parse(Console.ReadLine());
            int año = 2025;
            año = año - edad;
            for (int i = 0; i <= edad; i++)
            {

                Console.WriteLine("En " + (año + i) + " tenias: " + i);
            }
            Console.ReadKey();
        }
    }
}
