using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tiene comida?");
            string comida = (Console.ReadLine().ToUpper());
            Console.WriteLine("Tiene refugio?");
            string refugio = Console.ReadLine().ToUpper();
            Console.WriteLine("Tiene un bate?");
            string bate = Console.ReadLine().ToUpper();

            if (comida == "si".ToUpper() && refugio == "si".ToUpper() && bate == "si".ToUpper())
            {
                Console.WriteLine("Muy bien, sobrevivis");
            }
            else
            {
                Console.WriteLine("No sobrevivis");
            }
            Console.ReadKey();
        }

       
        
    }
}
