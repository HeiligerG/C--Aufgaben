using System;

namespace TaschenRechner;

public class Berechner
{
    public void CheckWhatToCalculate(string operatorr, double zahl1, double zahl2)
    {
        switch (operatorr)
        {
            case "+":
                Console.WriteLine($"Das Ergebnis der Addition ist: {Addition(zahl1, zahl2)}");
                break;
            
            case "-":
                Console.WriteLine($"Das Ergebnis der Subtraktion ist: {Subtraktion(zahl1, zahl2)}");
                break;
            
            case "*":
                Console.WriteLine($"Das Ergebnis der Multiplikation ist: {Multiplikation(zahl1, zahl2)}");
                break;
            
            case "/":
                Console.WriteLine($"Das Ergebnis der Division ist: {Division(zahl1, zahl2)}");
                break;
            
            case "%":
                Console.WriteLine($"Das Ergebnis des Modulo ist: {Modulo(zahl1, zahl2)}");
                break;
            
            default:
                Console.WriteLine("Falsche Eingabe, versuche es erneut!");
                break;
        }
    }

    private static double Addition(double a, double b) => a + b;
    private double Subtraktion(double a, double b) => a - b;
    private double Multiplikation(double a, double b) => a * b;
    private double Division(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException("Division durch Null ist nicht erlaubt.");
    private double Modulo(double a, double b) => a % b;
}