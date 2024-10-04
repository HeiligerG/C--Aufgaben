using System;
using System.Linq;

using Memory;

internal class program{
    
    internal static void Main()
    {
        Move move = new Move();
        Board board = new Board();
        GamePlay gamePlay = new GamePlay();
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        board.InitializeBoard();
        board.PrintBoard();
        move.GetValidMove();
        gamePlay.PlayGame();
    }
}