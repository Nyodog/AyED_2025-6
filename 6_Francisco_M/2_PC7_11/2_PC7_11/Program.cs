using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Ingresar el tamaño de la fila y columna: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz1 = new int[n, n];
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    matriz1[f, c] = rand.Next(1, 81);
                }
            }

            Console.WriteLine("Matriz 1:");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matriz1[f, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Matriz a 90°");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matriz1[c, f] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
