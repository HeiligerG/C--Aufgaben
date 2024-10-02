namespace Tannenbaum;

public class EingabeAbfrager
{
    public int EingabeAbfragen(string frage)
    {
        int wert;
        do
        {
            Console.Write(frage + " ");
            if (!int.TryParse(Console.ReadLine(), out wert) || wert <= 0)
            {
                Console.WriteLine("Bitte geben Sie eine positive ganze Zahl ein.");
            }
        } while (wert <= 0);
        return wert;
    }
}