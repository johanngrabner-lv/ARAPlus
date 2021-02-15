using ARAPlus.AbfallLogic;
using System;

namespace HelloARAPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ARAPlus!");

            Abfall a;
            ARAPlus.AbfallLogic.Abfall abfall = new ARAPlus.AbfallLogic.Abfall();
            abfall.Bezeichnung = "Montag";
            abfall.Preis = 120;
            abfall.Gewicht = 20;

            Console.WriteLine($"Gesamt: {((decimal)abfall.Gewicht)*abfall.Preis}");
           
        }
    }
}
