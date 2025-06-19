using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC6_13
    {
        class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Ingrese el numero de alumnos: ");
            int fila = int.Parse(Console.ReadLine());
            int[,] matriz = new int[fila, 3];
            string nombre;
            int edad;
            float nota;
            for (int i = 0; i < fila; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno "+ (i+1) + ": ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la edad del alumno " + (i + 1) +": ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la nota del alumno " + (i + 1) + ": ");
                nota = float.Parse(Console.ReadLine());
                Console.WriteLine("-------------");
            }


            Console.ReadKey();
            }
        }
    }







