using System;
using System.Linq;

namespace MemoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BoardQuestionmark board = new BoardQuestionmark();
            board.InitializeBoard();
            board.PrintBoard();
    
            PlayMemory(board);
        }

        static void PlayMemory(BoardQuestionmark board)
        {
            int pairsFound = 0;
            while (pairsFound < 8)
            {
                int[] positions = PlayerMove();
                
                bool firstCardRevealed = board.RevealCard(positions[0]);
                bool secondCardRevealed = board.RevealCard(positions[1]);
                
                board.PrintBoard();

                if (firstCardRevealed && secondCardRevealed)
                {
                    if (board.CheckMatch(positions[0], positions[1]))
                    {
                        Console.WriteLine("Treffer!");
                        pairsFound++;
                    }
                    else
                    {
                        Console.WriteLine("Leider kein Treffer.");
                        System.Threading.Thread.Sleep(2000); // Pause for 2 seconds
                        board.HideCard(positions[0]);
                        board.HideCard(positions[1]);
                        board.PrintBoard();
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Position(en). Bitte versuchen Sie es erneut.");
                }
            }
            Console.WriteLine("Gratulation. Spiel beendet.");
        }

        static int[] PlayerMove()
        {
            while (true)
            {
                Console.Write("Geben Sie zwei Positionen ein (z.B. 1234): ");
                string input = Console.ReadLine();
                if (input.Length == 4 && int.TryParse(input, out int positions))
                {
                    int pos1 = positions / 100 - 1;
                    int pos2 = positions % 100 - 1;
                    if (pos1 >= 0 && pos1 < 16 && pos2 >= 0 && pos2 < 16 && pos1 != pos2)
                    {
                        return new int[] { pos1, pos2 };
                    }
                }
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie zwei verschiedene Zahlen zwischen 01 und 16 ein.");
            }
        }
    }
}