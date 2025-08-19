using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC6_2
{
    class Program
    {
        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int resta(int num1, int num2)
        {
            return num1 - num2;
        }
        static int multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }
        static int division(int num1, int num2)
        {
            return num1 / num2;
        }

        static int calculadora(int numel, int numel2)
        {
            bool salir = false;
            do
            {
                Console.WriteLine("----------Bienvenido a la calculadora-------------");
                Console.WriteLine("1.Suma de 2 numeros");
                Console.WriteLine("2.Resta de 2 numeros");
                Console.WriteLine("3.Multiplicacion de 2 numeros");
                Console.WriteLine("4.Division de 2 numeros");
                Console.WriteLine("5.Division de 2 numeros");

                string elec = Console.ReadLine();
                Console.Clear();
                int resultado = 0;
                switch (elec)
                {
                    case "1":
                        resultado = sum(numel, numel2);
                        Console.WriteLine("El resultado es " + resultado);
                        break;
                    case "2":

                        resultado = resta(numel, numel2);
                        Console.WriteLine("El resultado es " + resultado);
                        break;
                    case "3":

                        resultado = resta(numel, numel2);
                        Console.WriteLine("El resultado es " + resultado);
                        break;
                    case "4":
                        resultado = division(numel, numel2);
                        Console.WriteLine("El resultado es " + resultado);
                        break;
                    case "5":
                        Console.WriteLine("Adios. Gracias por usar la calculadora");
                        salir = true;
                        break;

                }
                return resultado;
            } while (!salir);



            
           
        }
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese el primer numero con el que va a hacer la operacion ");
            int numel = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero con el que va a hacer la operacion ");
            int numel2 = int.Parse(Console.ReadLine());
            Console.Clear();
            calculadora(numel, numel2);
            Console.ReadKey();
           
        }
    }
        
}
