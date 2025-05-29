using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             En la empresa de videojuegos "Pixel Dreams", se está organizando un torneo en línea de su juego más popular, "Galaxy Quest". Para determinar los ganadores, necesitan un programa que ordene los puntajes de los jugadores de mayor a menor.
            El programa solicitará al usuario que ingrese la cantidad de participantes en el torneo.Luego, pedirá al usuario que ingrese los puntajes de cada participante, uno por uno.Una vez ingresados todos los puntajes, el programa los ordenará de mayor a menor.Finalmente, mostrará la lista de puntajes ordenados, indicando el primer lugar (mayor puntaje) y el último lugar (menor puntaje). 
             */
            Console.Write("Cuantos participantes son? ");
            int cant = int.Parse(Console.ReadLine());
            int[] part = new int[cant];
            int mayor = part[0];
            for (int i = 0; i < part.Length; i++)
            {
                Console.WriteLine("Cuantos puntos hizo el participante " + (i + 1) + "?");
                part[i] = int.Parse(Console.ReadLine());

            }
            for (int n = 0; n < part.Length-1; n++)
            {
                
                
                    mayor = part[n];
                int u = n + 1;
                    if (mayor < part[u])
                        {
                        part[n] = part[u];
                        part[u] = mayor;
                       
                        }
                    
                }

                for (int i = 0; i<part.Length; i++)
            {
                Console.WriteLine("El " + (i+1) + " consiguio " + part[i] + " puntos");
            }
            Console.ReadKey();
        }

        }
    }


