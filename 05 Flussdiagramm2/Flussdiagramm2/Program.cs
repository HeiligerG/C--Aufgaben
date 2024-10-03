namespace Flussdiagramm2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wie viele Kilometer willst du rennen?");
        double kilometer = Convert.ToDouble(Console.ReadLine());

        if (kilometer <= 42)
        {
            double runden = kilometer / 0.4;
            Console.WriteLine($"Bist du bereit {runden} Runden zu laufen?");
            bool bereit = Console.ReadLine().ToLower() == "ja";

            if (bereit)
            {
                for (double i = 0; i <= runden; i++)
                {
                    Console.WriteLine($"Du bist bei der {i} Runde.");
                }
            }
            
            Console.WriteLine("Du hast es geschafft!");
            
        }

        else
        {
            Console.WriteLine("Das schaffst du nie!");
        }
    }
}

// 1. Anfrage der Kilometeranzahl 2. Input der Kilometeranzahl 3. wenn grösser als 42 dan ausgabe "das schafst du nicht" Fertig
//                                                              /// oder 3. wenn kleiner berechnen wie viele runden n das sind (1 runde ist 400m(0.4km) 4. ausgabe wie viele runden 5.anfrage ob bereit? 6. wenn nein dan Fertig
                                                                /// 6. oder wenn Ja i=1 initialisieren 7. prüfen ob 1 kleiner ist als n 8. wenn ja dan ausgabe dann ausgabe du läufst runde (i) dann i++ bis nein
                                                                /// 8. dann wieder zurück (while) bis nein. 9. dann ausgabe du hast es geschafft