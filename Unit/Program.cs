using System;
using System.Diagnostics;
using System.Threading;
using Unit.gameLoops;

namespace Unit
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLoop gameLoop = new GameLoop();
            gameLoop.GameLoopMethod();
        }
    }
}
