using System;
using System.Collections.Generic;
using System.Text;
using Unit.Units.EarlyUnits;

namespace Unit.Units.Units
{
    public class OrkUnit:ProductUnit
    {
        public string name;
        // начальные характеристики юнита
        public int rank;
        public int cost;
        public int damage;
        public int fullheathpoint;

        public int currentheathpoint;
        // физика юнита
        public long speedunit;
        // текущая позиция юнита
        public int _posX;
        public int _posY;
        // юнит бежит
        public bool running = true;
        // юнит стоит
        public bool halted = false;
        // юнит умер
        public bool dead = false;
        private bool _birthunit = false;
        private long _unittimeofbirth;
        private long _lastunittime;

        Dictionary<int, EarlyUnitOrk> dictionaryOrk = new Dictionary<int, EarlyUnitOrk>()
        {
            [1] = new EarlyUnitOrkOne(),
            [2] = new EarlyUnitOrkTwo(),
            [3] = new EarlyUnitOrkThree(),
            [4] = new EarlyUnitOrkFour(),
            [5] = new EarlyUnitOrkFive(),
        };
        public OrkUnit(int rank)
        {
            this.rank = rank;
            foreach (var item in dictionaryOrk)
            {
                if (rank == item.Key && rank == item.Value.rank)
                {
                    name = item.Value.name;
                    cost = item.Value.cost;
                    damage = item.Value.damage;
                    fullheathpoint = item.Value.fullheathpoint;
                    speedunit = item.Value.speedunit;
                }
            }
        }

        public override int Update(long ticks)
        {
            long deltatime = ticks - _lastunittime;
            if (_birthunit == false)
            {
                _unittimeofbirth = ticks;
                _birthunit = true;
            }
            if (deltatime == speedunit)
            {
                _posX++;
            }

            _lastunittime = ticks;
            return _posX;
        }
    }
}
