using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC6_2
{
    class Program
    {
        static int suma(int num1, int num2)
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

        static void Main(string[] args)
        {
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("----------Bienvenido a la calculadora-------------");
                Console.WriteLine("1. Suma de 2 numeros");
                Console.WriteLine("2. Resta de 2 numeros");
                Console.WriteLine("3. Multiplicacion de 2 numeros");
                Console.WriteLine("4. Division de 2 numeros");
                Console.WriteLine("5. Salir");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Seleccione una opción: ");
                string elec = Console.ReadLine();

                switch (elec)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Ingrese el primer numero: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es " + suma(n1, n2));
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Ingrese el primer numero: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es " + resta(n1, n2));
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Ingrese el primer numero: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es " + multiplicacion(n1, n2));
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        Console.Write("Ingrese el primer numero: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es " + division(n1, n2));
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Adios. Gracias por usar la calculadora");
                        Console.ReadKey();
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }

            } while (!salir);
           
        }
    }
        
}

