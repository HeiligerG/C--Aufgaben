using System;
using TeilenDurchQuer;

class Program
{
    static void Main(string[] args)
    {
        int zahl1, zahl2;

        while (true)
        {
            Console.Write("Zahl 1: ");
            if (int.TryParse(Console.ReadLine(), out zahl1) && zahl1 > 0)
                break;
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Ganzzahl ein.");
        }
        
        while (true)
        {
            Console.Write("Zahl 2: ");
            if (int.TryParse(Console.ReadLine(), out zahl2) && zahl2 > zahl1)
                break;
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Ganzzahl größer als Zahl 1 ein.");
        }

        Console.WriteLine("\nZahl, Quersumme, Zahl/Quersumme");

        for (int i = zahl1; i <= zahl2; i++)
        {
            int quersumme = Rechner.BerechneQuersumme(i);
            if (i % quersumme == 0)
            {
                int division = i / quersumme;
                Console.WriteLine($"{i,2}, {quersumme,2}, {division,2}");
            }
        }
    }
}