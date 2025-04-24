using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_13
{
    class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;
            Console.WriteLine("¡Bienvenido sea!");
            do
            {
                Console.WriteLine("---MENU DE OPCIONES---");
                Console.WriteLine("1. -Division-");
                Console.WriteLine("2. -Saludar-");
                Console.WriteLine("3. -Insultar-");
                Console.WriteLine("4. -Salir-");

                Console.Write("Ingrese una opcion: ");
                string elec = (Console.ReadLine());
                switch (elec)
                {
                    case "1":
                        Console.WriteLine("Ingrese el numero 1: ");
                        float n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el numero 2: ");
                        float n2 = int.Parse(Console.ReadLine());
                        double Res = n1 / n2;
                        Console.WriteLine("El resultado de la division es: " + Res);
                        break;
                    case "2":
                        Console.Write("Ingrese su nombre: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Hola, " + name);
                        break;
                    case "3":
                        Console.Write("Ingrese su nombre: ");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("Sos bolud@, " + name2);
                        break;
                    case "4":
                        Console.Write("¡Adios!");
                        salir = true;
                        break;
                }
            } while (!salir);
            Console.ReadKey();


        }
    }
}
