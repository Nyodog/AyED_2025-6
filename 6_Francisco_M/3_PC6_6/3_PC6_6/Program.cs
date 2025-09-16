using System;
using System.Linq;
class Program
{
    static void Main()
    {  
        Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");
        // 1) Generar mano aleatoria
        string[] mano = GenerarManoAleatoria();
        // 2) Determinar tipo de mano
        string tipo = TipoDeMano(mano);
        // 3) Calcular puntaje base

        Balatro 5
    
int basePts = PuntajeBase(mano);
        // 4) Obtener multiplicador
        double mult = Multiplicador(tipo);
        // 5) Calcular puntaje final
        double total = basePts * mult;
        // 6) Aplicar jokers
        bool jokerX2 = true;
        bool jokerMas10 = true;
        total = AplicarJokers(total, jokerX2, jokerMas10);
        // 7) Mostrar resumen final
        MostrarResumen(mano, tipo, basePts, mult, total);
    }
    // ⚠️ Todas las funciones que se llaman en el Main
    // deben ser creadas acá abajo por ustedes.
    static string[] GenerarManoAleatoria()
    {
        Random rand = new Random();
        string[] palo = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
        string[] rango = { "H", "D", "C", "S" };

        string[] mano = new string[5];
        for(int i=0; i<6; i++)
        {
            mano[i] = rango[rand.Next(14)] + palo[rand.Next(5)];
        }
        return (mano);
    }

    static string TipoDeMano(string[] mano)
    {
        int poker = 0;
        int trio = 0;
        int par = 0;
        
        for (int i = 0; i<mano.Length; i++)
        {
            int iguales = 1;
            for (int j= 0; j<mano.Length; j++)
            {
                if (mano[i][0] == mano[j][0])
                    iguales++;
            }
            if (iguales == 2) par++;
            if (iguales == 3) trio++;
            if (iguales == 4) poker++;
        }
        if (poker > 0) return "Poker";
        if (trio > 0 && par > 0) return "Full";
        if (trio > 0) return "Trio";
        if (par > 0) return "Par";
        return "Nada";
    }    

    static int PuntajeBase(string[] mano)
    {
        int suma = 0;
        for (int i = 0; i<mano.Length; i++)
        {
            char r = mano[i][0];
            if (r == 'A') suma += 14;
            else if (r == 'K') suma += 13;
            else if (r == 'Q') suma += 12;
            else if (r == 'J') suma += 11;
            else if (r == 'T') suma += 10;
            else suma += int.Parse(r.ToString());
        }
        return suma;
    }


}