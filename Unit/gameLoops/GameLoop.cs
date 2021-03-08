using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using Unit.Units.Units;
using Unit.UnitFactory;
using Unit.Units;

namespace Unit.gameLoops
{
   public class GameLoop
    {
        //время самой игры
        Stopwatch stopwatchgame = new Stopwatch();
        CreatorUnit[] units = new CreatorUnit[2];
        private int _rank = 1;
        ElfUnit elfUnit = new ElfUnit(1);



        public void CreatorUnitMethod()
        {

            units[0] = new CreatorElfUnit(_rank);
            units[1] = new CreatorOrkUnit(_rank);

        }
        public void GameLoopMethod()
        {
            stopwatchgame.Start();
            while (true)
            {
                
                // передаю время в юнита, возвращаю координату 
                //  Console.Write(units[0].FactoryMethod(_rank).Update(stopwatchgame.ElapsedMilliseconds)); 
               elfUnit.Update(stopwatchgame.ElapsedMilliseconds);
            }         
        }
    }
}
