namespace TaschenRechner;

class Program
{
    static void Main(string[] args)
    {
        Berechner berechner = new Berechner();
        
        Console.WriteLine("Willkommen beim Taschenrechner!");
        
        while (true)
        {
            Console.WriteLine("Drücke q zum verlassen oder Enter zum Starten: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;
            else
            {
                Console.WriteLine("Gebe die erste Zahl ein: ");
                double zahl1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gebe die zweite Zahl ein: ");
                double zahl2 = Convert.ToDouble(Console.ReadLine());
            
                Console.Clear();
            
                Console.WriteLine("Wähle aus zwischen: ");
                Console.WriteLine("+ | Addition");
                Console.WriteLine("- | Subtraktion");
                Console.WriteLine("* | Multiplikation");
                Console.WriteLine("/ | Division");
                Console.WriteLine("% | Modulo");
                string operatorr = Console.ReadLine();
                
                Console.Clear();
            
                berechner.CheckWhatToCalculate(operatorr, zahl1, zahl2);
                
                Console.WriteLine("Drücke einen Knopf um erneut zu berechnen: ");
                Console.ReadKey();
                
                Console.Clear();
            }
        }
    }
}

//Klassen: Berechner; Methoden: CheckWhatToCalculate
// +, -, *, /
//Versuchen Lamdaoperatoren einzubauen
//nur zwei zahlen
//modulo einbauen
//vlt n viele zahlen nicht nur 2
