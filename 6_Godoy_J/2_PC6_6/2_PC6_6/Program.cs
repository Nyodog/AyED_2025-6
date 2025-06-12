using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos alumnos realizaron el examen?");
            int alum = int.Parse(Console.ReadLine());

            int[] notas = new int[alum];
            for (int i = 0; i < alum; i++)
            {
                Console.WriteLine("Cuanto saco el alumno " + (i + 1) + " en el examen?");
                notas[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < notas.Length - 1; i++)
            {
                for (int j = 0; j < notas.Length - 1 - i; j++)
                {
                    if (notas[j] > notas[j + 1])
                    {

                        int temp = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("El alumno " + (i + 1) + " saco " + notas[i]);
            }
            Console.WriteLine("===================");
            Console.WriteLine("Ingrese un numero para filtrar por multiplo");
            int mult = int.Parse(Console.ReadLine());
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] % mult == 0)
                {
                    Console.WriteLine("La nota " + i + " filtrada por " + mult + " es igual a: " + notas[i]);
                }
            }


            Console.ReadKey();
        }
    }
}
