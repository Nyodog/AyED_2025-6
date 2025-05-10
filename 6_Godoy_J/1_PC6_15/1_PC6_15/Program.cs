namespace _1_PC6_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;
            bool salir = false;
            Random rand = new Random();

            do
            {
                Console.WriteLine($"\n--- Día {dia} - ¿Qué querés hacer? ---");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla");
                Console.WriteLine("4. Ver estado");
                Console.WriteLine("5. Salir del juego");
                Console.Write("Ingrese una opción: ");

                string elec = Console.ReadLine();
                int probabilidad = rand.Next(1, 101);

                switch (elec)
                {
                    case "1":
                        hambre += 20;
                        energia -= 15;
                        if (probabilidad <= 30)
                        {
                            salud -= 15;
                            Console.WriteLine("Comiste algo en mal estado. Salud -15.");
                        }
                        else
                        {
                            Console.WriteLine("Encontraste comida buena. Hambre +20, Energía -15.");
                        }
                        break;

                    case "2":
                        energia += 30;
                        hambre -= 10;
                        Console.WriteLine("Dormiste bien. Energía +30, Hambre -10.");
                        break;

                    case "3":
                        energia -= 20;
                        hambre -= 15;
                        if (probabilidad <= 50)
                        {
                            salud += 10;
                            Console.WriteLine("¡Encontraste una planta curativa! Salud +10.");
                        }
                        else
                        {
                            Console.WriteLine("Fue un viaje duro. Energía -20, Hambre -15.");
                        }
                        break;

                    case "4":
                        Console.WriteLine($"Salud: {salud}");
                        Console.WriteLine($"Hambre: {hambre}");
                        Console.WriteLine($"Energía: {energia}");
                        break;

                    case "5":
                        Console.WriteLine("¡Muchas gracias por jugar!");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("El número ingresado no es válido.");
                        break;
                }

                if (salud <= 0 || hambre <= 0 || energia <= 0)
                {
                    Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over ☠️");
                    sigueVivo = false;
                    salir = true;
                }

                dia++;
            } while (!salir && sigueVivo && dia <= 7);

            if (sigueVivo)
                Console.WriteLine("¡Sobreviviste los 7 días en la isla! ");

            Console.ReadKey();
        }
    }
}   
