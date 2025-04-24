using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura del agua en grados Celsius");
            int grados = int.Parse(Console.ReadLine());
            if (grados >= 100)
            {
                Console.WriteLine("Hierve");
            }
            else if (grados <= 0)
            {
                Console.WriteLine("Se congela");
            }
            else 
            {
                Console.WriteLine("Esta en estado liquido");
            }
            Console.ReadKey();
        }
    }
}
