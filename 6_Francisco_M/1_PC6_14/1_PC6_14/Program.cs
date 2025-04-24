using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string name = "Nico";
            int salud = 100;
            int monedas = 50;
            int enemigosDerrotados = 0;
            bool tieneEspada = false;
            do
            {
                {
                    Console.WriteLine("---MENU DE OPCIONES---");
                    Console.WriteLine("1. -Mostrar estado del jugador-");
                    Console.WriteLine("2. -Encontrar espada mágica-");
                    Console.WriteLine("3. -Pelear con enemigo-");
                    Console.WriteLine("4. -Comprar poción de vida ($20 monedas)-");
                    Console.WriteLine("5. -Salir-");

                    Console.Write("Ingrese una opcion: ");
                    string elec = (Console.ReadLine());
                    switch(elec)
                    {
                        case "1":
                            if (tieneEspada == true)
                            {
                                Console.WriteLine("Si tenes la espada");
                            }
                            else
                            {
                                Console.WriteLine("No tenes la espada");
                            }

                            Console.WriteLine("Nombre: "+name);
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Monedas: " + monedas);
                            Console.WriteLine("Derroto a " + enemigosDerrotados + " enemigos");
                            
                        break;
                        case "2":
                            if (tieneEspada==false)
                            {
                                tieneEspada = true;
                                Console.WriteLine("¡Felicidades! Encontraste la espada");
                            }
                            else
                            {
                                Console.WriteLine("Ya tienes la espada");
                            }
                        break;
                        case "3":
                            if(tieneEspada==true)
                            {
                                salud = salud - 10;
                                enemigosDerrotados = enemigosDerrotados + 1;
                                Console.WriteLine("¡Ganaste la batalla! Salud -10");
                            }
                            else
                            {
                                salud = salud - 30;
                                Console.WriteLine("¡Fue una pelea dura sin espada! Salud -30");
                            }
                            if (salud <= 0)
                            {
                                Console.WriteLine("Usted se quedo sin salud, perdiste bot");
                                salir = true;
                            }
                            break;
                        case "4":
                            if (monedas>=20)
                            {
                                monedas = monedas - 20;
                                salud = salud + 20;
                                Console.WriteLine("Usaste una poción. +20 de salud");
                            }
                            else
                            {
                                Console.WriteLine("No tenés suficientes monedas");
                            }
                        break;
                        case "5":
                            Console.Write("¡Muchas gracias por jugar!");
                            salir = true;
                        break;
                        default:
                            Console.WriteLine("El numero que presiono no es correcto.");
                        break;
                    }
                }
            } while (!salir);
            Console.ReadKey();
        }
    }
}
