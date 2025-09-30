using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC6_7
{
    class Program
    {

                static void Main(string[] args)
        {
            string[,] tabla = new string[20, 5];
            int pjenc = 0;
            string nombre = "";
            string saga = "";
            string fuerza = "";
            string defensa = "";
            string rta = "";

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
                        pjenc = Crear(pjenc, tabla, nombre, saga, fuerza, defensa, rta);
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        BuscarPersonaje(tabla, pjenc);
                        break;

                    case "3":
                        ModificarPersonaje(tabla, pjenc);
                        break;

                    case "4":
                        EliminarPersonaje(tabla, pjenc);
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "5":
                        Array.Sort(tabla);
                        MostrarPersonajes(tabla, pjenc);
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

        static int Crear(int pjenc, string[,] tabla, string nombre, string saga, string fuerza, string defensa, string rta)
        {
            Console.Clear();
            if (pjenc >= 20)
            {
                Console.WriteLine("No se pueden registrar más personajes. El máximo es 20.");
                return pjenc;
            }

            Console.WriteLine("---Crear nuevo personaje---");
            Console.Write("Ingrese el nombre del personaje: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese la saga: ");
            saga = Console.ReadLine();

            Console.Write("Ingrese la fuerza: ");
            fuerza = Console.ReadLine();

            Console.Write("Ingrese la defensa: ");
            defensa = Console.ReadLine();

            Console.Write("¿Es héroe? (si/no): ");
            rta = Console.ReadLine().ToLower();

            tabla[pjenc, 0] = nombre;
            tabla[pjenc, 1] = saga;
            tabla[pjenc, 2] = fuerza;
            tabla[pjenc, 3] = defensa;
            tabla[pjenc, 4] = (rta == "si") ? "Heroe" : "Villano";

            pjenc++;
            return pjenc;
        }

        static void BuscarPersonaje(string[,] tabla, int pjenc)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del personaje a buscar:");
            string nombre = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < pjenc; i++)
            {
                if (tabla[i, 0] == nombre)
                {
                    Console.WriteLine("Nombre\tSaga\tFuerza\tDefensa\tRol");
                    Console.WriteLine(mostrar(tabla[i, 0], tabla[i, 1], tabla[i, 2], tabla[i, 3], tabla[i, 4]));
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Personaje no encontrado.");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void ModificarPersonaje(string[,] tabla, int pjenc)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del personaje a modificar:");
            string nombre = Console.ReadLine();
            bool modificado = false;

            for (int i = 0; i < pjenc; i++)
            {
                if (tabla[i, 0] == nombre)
                {
                    Console.Write("Ingrese nuevo valor de fuerza: ");
                    tabla[i, 2] = Console.ReadLine();
                    Console.Write("Ingrese nuevo valor de defensa: ");
                    tabla[i, 3] = Console.ReadLine();
                    Console.WriteLine("Personaje modificado.");
                    modificado = true;
                }
            }

            if (!modificado)
            {
                Console.WriteLine("Personaje no encontrado.");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void EliminarPersonaje(string[,] tabla, int pjenc)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del personaje a eliminar:");
            string nombre = Console.ReadLine();
            bool eliminado = false;

            for (int i = 0; i < pjenc; i++)
            {
                if (tabla[i, 0] == nombre)
                {
                    tabla[i, 0] = "";
                    tabla[i, 1] = "";
                    tabla[i, 2] = "";
                    tabla[i, 3] = "";
                    tabla[i, 4] = "";
                    Console.WriteLine("Personaje eliminado.");
                    eliminado = true;
                }
            }

            if (!eliminado)
            {
                Console.WriteLine("Personaje no encontrado.");
            }
        }

        static void MostrarPersonajes(string[,] tabla, int pjenc)
        {
            Console.Clear();
            if (pjenc == 0)
            {
                Console.WriteLine("No hay personajes registrados.");
            }
            else
            {
                Console.WriteLine("Nombre\tSaga\tFuerza\tDefensa\tRol");
                for (int i = 0; i < pjenc; i++)
                {
                    if (tabla[i, 0] != "")
                    {
                        Console.WriteLine(mostrar(tabla[i, 0], tabla[i, 1], tabla[i, 2], tabla[i, 3], tabla[i, 4]));
                    }
                }
            }
        }

        static string mostrar(string nombre, string saga, string fuerza, string defensa, string rol)
        {
            return nombre + "\t" + saga + "\t" + fuerza + "\t" + defensa + "\t" + rol;
        }

}



