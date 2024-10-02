namespace Teilbar3_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zahlen zwischen 1 und 30, die durch 5 und/oder 3 ohne Resr Teilbar sind:");
        
        bool isFirst = true;
        for (int i = 1; i <= 30; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                if (!isFirst)
                {
                    Console.Write(", ");
                }
                Console.Write(i);
                isFirst = false;
            }
        }
        Console.WriteLine();
    }
}