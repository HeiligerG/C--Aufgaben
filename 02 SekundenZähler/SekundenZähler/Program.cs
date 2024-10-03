namespace SekundenZähler;

class Program
{
    static void Main(string[] args)
    {
        const double secondsPerDay = 86400;
        Console.WriteLine("Willkommen beim Sekunden Zähler");
        
        Console.WriteLine("Wie viele Tage hat dein Monat: ");
        var tage = Convert.ToDouble(Console.ReadLine());

        var sekunden = tage * secondsPerDay;
        
        Console.WriteLine($"Okay, es sind {sekunden} in deinem Monat");
        
        Console.WriteLine("Drücke einen Knopf zum beenden: ");
        Console.ReadKey();
    }
}