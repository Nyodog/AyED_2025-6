using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Quiere cerrar el programa?");
            string rta = Console.ReadLine();
            while (rta != "SI")
            {
                Console.WriteLine("¿Quiere cerrar el programa?");
                rta = Console.ReadLine();
            }
            Console.Write("Hasta la vista");
            Console.ReadKey();
        }
    }
}
