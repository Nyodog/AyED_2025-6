using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos participantes son? ");
            int cant = int.Parse(Console.ReadLine());
            int[] part = new int[cant];

            for (int i = 0; i < part.Length; i++)
            {
                Console.WriteLine("Cuantos puntos hizo el participante " + (i + 1) + "?");
                part[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < part.Length - 1; i++)
            {
                for (int j = 0; j < part.Length - 1 - i; j++)
                {
                    if (part[j] < part[j + 1])
                    {
                        int aux = part[j];
                        part[j] = part[j + 1];
                        part[j + 1] = aux;
                    }
                }
            }

            for (int i = 0; i < part.Length; i++)
            {
                Console.WriteLine("El " + (i + 1) + " consiguio " + part[i] + " puntos");
            }

            Console.ReadKey();
        }
    }
}
