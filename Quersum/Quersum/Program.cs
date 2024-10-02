namespace Quersum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Von welcher Zahl möchtest du die Quersumme?");
        
        if (int.TryParse(Console.ReadLine(), out int zahl))
        {
            int sum = 0;
            
            while (zahl > 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;
            }
            
            Console.WriteLine($"Die Quersumme ist: {sum}");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Gib eine ganze Zahl ein.");
        }
    }
}

//nach dem Flussdiagramm nach erstellen