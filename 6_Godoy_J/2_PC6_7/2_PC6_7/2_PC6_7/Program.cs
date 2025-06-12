using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC6_7
{
class Program
{
    static void Main(string[] args)
    {
        bool salir = false;
        Console.WriteLine("Ingresar el tamaño del vector: ");
        int n = int.Parse(Console.ReadLine());
        int[] vec = new int[n];
        Random rand = new Random();
        for (int i = 0; i<n;i++)
        {
            vec[i] = rand.Next(1, 151);
        }
        do
        {
            Console.WriteLine("---  ¿Qué querés hacer? ---");
            Console.WriteLine("1. Imprimir vector");
            Console.WriteLine("2. Buscar vector");
            Console.WriteLine("3. Ordenar el vector (forma ascendente o descendente)");
            Console.WriteLine("4. Cerrar el programa");
            Console.Write("Ingrese una opción: ");

            string elec = Console.ReadLine();

            switch (elec)
            {
                case "1":
                    for (int i = 0; i < vec.Length; i++)
                    {
                        Console.WriteLine("Vector N°" + i + ": " + vec[i]);
                    }
                    break;
                case "2":
                        Console.WriteLine("Ingresa el numero que queres que busque: ");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 0; i < vec.Length; i++)
                        {
                            if (num == vec[i])
                            {
                                Console.WriteLine("El numero que queres buscar esta en la posición: " + i);
                            }
                        }
                        break;
                case "3":
                    Console.WriteLine("¿De que manera quiere ordenar el vector? ¿Ascendente o descendente?");
                    string decis = Console.ReadLine();
                    if (decis == "ascendente")
                        {
                            for (int i = 0; i < vec.Length - 1; i++)
                            {
                                for (int j = 0; j < vec.Length - 1 - i; j++)
                                {
                                    if (vec[j] > vec[j + 1])
                                    {

                                        int temp = vec[j];
                                        vec[j] = vec[j + 1];
                                        vec[j + 1] = temp;
                                    }
                                }

                            }
                            for (int i = 0; i < vec.Length; i++)
                            {
                                Console.WriteLine("Vector N°" + i + ": " + vec[i]);
                            }
                        }
                        

                    else if (decis == "descendente")
                        {
                            for (int i = 0; i > vec.Length - 1; i++)
                            {
                                for (int j = 0; j < vec.Length - 1 - i; j++)
                                {
                                    if (vec[j] > vec[j + 1])
                                    {

                                        int temp = vec[j];
                                        vec[j] = vec[j + 1];
                                        vec[j + 1] = temp;
                                    }
                                }
                            }
                            for (int i = 0; i < vec.Length; i++)
                            {
                                Console.WriteLine("Vector N°" + i + ": " + vec[i]);
                            }
                        }
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

