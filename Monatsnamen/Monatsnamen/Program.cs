namespace Monatsnamen;

class Program
{
    static void Main(string[] args)
    {
        string[] monate = {"Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember"};
            
        Console.WriteLine("Gib eine Zahl von 1-12 an: ");
        int zahl = Convert.ToInt32(Console.ReadLine());

        if (zahl >= 1 && zahl <= 12)
        {
            Console.WriteLine($"Der Monat lautet: {monate[zahl - 1]}");
        }

        else
        {
            Console.WriteLine("Deine Zahl ist ungültig, gib eine Zahl von 1-12 an!");
        }
    }
}

// anfrage für Ganzzahl von 1-12 - 

// bool validInput = int.TryParse(Console.ReadLine(), out zahl); // für kontrolle