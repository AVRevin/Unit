using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xunit;

namespace Unit.TryEvent
{
    public class TryGameloop
    {
        public static Stopwatch stopwatch = new Stopwatch();
        public static bool gameloop = true;
        public Timer timer = new Timer();
        public int _mapWidth;
        public int _mapHeight;
        public TryGameloop()
        {

        }
        public TryGameloop(int mapHeight, int mapWidth)
        {
            _mapWidth = mapWidth;
            _mapHeight = mapHeight;
        }
        public void GameLoopMethod()
        {
            Unit._posX = 0;
            if (Unit._posX == 0)
            {
                stopwatch.Start();
                timer.Interval = 50;
                timer.Elapsed += MoveLeft;
                timer.Enabled = true;
            }
            if (Unit._posX == _mapWidth)
            {
                stopwatch.Start();
                Console.SetCursorPosition(119, 0);
                timer.Interval = 1000;
                timer.Elapsed += MoveRight;
                timer.Enabled = true;
            }          
        }
        private void MoveLeft(object sender, ElapsedEventArgs e)
        {
            if (Unit._posX != _mapWidth)
            {
                int temp = Unit._posX++;
                Console.SetCursorPosition(temp, 0);
            }
            if (Unit._posX == _mapWidth)
            {
                timer.Enabled = false;
                stopwatch.Stop();
            }
        }

        private void MoveRight(object sender, ElapsedEventArgs e)
        {          
            if (Unit._posX != 0)
            {
                int temp = Unit._posX--;
                Console.SetCursorPosition(temp, 0);
            }
            if (Unit._posX == 0)
            {
                timer.Enabled = false;
                stopwatch.Stop();
            }
        }
    }

}
