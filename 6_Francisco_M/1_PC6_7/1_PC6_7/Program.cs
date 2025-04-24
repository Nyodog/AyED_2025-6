using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dame una palabra: ");
            string pal = Console.ReadLine();
            int n = 0;
            while (n < 10)
            {
                Console.WriteLine(pal);
                n = n + 1;
            }
            Console.ReadKey();
        }
    }
}
