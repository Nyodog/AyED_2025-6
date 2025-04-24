using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC6_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cual es tu nombre? ");
            string nombre = Console.ReadLine();
            Console.Write("¿Cual es tu edad? ");
            int edad = int.Parse(Console.ReadLine()); 
            Console.Write("Tu nombre es "+ nombre +" y tu edad es " + edad);

            Console.ReadKey();
            


        }
    }
}
