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
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del personaje a buscar");
                        nombre = Console.ReadLine();
                        if (pjenc == 0)
                        {
                            Console.WriteLine("No hay personajes registrados.");
                        }
                        else
                        {
                            for (int i = 0; i < pjenc; i++)
                            {
                                buscar(tabla[i, 0], nombre, tabla[i, 1], tabla[i, 3], tabla[i, 2], tabla[i, 4]);
                            }
                        }


                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del personaje a modificar");
                        nombre = Console.ReadLine();
                        if (pjenc == 0)
                        {
                            Console.WriteLine("No hay personajes registrados.");
                        }
                        else
                        {
                            for (int i = 0; i < pjenc; i++)
                            {
                                modificar(nombre, defensa, fuerza, tabla);
                            }
                        }
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del personaje a eliminar");
                        nombre = Console.ReadLine();
                        if (pjenc == 0)
                        {
                            Console.WriteLine("No hay personajes registrados.");
                        }
                        else
                        {
                            for (int i = 0; i <pjenc; i++)
                            {
                                borrar(nombre, rta, saga, defensa, fuerza, rta);
                            }
                        }
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
        static int Crear(int pjenc, string [,] tabla, string nombre, string saga, string fuerza, string defensa, string rta)
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
            nombre = Console.ReadLine();

            Console.Write("Ingrese la saga: ");
            saga = Console.ReadLine();

            Console.Write("Ingrese la fuerza: ");
            fuerza = Console.ReadLine();

            Console.Write("Ingrese la defensa: ");
            defensa = Console.ReadLine();

            Console.WriteLine("¿Es heroe?");
            rta = Console.ReadLine().ToUpper();

            tabla[pjenc, 0] = nombre;
            tabla[pjenc, 1] = saga;
            tabla[pjenc, 2] = fuerza;
            tabla[pjenc, 3] = defensa;
            if (rta == "si")
            {
                tabla[pjenc, 4] = "Heroe";
            }
            else if (rta == "no")
            {
                tabla[pjenc, 4] = "Villano";
            }
            pjenc++;

            return pjenc;
        }
        static string buscar(string nombre, string rta, string saga, string defensa, string fuerza, string rol)
        {

            if (rta != Console.ReadLine())
            {
                return " ";
            }
            Console.WriteLine("Nombre\tSaga\tFuerza\tDefensa\tRol");
            return nombre + "\t" + saga + "\t" + fuerza + "\t" + defensa + "\t" + rol;

        }


        static string modificar(string nombre, string defensa, string fuerza, string[,] tabla)
        {

            if (nombre != Console.ReadLine())
            {
                return " ";
            }
            Console.WriteLine("Ingrese nuevo valor de fuerza: ");
            fuerza = Console.ReadLine();
            Console.WriteLine("Ingrese nuevo valor de defensa: ");
            defensa = Console.ReadLine();
            Console.WriteLine("Fuerza\tDefensa");
            return fuerza + "\t" + defensa;

        }

        static string borrar(string nombre, string rta, string saga, string defensa, string fuerza, string rol)
        {

            if (nombre != Console.ReadLine())
            {
                return " ";
            }
            Console.WriteLine("Nombre\tSaga\tFuerza\tDefensa\tRol");
            return nombre + "\t" + saga + "\t" + fuerza + "\t" + defensa + "\t" + rol;

        }
    }
    /*
    a revisar
    
                 
                        Console.WriteLine("---Busqueda de personaje---");

                        if (pjenc == 0)
                        {
                            Console.WriteLine("No hay personajes registrados.");
                        }
                        else
                        {
                            Console.WriteLine("Nombre\tSaga\tFuerza\tDefensa\tRol");
                            Console.WriteLine("--------------------------------------------------------------------------------");
                            for (int i = 0; i < pjenc; i++)
                            {
                                nombre = tabla[i, 0];
                                saga = tabla[i, 1];
                                fuerza = tabla[i, 2];
                                defensa = tabla[i, 3];
                                if (rta == "si")
                                {
                                    tabla[pjenc, 4] = "Heroe";
                                }
                                else if (rta == "no")
                                {
                                    tabla[pjenc, 4] = "Villano";
                                }
                                Console.WriteLine($"{nombre}\t\t{Saga}km\t\t{Fuerza}\t{Defensa}$\t\t");
                            }
                        }
        
    
    */
}
