using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MemoryGame;

    class Game
    {
        private Board board;
        private Player player;
        private const int BoardSize = 4;

        public Game()
        {
            board = new Board(BoardSize);
            player = new Player();
        }

        public void Play()
        {
            Console.WriteLine("MEMORY -> Hinter den '?' verstecken sich Symbole, die paarweise vorkommen. Finden Sie diese!");
            Console.WriteLine("Zum Aufdecken wählen Sie zwei Positionen in der Form: Zeile1Spalte1Zeile2Spalte2.");
            Console.WriteLine("Z.Bsp.: 2142 deckt das Symbol in Zeile 2 u. Spalte 1 auf sowie das Symbol in Zeile 4 u. Spalte 2.");

            while (!board.AllPairsFound())
            {
                board.Display();
                TryMove();
            }

            Console.WriteLine($"Gratulation. Spiel beendet. Du hast {player.Attempts} Versuche benötigt.");
        }

        private void TryMove()
        {
            while (true)
            {
                Console.Write("Eingabe: ");
                string input = Console.ReadLine();

                if (input.Length != 4 || !int.TryParse(input, out _))
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte geben Sie 4 Ziffern ein.");
                    continue;
                }

                Position pos1 = new Position(int.Parse(input[0].ToString()) - 1, int.Parse(input[1].ToString()) - 1);
                Position pos2 = new Position(int.Parse(input[2].ToString()) - 1, int.Parse(input[3].ToString()) - 1);

                if (pos1.Equals(pos2))
                {
                    Console.WriteLine("Ungültige Eingabe! 2x die gleiche Position.");
                    continue;
                }

                if (!board.IsValidMove(pos1) || !board.IsValidMove(pos2))
                {
                    Console.WriteLine("Ungültiger Versuch! An mindestens einer Position wurde das Symbol bereits aufgedeckt.");
                    continue;
                }

                player.IncrementAttempts();
                MakeMove(pos1, pos2);
                break;
            }
        }

        private void MakeMove(Position pos1, Position pos2)
        {
            board.RevealCard(pos1);
            board.RevealCard(pos2);
            board.Display();

            if (board.IsMatch(pos1, pos2))
            {
                Console.WriteLine("Treffer!");
                board.RemoveCards(pos1, pos2);
            }
            else
            {
                Console.WriteLine("Leider kein Treffer.");
                Thread.Sleep(2000);
                board.HideCards(pos1, pos2);
            }
        }
    }