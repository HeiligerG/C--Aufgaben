namespace DiagonalLine;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wie lang soll die Linie sein?");
        Console.Write("Deine Eingabe: ");

        int linie = Convert.ToInt32(Console.ReadLine());
        DiaLine.Diagonale(linie);
    }
}

// erste linie erster stern weg, zweite linie zweiter stern weg erster wieder da...