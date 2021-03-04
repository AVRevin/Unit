using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using Unit.TryEvent;

namespace Unit
{
    class Program
    {
       // public static Timer travel = new Timer();
        static void Main(string[] args)
        {
           TryGameloop gameLoop = new TryGameloop(Console.WindowHeight, Console.WindowWidth);
           gameLoop.GameLoopMethod();

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
