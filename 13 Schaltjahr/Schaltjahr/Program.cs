﻿using System;
using Schaltjahr;

class Program
{
    static void Main()
    {
        SchaltjahrPrüfer mySchaltjahrPrüfer = new SchaltjahrPrüfer();
        
        Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

        while (true)
        {
            Console.Write("\nEingabe Jahr (q to quit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;

            if (int.TryParse(input, out var jahr))
            {
                bool istSchaltjahr = mySchaltjahrPrüfer.IstSchaltjahr(jahr);
                if (istSchaltjahr)
                    Console.WriteLine($"Das Jahr {jahr} ist ein Schaltjahr.");
                else
                    Console.WriteLine($"Das Jahr {jahr} ist KEIN Schaltjahr.");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Jahreszahl ein.");
            }
        }
    }
}




// umlaufzeit der Erde: 365.24
// alle 4 jahre - 1 Tag
// Schaltjahre sind durch 4 Teilbar - case 3
// auf 00 endend aber durch 400 teilbar ohne rest _ auch schaltjahre und punkt 2 - case 1 (/100) und 2 (/400)

// Ausnahmen: Jahre die auf 00 enden


// Also ein schaltjahr ist: durch 4 Teilbar oder bei 00 durch 400 teilbar