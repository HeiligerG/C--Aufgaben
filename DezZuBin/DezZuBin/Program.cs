using System;
using DezZuBin;

class Program
{
    static void Main(string[] args)
    {
        ConverterBin myConverterBin = new ConverterBin();
        while (true)
        {
            Console.Write("Geben Sie eine positive Ganzzahl ein (oder 'q' zum Beenden): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Programm wird beendet. Auf Wiedersehen!");
                break;
            }

            if (int.TryParse(input, out int n) && n >= 0)
            {
                string bin = myConverterBin.ConvertToBinary(n);
                Console.WriteLine($"Die binäre Darstellung von {n} ist: {bin}");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Ganzzahl ein.");
            }

            Console.WriteLine();
        }
    }
}