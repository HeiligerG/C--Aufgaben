using System;
using System.Linq;

namespace Memory;

internal class GamePlay
{   
    Move move = new Move();
    Board board = new Board();
    internal void PlayGame()
    {
        while (!board.IsGameOver())
        {
            board.PrintBoard();
            var (pos1, pos2) = move.GetValidMove();
            
            board.Boardd[pos1] = board.Symbols[pos1];
            board.Boardd[pos2] = board.Symbols[pos2];
            board.PrintBoard();

            if (board.Symbols[pos1] == board.Symbols[pos2])
            {
                Console.WriteLine("Match found!");
            }
            else
            {
                Console.WriteLine("No match. Try again.");
                board.Boardd[pos1] = board.Boardd[pos2] = "?";
            }
        }

        Console.WriteLine($"Congratulations! You completed the game in {board.attempts} attempts.");
    }
}