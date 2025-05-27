using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int prom = 0;
            int total = 0;
            int [] vueltas = new int[5];
            for (int i = 0; i < vueltas.Length; i++)
            {
                int segs = rand.Next(90, 121);
                vueltas[i] = segs;
                total = total + vueltas[i];
            }
            
            for (int i = 0; i < vueltas.Length; i++)
            {  
                Console.WriteLine("Tiempo de vuelta " + (i+1) + ": " + vueltas[i]);
            }
            int menor = vueltas[0];
            for (int i = 0; i < vueltas.Length; i++)
            {
                 if (menor > vueltas[i])
                {
                    menor = vueltas[i];
                }
            }
            prom = total / vueltas.Length;
            Console.WriteLine("El tiempo total de la carrera fue: " + total);
            Console.WriteLine("El promedio del tiempo de las vueltas es: " + prom);
            Console.WriteLine("La vuelta con mejor tiempo es: " + menor);
            Console.ReadLine();
        }
    }
}
