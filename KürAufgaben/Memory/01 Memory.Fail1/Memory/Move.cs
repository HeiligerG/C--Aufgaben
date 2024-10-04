using System;
using System.Linq;

namespace Memory;

internal class Move
{
    Board board = new Board();
    GamePlay gamePlay = new GamePlay();
    internal (int, int) GetValidMove()
    {
        while (true)
        {
            Console.Write("Enter two positions (0102 for positions 1 and 2): ");
            if (!int.TryParse(Console.ReadLine(), out int input) || input < 101 || input > 1616)
            {
                Console.WriteLine("Invalid input! Please enter four digits (01-16).");
                continue;
            }

            int pos1 = (input / 100) - 1;
            int pos2 = (input % 100) - 1;

            if (pos1 == pos2 || pos1 < 0 || pos1 > 15 || pos2 < 0 || pos2 > 15 || board.Boardd[pos1] != "?" || board.Boardd[pos2] != "?")
            {
                Console.WriteLine("Invalid move! Please try again.");
                continue;
            }

            board.attempts++;
            return (pos1, pos2);
        }
    }
}