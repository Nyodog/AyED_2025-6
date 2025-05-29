using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Después de unas largas vacaciones llenas de aventuras, Phineas y Ferb regresan a la escuela. Sin embargo, como no estudiaron durante las vacaciones, necesitan un sistema que les ayude a determinar si podrán aprobar la materia.
El sistema debe permitir a Phineas y Ferb ingresar la cantidad de trabajos prácticos (TPs) y exámenes que tienen en la materia. Luego, deben ingresar las notas de cada TP y examen.
Para aprobar la materia, Phineas y Ferb deben cumplir dos condiciones:
El promedio de las notas de los exámenes debe ser mayor o igual a 6.
Al menos el 75% de los TPs deben tener una nota igual o mayor a 6.
El sistema debe calcular el promedio de los exámenes y verificar si se cumplen las condiciones para aprobar la materia. Finalmente, debe mostrar en pantalla un mensaje indicando si Phineas y Ferb pueden aprobar la materia o no.
Permitir al usuario especificar la cantidad de TPs y exámenes.
Permitir al usuario ingresar las notas de cada TP y examen.
Calcular el promedio de las notas de los exámenes.
Verificar si se cumplen las condiciones para aprobar la materia.
Mostrar un mensaje indicando si Phineas y Ferb pueden aprobar la materia. 
             
             */
            Console.WriteLine("Cuantos tps se tomaron?");
            int tps = int.Parse(Console.ReadLine());
            int[] tp = new int[tps];
            Console.WriteLine("Cuantos examenes se tomaron?");
            int exams = int.Parse(Console.ReadLine());
            int[] exam = new int[exams];
            int prom = 0;
            float porcent = 0;
            for (int i = 0; i < tp.Length; i++)
            {
                Console.WriteLine("Cuanto saco en el tp " + (i + 1) + ": ");
                tp[i] = int.Parse(Console.ReadLine());
                if (tp[i] >= 6)
                {
                    porcent++;
                }

            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            for (int n = 0; n < exam.Length; n++)
            {
                Console.WriteLine("Cuanto saco en el examen " + (n + 1) + ": ");
                exam[n] = int.Parse(Console.ReadLine());
                prom = prom + exam[n];

            }
            prom = prom / exam.Length;
            porcent = (porcent / tp.Length) * 100;
            Console.WriteLine("El porcentaje de tps aprobados es de: " + porcent + "%");
            Console.WriteLine("El promedio de examenes es de: " + prom);
            if (porcent < 75 && prom <= 6)
            {
                Console.WriteLine("No aprobaron la materia");

            }

            else
            {
                Console.WriteLine("Aprobaron la materia");
            }
            Console.ReadKey();
        }

        }
}


