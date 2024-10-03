using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string vokale = "aeiouäöüy";
        
        Console.WriteLine("Gib deinen Text ein:");
        string text = Console.ReadLine().ToLower();

        int gesamtVokale = text.Count(c => vokale.Contains(c));

        Console.WriteLine($"Dein Text enthält insgesamt {gesamtVokale} Vokale.");

        foreach (char vokal in vokale)
        {
            int anzahl = text.Count(c => c == vokal);
            if (anzahl > 0)
            {
                Console.WriteLine($"Der buchstabe '{vokal}' kommt {anzahl} Mal vor.");
            }
        }

        Console.WriteLine("Drücke eine beliebige Taste um das Programm zu beenden.");
        Console.ReadKey();
    }
}

//array mit allen vokalen - einfach ein string
//testen mit for oder while loop immer ein buschstabe mehr ob vokale drin sind - foreach
//Lamdaoperatoren verwenden fals möglich - möglich
//Linq verwenden falls möglich - möglih
//