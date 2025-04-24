using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dame un numero para hacer una cuenta regresiva: ");
            int num = int.Parse(Console.ReadLine());
            int cuenta;
            for (int i = 0; i <= num; i++)
            {
                cuenta = num - i;
                Console.WriteLine(cuenta);
            }
            Console.ReadKey();
        }
    }
}
