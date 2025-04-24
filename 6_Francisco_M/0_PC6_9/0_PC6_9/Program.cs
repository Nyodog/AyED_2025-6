using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crea un programa en C# para calcular la superficie y el volumen de una esfera, dado su radio.
(El radio lo deberá ingresar el usuario). */

            Console.Write("Ingrese el radio de la esfera ");
            int rad = int.Parse(Console.ReadLine());
            double sup = 4 * Math.PI * Math.Pow(rad,2);
            Console.WriteLine("Su superficie es:" + sup);
            double vol = 1.3333 * Math.PI * Math.Pow(rad,3);
            Console.WriteLine("Su volumen es: " + vol);
            Console.ReadKey();
        }
    }
}
