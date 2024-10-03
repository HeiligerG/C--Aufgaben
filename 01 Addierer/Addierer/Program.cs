using System;

namespace Addierer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Willkommen beim Addierer!");
        
        Console.WriteLine("Gib die erste Zahl ein: ");
        double zahl1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Gib die zweite Zahl ein: ");
        double zahl2 = Convert.ToDouble(Console.ReadLine());

        double result = zahl1 + zahl2;
        
        Console.WriteLine($"Die Addierung von {zahl1} und {zahl2} ergibt {result}");
        
        Console.WriteLine("Drücke einen Knopf zum Beenden");
        Console.ReadKey();
    }
}

//Input von abfrage aus 2 Ganzzahlen zu einer addierten ganzzahl