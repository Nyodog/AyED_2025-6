using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC6_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int prom = 0;

            Console.WriteLine("Cuantos invitados van a la fiesta?");
            int cantinv = int.Parse(Console.ReadLine());
            int[] inv = new int[cantinv];
            bool bien = true;
            for (int i = 0; i < cantinv; i++)
            {
                Console.WriteLine("Cuanto come el invitado " + (i + 1) + ": ");
                inv[i] = int.Parse(Console.ReadLine());
                if (inv[i] > 100)
                {
                    Console.WriteLine("Error");
                    bien = false;
                    break;
                        
                }
                prom = prom + inv[i];
            }
            prom = prom / cantinv;
            if (bien) { 
            Console.WriteLine("El promedio de comida por invitado es de "+ prom);
            }
            Console.ReadKey();
        }
    }
}
