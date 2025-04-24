using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tp 1 - Etapa 0
             Utilizando una variable de tipo string definir un programa q almacene
             en una variable una cadena que sea "Hola mundo!" e imprimirla
             
             
             */
            //caso 1
            string variable1;//declaramos variable1
            variable1 = "Hola Mundo!"; //Instanciamos variable1
            Console.WriteLine(variable1);//imprimimos variable1 
            Console.ReadKey();


            //caso 2
            String variable2 = "Hola Mundo!";//manera mas optimizada
            Console.WriteLine(variable2);
            Console.ReadKey();
    
        }
    }
}
