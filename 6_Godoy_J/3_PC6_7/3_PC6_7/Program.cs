using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC6_7
{
    class Program
    {
        static string Crear(string[,] tabla, int pjenc, string Nombre, string Saga, string Fuerza, string Defensa, bool EsHeroe)
        {
            Console.Clear();
            while (pjenc > 20)
            {
                Console.WriteLine("No se pueden registrar más heroes. El máximo es 20.");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                break;
            }
            Console.WriteLine("---Crear nuevo personaje---");
            Console.Write("Ingrese el nombre del personaje: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese la saga: ");
            Saga = Console.ReadLine();

            Console.Write("Ingrese la fuerza: ");
            Fuerza = Console.ReadLine();

            Console.Write("Ingrese la defensa: ");
            Defensa = Console.ReadLine();

            Console.WriteLine("¿Es heroe?");
            rta = Console.ReadLine().ToUpper();

            tabla[pjenc, 0] = Nombre;
            tabla[pjenc, 1] = Saga;
            tabla[pjenc, 2] = Fuerza;
            tabla[pjenc, 3] = Defensa;
            if (rta == "si")
            {
                EsHeroe = true;
                tabla[pjenc, 4] = "Heroe";
            }
            else if (rta == "no")
            {
                EsHeroe = false;
                tabla[pjenc, 4] = "Villano";
            }
            pjenc++;

            return Nombre;
        }
        static void Main(string[] args)
        {
            string[,] tabla = new string[20, 5];
            int pjenc = 0;
            string Nombre;
            string Saga;
            string Fuerza;
            string Defensa;
            string rta;
            bool EsHeroe = false;

            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("---Menu Principal: Borderlands MVM---");
                Console.WriteLine("Personajes actuales: " + pjenc);
                Console.WriteLine();
                Console.WriteLine("1. Crear nuevo personaje");
                Console.WriteLine("2. Buscar personaje");
                Console.WriteLine("3. Modificar personaje");
                Console.WriteLine("4. Eliminar personaje");
                Console.WriteLine("5. Mostrar todos los personajes");
                Console.WriteLine("6. Salir");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Seleccione una opción: ");
                string elec = Console.ReadLine();

                switch (elec)
                {
                    case "1":
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("---Información de encargos---");

                        if (pjenc == 0)
                        {
                            Console.WriteLine("No hay encargos registrados.");
                        }
                        else
                        {
                            Console.WriteLine("Cod. Camión\tDistancia\tSede\tGanancia\tAsignado");
                            Console.WriteLine("--------------------------------------------------------------------------------");
                            for (int i = 0; i < pjenc; i++)
                            {
                                Nombre = tabla[i, 0];
                                Saga = tabla[i, 1];
                                Fuerza =tabla[i, 2];
                                Defensa = tabla[i, 3];
                                if (rta == "si")
                                {
                                    EsHeroe = true;
                                    tabla[pjenc, 4] = "Heroe";
                                }
                                else if (rta == "no")
                                {
                                    EsHeroe = false;
                                    tabla[pjenc, 4] = "Villano";
                                }
                                Console.WriteLine($"{Nombre}\t\t{Saga}km\t\t{Fuerza}\t{Defensa}$\t\t");
                            }
                        }
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "4":
                       
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "5":

                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadLine();
                        break;

                    case "6":
                        salir = true;
                        break;
                }
            }
            while (!salir);
        }
    }
}
