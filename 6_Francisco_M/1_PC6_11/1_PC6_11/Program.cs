using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero para recorrer los pares intermedios: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<=n;i++ )
            {
                int par = i % 2;
                if (par == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
