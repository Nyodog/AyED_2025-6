using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escriba un programa en C# que solicite el ancho (x) y la altura (y) de un rectángulo y calcule el perímetro, el área y la diagonal.
            Console.WriteLine("Ingrese el ancho: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el altura: ");
            int y = int.Parse(Console.ReadLine());
            double l = 2 * x + 2 * y;
            Console.WriteLine("El perimetro del rectangulo es: " + l);
            double a = x * y;
            Console.WriteLine("El area del rectangulo es: " + a);
            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("La diagonal del rectangulo es: " + d);
            Console.ReadKey();
        }
    }
}
