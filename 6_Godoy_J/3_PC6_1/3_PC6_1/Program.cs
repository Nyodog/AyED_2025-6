using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC6_1
{
    class Program
    {
        static int suma(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            Console.Write("ingrese el primer numero a sumar ");
            int nums1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo numero a sumar ");
            int nums2 = int.Parse(Console.ReadLine());
            int resultado = suma(nums1, nums2);
            Console.WriteLine("El resultado de la suma es "+ resultado);
            Console.ReadKey();
        }   
    }
}
