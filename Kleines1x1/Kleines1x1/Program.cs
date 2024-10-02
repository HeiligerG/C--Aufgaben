using System;

namespace Kleines1x1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------");
        Console.WriteLine("Kleines 1x1");
        Console.WriteLine("------------");
        
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i*j,4}");
            }
            Console.WriteLine();
        }
    }
}