using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); 
            Console.WriteLine("Ingresar el tamaño de la fila: ");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el tamaño de la columna: ");
            int colum = int.Parse(Console.ReadLine());
            int[,] matriz = new int[fila, colum];
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < colum; c++)
                {
                    matriz[f, c] = rand.Next(1,81);
                }
            }
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < colum; c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}