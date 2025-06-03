using System;

namespace _2_PC6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos productos vendieron? ");
            int cant = int.Parse(Console.ReadLine());
            int[] part = new int[cant];

            for (int i = 0; i < part.Length; i++)
            {
                Console.Write("¿Cuánto salió el producto " + (i + 1) + "? ");
                part[i] = int.Parse(Console.ReadLine());
            }

            // Ordenamiento burbuja descendente
            for (int i = 0; i < part.Length - 1; i++)
            {
                for (int j = 0; j < part.Length - 1 - i; j++)
                {
                    if (part[j] < part[j + 1])
                    {
                        // Intercambio
                        int temp = part[j];
                        part[j] = part[j + 1];
                        part[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nPrecios ordenados de mayor a menor:");
            for (int i = 0; i < part.Length; i++)
            {
                Console.WriteLine("El producto " + (i + 1) + " salió " + part[i]);
            }

            Console.ReadKey();
        }
    }
}
