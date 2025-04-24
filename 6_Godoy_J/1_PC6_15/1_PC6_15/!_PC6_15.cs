using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Simulá un juego donde el personaje está atrapado en una isla y debe sobrevivir
             durante 7 días. Cada día puede realizar distintas acciones, pero algunas tienen
             una probabilidad de tener consecuencias malas o buenas. Para esto, vas a
             utilizar números aleatorios ( Random ).
             */
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;
            bool salir = false;
            Random rand = new Random(); 
            do
            {
                {
                    Console.WriteLine("---Dia "+ dia + " ¿Qué querés hacer?---");
                    Console.WriteLine("1. -Buscar comida-");
                    Console.WriteLine("2. -Dormir-");
                    Console.WriteLine("3. -Explorar isla-");
                    Console.WriteLine("4. -Ver estado del personaje-");
                    Console.WriteLine("5. -Salir del juego-");

                    Console.Write("Ingrese una opcion: ");
                    string elec = (Console.ReadLine());
                    int probabilidad = rand.Next(1, 101);
                    switch (elec)
                    {
                        case "1":
                            
                            if (probabilidad <= 30)
                            {
                                Console.WriteLine("Comiste algo en mal estado.Salud - 15.");
                                salud = salud - 15;
                            }   
                            else
                            {
                                Console.WriteLine("+20 de hambre y -15 de energia");
                            hambre = hambre + 20;
                            energia = energia - 15;
                            }   
                            break;
                        case "2":
                            Console.WriteLine("Dormiste bien. Energia + 30 y hambre - 10");
                            break;
                        case "3":

                            if (probabilidad <= 50)
                            {
                                Console.WriteLine("¡Encontraste una planta curativa!Salud + 10.");
                                salud = salud + 10;
                            }
                            else
                            {
                                
                                    Console.WriteLine("Fue un viaje duro. Energia -20 y hambre-10");
                                    hambre = hambre - 10;
                                    energia = energia - 20;
                            }
                            else if(salud <= 0 || hambre <= 0 || energia <= 0)
                                {
                                    Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                                    sigueVivo = false;
                                }
                            break;
                        case "4":

                            Console.WriteLine("hambre: " + hambre);
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            break;
                        case "5":
                            Console.Write("¡Muchas gracias por jugar!");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("El numero que presiono no es correcto.");
                            break;
                    }
                    dia = dia + 1;
                }
            } while (!salir);
            Console.ReadKey();

        }
    }
}
