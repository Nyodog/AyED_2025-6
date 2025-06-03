using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar la cantidad de objetos");
            int cant = int.Parse(Console.ReadLine());
            Console.WriteLine("Decir cual es el valor minimo del filtro");
            int valmin = int.Parse(Console.ReadLine());
            int[] pos = new int[cant];
            for (int i = 0; i < pos.Length; i++)
            {
                Console.WriteLine("Darme el valor del objeto " + (i + 1));
                pos[i] = int.Parse(Console.ReadLine());

            }
            for (int n = 0; n <pos.Length; n++)
            {
                if (pos[n] >= valmin)
                {
                    Console.WriteLine("El objeto " + pos[n] + " esta en " + (n+1));
                }
            }
            Console.ReadKey();
        }

    }
}
