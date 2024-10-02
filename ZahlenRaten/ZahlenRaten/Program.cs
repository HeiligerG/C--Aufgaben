using System;

namespace ZahlenRaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Zahlenprüfer zahlenprüfer = new Zahlenprüfer();

            zahlenprüfer.myrandom = random.Next(1, 101);

            bool spielLäuft = true;
            while (spielLäuft)
            {
                Console.WriteLine("Finde die Zahl zwischen 1 - 100: ");
                if (int.TryParse(Console.ReadLine(), out int eingabe))
                {
                    spielLäuft = !zahlenprüfer.Checker(eingabe);
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                }
            }
        }
    }
}

//Ratespiel zwischen 1 und 100

//Klassen: ZufalsgeneratorXX, Zahlenprüfer, 