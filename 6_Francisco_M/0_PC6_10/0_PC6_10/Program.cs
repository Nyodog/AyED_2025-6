using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cree un programa en C# para convertir de grados centígrados a Kelvin y Fahrenheit. Solicite al usuario la cantidad de grados centígrados para convertirlos
            Console.WriteLine("Ingrese los grados Celsius: ");
            int cel = int.Parse(Console.ReadLine());
            double Fah = (cel*9/5)+32;
            Console.WriteLine("En grados Fahrenheit seria: " + Fah);
            double Kel = cel+273.15;
            Console.WriteLine("En grados Kelvin seria: " + Kel);
            Console.ReadKey();
        }
    }
}
