using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MemoryGame;

    class Board
    {
        private Card[,] cards;
        private static readonly char[] Symbols = { '☺', '#', '♦', '♠', '♥', '♣', '♫', '☼' };

        public Board(int size)
        {
            cards = new Card[size, size];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            List<char> allSymbols = new List<char>();
            for (int i = 0; i < cards.GetLength(0) * cards.GetLength(1) / 2; i++)
            {
                allSymbols.Add(Symbols[i]);
                allSymbols.Add(Symbols[i]);
            }

            var shuffledSymbols = allSymbols.OrderBy(s => Guid.NewGuid()).ToList();

            int index = 0;
            for (int i = 0; i < cards.GetLength(0); i++)
            {
                for (int j = 0; j < cards.GetLength(1); j++)
                {
                    cards[i, j] = new Card(shuffledSymbols[index++]);
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("  1 2 3 4");
            for (int i = 0; i < cards.GetLength(0); i++)
            {
                Console.Write($"{i + 1} ");
                for (int j = 0; j < cards.GetLength(1); j++)
                {
                    Console.Write(cards[i, j].IsRevealed ? $"{cards[i, j].Symbol} " : "? ");
                }
                Console.WriteLine();
            }
        }

        public bool IsValidMove(Position pos)
        {
            return !cards[pos.Row, pos.Column].IsRevealed;
        }

        public void RevealCard(Position pos)
        {
            cards[pos.Row, pos.Column].Reveal();
        }

        public void HideCards(Position pos1, Position pos2)
        {
            cards[pos1.Row, pos1.Column].Hide();
            cards[pos2.Row, pos2.Column].Hide();
        }

        public void RemoveCards(Position pos1, Position pos2)
        {
            cards[pos1.Row, pos1.Column].Remove();
            cards[pos2.Row, pos2.Column].Remove();
        }

        public bool IsMatch(Position pos1, Position pos2)
        {
            return cards[pos1.Row, pos1.Column].Symbol == cards[pos2.Row, pos2.Column].Symbol;
        }

        public bool AllPairsFound()
        {
            for (int i = 0; i < cards.GetLength(0); i++)
            {
                for (int j = 0; j < cards.GetLength(1); j++)
                {
                    if (!cards[i, j].IsRemoved)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }