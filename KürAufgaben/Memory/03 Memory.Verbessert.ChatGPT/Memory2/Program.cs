using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Play();
        }
    }
}