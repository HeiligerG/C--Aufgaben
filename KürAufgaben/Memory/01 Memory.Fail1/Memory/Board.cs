using System;
using System.Linq;

namespace Memory;

internal class Board
{
    internal readonly string[] Symbols = 
    { "🫠", "🥩", "😶", "🥶", "🫠", "🥩", "😶", "🥶", "🫠", "🥩", "😶", "🥶", "🫠", "🥩", "😶", "🥶" };
    internal readonly string[] Boardd = new string[16];
    internal int attempts = 0;
    
    internal void InitializeBoard()
    {
        Array.Fill(Boardd, "?");
        Random rng = new Random();
        var shuffledSymbols = Symbols.OrderBy(_ => rng.Next()).ToArray();
        Array.Copy(shuffledSymbols, Symbols, Symbols.Length);
    }

    internal void PrintBoard()
    {
        for (int i = 0; i < 16; i += 4)
        {
            Console.WriteLine(string.Join(" ", Boardd.Skip(i).Take(4)));
        }
        Console.WriteLine();
    }
    
    internal bool IsGameOver() => !Boardd.Contains("?");
}