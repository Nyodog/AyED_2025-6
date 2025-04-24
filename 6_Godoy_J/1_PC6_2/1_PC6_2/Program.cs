    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int dividendo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            int divisor = int.Parse(Console.ReadLine());
            if (divisor == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                int res = dividendo / divisor;
                Console.WriteLine("El resultado de " + dividendo + " / " + divisor + " = " + res );
            }
            Console.ReadKey();
        }
    }
}
