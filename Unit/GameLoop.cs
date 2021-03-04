using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    public class GameLoop
    {
        Unit unit = new Unit();
        public int _posX;
        public int _posY;


        public int _mapWidth;
        public int _mapHeight;
        public long _ticks;

        public GameLoop(int mapHeight, int mapWidth)
        {
            _mapHeight = mapHeight;
            _mapWidth = mapWidth;
            _posX = mapWidth - 1;
        }


      //  public async void Move()
      //  {
      //      Stopwatch stopmatch = new Stopwatch();
      //
      //      if (_posX == 0)
      //      {
      //          while (_posX != _mapWidth)
      //          {
      //              stopmatch.Start();
      //              await Task.Delay(unit._speedunit);
      //              _posX++;
      //              stopmatch.Stop();
      //          }
      //          _ticks = stopmatch.ElapsedMilliseconds;
      //          Console.WriteLine(_ticks);
      //      }
      //
      //      if (_posX == _mapWidth - 1)
      //      {
      //          while (_posX != 0)
      //          {
      //              Console.SetCursorPosition(_posX, 0);
      //              stopmatch.Start();
      //              await Task.Delay(unit._speedunit);
      //              _posX--;
      //              stopmatch.Stop();
      //          }
      //      }
      //  }
    }
}
