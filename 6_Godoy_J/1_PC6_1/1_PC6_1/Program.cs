using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que almacene la cadena de caracteres contraseña en una variable, pregunte al usuario por la contraseña e imprima por pantalla si la contraseña introducida por el usuario coincide con la guardada en la variable sin tener en cuenta mayúsculas y minúsculas.

            string contraseña = "chaumont".ToUpper();
            Console.WriteLine("Ingrese su contraseña");
            String hola = Console.ReadLine();
            if (contraseña == hola.ToUpper()) 
            {
                Console.WriteLine("La contraseña ingresada es correcta");
            }
            else
            {
                Console.WriteLine("La contraseña ingresada es incorrecta");

            }
            Console.ReadKey();
        }
    }
}
