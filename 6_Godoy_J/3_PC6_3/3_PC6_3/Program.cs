using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC6_3
{
    class Program
    {
        static string uno(string CodCamion, int NumEnc, string distancia, string sede, string ganancia, string[,] tabla)
        {
            Console.Clear();

            while (NumEnc > 25)
            {
                Console.WriteLine("No se pueden registrar más encargos. El máximo es 25.");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();

            }
            Console.WriteLine("---Crear nuevo encargo---");
            Console.Write("Ingrese el código del camión: ");
            CodCamion = Console.ReadLine();

            Console.Write("Ingrese la distancia (en km): ");
            distancia = Console.ReadLine();
            while (int.Parse(distancia) < 0)
            {
                Console.WriteLine("La distancia debe ser un número positivo. Intente de nuevo.");
                Console.Write("Ingrese la distancia (en km): ");
                distancia = Console.ReadLine();
            }

            do
            {
                Console.Write("Ingrese la sede (BSAS, BB, MDQ): ");
                sede = Console.ReadLine().ToUpper();
                if (sede != "BSAS" && sede != "BB" && sede != "MDQ")
                {
                    Console.WriteLine("Sede no válida. Intente de nuevo.");
                    Console.ReadLine();
                }
            } while (sede != "BSAS" && sede != "BB" && sede != "MDQ");


            Console.Write("Ingrese la ganancia: ");
            ganancia = Console.ReadLine();
            tabla[NumEnc, 0] = CodCamion;
            tabla[NumEnc, 1] = distancia;
            tabla[NumEnc, 2] = sede;
            tabla[NumEnc, 3] = ganancia;
            tabla[NumEnc, 4] = "0";
            NumEnc++;

            return CodCamion;
        }

        static string dos(string CodCamion, int NumEnc, string distancia, string sede, string asignado, string ganancia, string[,] tabla)
        {
            Console.Clear();
            Console.WriteLine("---Información de encargos---");

            if (NumEnc == 0)
            {
                Console.WriteLine("No hay encargos registrados.");
            }
            else
            {
                Console.WriteLine("Cod. Camión\tDistancia\tSede\tGanancia\tAsignado");
                Console.WriteLine("--------------------------------------------------------------------------------");
                for (int i = 0; i < NumEnc; i++)
                {
                    CodCamion = tabla[i, 0];
                    distancia = tabla[i, 1];
                    sede = tabla[i, 2];
                    ganancia = tabla[i, 3];
                    asignado = tabla[i, 4];
                    Console.WriteLine($"{CodCamion}\t\t{distancia}km\t\t{sede}\t{ganancia}$\t\t{asignado}");
                }
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            return "dos";
        }

        static string tres(string CodCamion, int NumEnc, string distancia, string sede, string asignado, string ganancia, string[,] tabla)
        {
            Console.Clear();
            Console.WriteLine("---Asignar camión a un encargo---");
            Console.WriteLine("Camiones sin asignar");
            Console.WriteLine("Cod. Camión\tDistancia\t\tSede\tGanancia\tAsignado");
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < NumEnc; i++)
            {
                if (tabla[i, 4] == "0")
                {
                    CodCamion = tabla[i, 0];
                    distancia = tabla[i, 1];
                    sede = tabla[i, 2];
                    ganancia = tabla[i, 3];
                    Console.WriteLine($"{CodCamion}\t\t{distancia}km\t\t{sede}\t{ganancia}$\t\t{tabla[i, 4]}");
                    Console.WriteLine();
                }
            }
            Console.Write("Ingrese la fila del camión a asignar: ");
            int selec = int.Parse(Console.ReadLine());

            if (tabla[selec - 1, 4] == "1")
            {
                Console.WriteLine("El camión ya está asignado a un encargo.");
            }
            else
            {
                tabla[selec - 1, 4] = "1";
                Console.WriteLine("Camión asignado correctamente.");
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(); 
            return "tres";
        }

        static string cuatro(string CodCamion, int NumEnc, string distancia, string sede, string asignado, string ganancia, string[,] tabla)
        {
            Console.Clear();
            Console.WriteLine("---Encargos asignados---");
            Console.WriteLine("Camiones asignados");
            Console.WriteLine("Cod. Camión\tDistancia\tSede\tGanancia\tAsignado");
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < NumEnc; i++)
            {
                if (tabla[i, 4] == "1")
                {
                    CodCamion = tabla[i, 0];
                    distancia = tabla[i, 1];
                    sede = tabla[i, 2];
                    ganancia = tabla[i, 3];
                    Console.WriteLine($"{CodCamion}\t\t{distancia}km\t\t{sede}\t{ganancia}$\t\t{tabla[i, 4]}");
                }
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            return "cuatro";
        }
        static string cinco(string CodCamion, int NumEnc, string distancia, string sede, string asignado, string ganancia, string[,] tabla)
        {
            int sumabsas = 0;
            int sumabb = 0;
            int sumamdq = 0;
            int contbsas = 0;
            int contbb = 0;
            int contmdq = 0;
            double promediobsas = 0;
            double promediobb = 0;
            double promediomdq = 0;
            Console.Clear();
            Console.WriteLine("---Promedio de ganancia por sede---");
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < NumEnc; i++)
            {
                if (tabla[i, 2] == "BSAS")
                {
                    CodCamion = tabla[i, 0];
                    sede = tabla[i, 2];
                    ganancia = tabla[i, 3];
                    Console.WriteLine($"{CodCamion}\t\t{sede}\t{ganancia}$");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    sumabsas += int.Parse(ganancia);
                    contbsas++;
                }
            }
            if (contbsas > 0)
            {
                promediobsas = (double)sumabsas / contbsas;
                Console.WriteLine($"Promedio de ganancia en BSAS: {promediobsas}$");
            }
            else
            {
                Console.WriteLine("No hay encargos en BSAS.");
            }
            for (int i = 0; i < NumEnc; i++)
            {
                if (tabla[i, 2] == "BB")
                {
                    CodCamion = tabla[i, 0];
                    sede = tabla[i, 2];
                    ganancia = tabla[i, 3];
                    Console.WriteLine($"{CodCamion}\t\t{sede}\t{ganancia}$");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    sumabb += int.Parse(ganancia);
                    contbb++;
                }
            }
            if (contbb > 0)
            {
                promediobb = (double)sumabb / contbb;
                Console.WriteLine($"Promedio de ganancia en BB: {promediobb}$");
            }
            else
            {
                Console.WriteLine("No hay encargos en BB.");
            }
            for (int i = 0; i < NumEnc; i++)
            {
                if (tabla[i, 2] == "MDQ")
                {
                    CodCamion = tabla[i, 0];
                    sede = tabla[i, 2];
                    ganancia = tabla[i, 3];
                    Console.WriteLine($"{CodCamion}\t\t{sede}\t{ganancia}$");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    sumamdq += int.Parse(ganancia);
                    contmdq++;
                }
            }
            if (contmdq > 0)
            {
                promediomdq = (double)sumamdq / contmdq;
                Console.WriteLine($"Promedio de ganancia en MDQ: {promediomdq}$");
            }
            else
            {
                Console.WriteLine("No hay encargos en MDQ.");
            }
            Console.WriteLine("Busqueda completa");
            Console.ReadLine();
            return "cinco";
        }

        static string seis(string CodCamion, int NumEnc, string distancia, string sede, string asignado, string ganancia, string[,] tabla)
        {
            int distanciamax = 0;
            Console.Clear();
            Console.WriteLine("---Encargo con mayor distancia---");
            Console.WriteLine("Cod. Camión\tDistancia\tSede\tGanancia\tAsignado");
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < NumEnc; i++)
            {
                if (int.Parse(tabla[i, 1]) > distanciamax)
                {
                    distanciamax = int.Parse(tabla[i, 1]);
                }
            }
            for (int i = 0; i < NumEnc; i++)
            {
                if (int.Parse(tabla[i, 1]) == distanciamax)
                {
                    CodCamion = tabla[i, 0];
                    distancia = tabla[i, 1];
                    sede = tabla[i, 2];
                    ganancia = tabla[i, 3];
                    asignado = tabla[i, 4];
                    Console.WriteLine("Cod. Camión\tDistancia\tSede\tGanancia\tAsignado");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine($"{CodCamion}\t\t{distancia}km\t\t{sede}\t{ganancia}$\t\t{asignado}");
                }
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            return "seis";
        }
        static string siete(string CodCamion, int NumEnc, string distancia, string sede, string asignado, string ganancia, string[,] tabla)
        {
            Console.Clear();
            Console.WriteLine("---Filtrar encargos por código de camión---");
            Console.Write("Ingrese el código del camión a filtrar: ");
            string buscar = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Cod. Camión\tDistancia\tSede\tGanancia\tAsignado");
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < NumEnc; i++)
            {
                if (tabla[i, 0] == buscar)
                {
                    CodCamion = tabla[i, 0];
                    distancia = tabla[i, 1];
                    sede = tabla[i, 2];
                    ganancia = tabla[i, 3];
                    asignado = tabla[i, 4];
                    Console.WriteLine($"{CodCamion}\t\t{distancia}km\t\t{sede}\t{ganancia}$\t\t{asignado}");
                }
            }
            Console.WriteLine("Busqueda completa");
            Console.ReadLine();
            return "siete";
        }
        static void Main(string[] args)
        {
            
            string[,] tabla = new string[25, 5];
            int NumEnc = 0;
            string CodCamion;
            string distancia;
            string sede;
            string ganancia;
            string asignado;

            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("---Menu Principal: Argentinian Truck Simulator---");
                Console.WriteLine("Encargos actuales: " + NumEnc);
                Console.WriteLine();
                Console.WriteLine("1. Crear nuevo encargo");
                Console.WriteLine("2. Mostrar todos los encargos");
                Console.WriteLine("3. Asignar camion a un encargo");
                Console.WriteLine("4. Mostrar todos los encargos asignados");
                Console.WriteLine("5. Promedio de ganancia por sede");
                Console.WriteLine("6. Mostrar el encargo con mayor distancia");
                Console.WriteLine("7. Filtrar encargos por código de camión");
                Console.WriteLine("8. Salir");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Seleccione una opción: ");
                string elec = Console.ReadLine();
                //nacho te amo wacho soy nico
                switch (elec)
                {
                    
                    case "1":
                        uno("0", NumEnc, "0", "0", "0", tabla);
                        break;
                        
                    case "2":
                        dos("0", NumEnc, "0", "0", "0", "0", tabla);
                        break;

                    case "3":
                        tres("0", NumEnc, "0", "0", "0", "0", tabla);
                        break;

                    case "4":
                        cuatro("0", NumEnc, "0", "0", "0", "0", tabla);
                        break;

                    case "5":
                        cinco("0", NumEnc, "0", "0", "0", "0", tabla);
                        break;

                    case "6":
                        seis("0", NumEnc, "0", "0", "0", "0", tabla);
                        break;

                    case "7":
                        siete("0", NumEnc, "0", "0", "0", "0", tabla);
                        break;

                    case "8":
                        salir = true;
                        break;
                }
            }
            while (!salir);
        }
    }
}
