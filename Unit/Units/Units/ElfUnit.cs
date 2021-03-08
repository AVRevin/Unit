using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Unit.Units.EarlyUnits;

namespace Unit.Units.Units
{
    public class ElfUnit : ProductUnit
    {
        public string name;
        // начальные характеристики юнита
        public int rank; 
        public int cost;
        public int damage;
        public int fullheathpoint;
        public int currentheathpoint;
        // физика юнита
        public long speedunit=10000;
        // текущая позиция юнита
        public int _posX;
        public int _posY;
        // юнит бежит
        public bool running = true;
        // юнит стоит
        public bool halted = false;
        // юнит умер
        public bool dead = false;
        // 
        private bool _birthunit = false;
        private long _unittimeofbirth;
        private long _unitimecoordinate;
        private long _lastunittime;

       public Dictionary<int, EarlyUnitElf> dictionaryElf = new Dictionary<int, EarlyUnitElf>()
        {
            [1] =new EarlyUnitElfOne(),
            [2] = new EarlyUnitElfTwo(),
            [3] = new EarlyUnitElfThree(),
            [4] = new EarlyUnitElfFour(),
            [5] = new EarlyUnitElfFive(),
        };
        public ElfUnit(int rank)
        {
            this.rank = rank;
            foreach (var item in dictionaryElf)
            {
                if (rank==item.Key)
                {
                     name=item.Value.name;
                     cost = item.Value.cost;
                     damage = item.Value.damage;
                     fullheathpoint = item.Value.fullheathpoint;
                //     speedunit = item.Value.speedunit;
                    break;
                 }
            }
        }
        public ElfUnit()
        {

        }
        public override int Update(long ticks)
        {
            long deltatime = ticks - _unitimecoordinate;
            if (_birthunit==false)
            {
                _unittimeofbirth = ticks;
                _unitimecoordinate = ticks;
                _birthunit = true;
            }
            if (deltatime>=speedunit)
            {
                _posX++;
                Console.Write(_posX);
                _unitimecoordinate = ticks;
            }
            return _posX;
        }
    }
}
