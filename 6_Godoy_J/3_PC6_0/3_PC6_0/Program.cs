using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC6_0
{
    class Program
    {
        static string mifuncion(string nombre)
        {   
           return "Hola " + nombre;
        }
        static void Main(string[] args)
        {
            Console.Write("Cual es tu nombre? ");
            string nom = Console.ReadLine();
            string pol = mifuncion(nom);
            Console.WriteLine(pol);
            Console.ReadKey();
        }
    }
}
