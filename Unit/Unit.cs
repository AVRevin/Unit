using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Unit
{
    public class Unit
    {
        public string name;
        public int rank;
        // характеристики юнита
        public int cost;
        public int damage;
        public int fullheathpoint;
        public int currentheathpoint;
        // физика юнита
        public static int _speedunit;
        // текузая позиция юнита
        public static int _posX;

        public static int _posY;
        public Unit()
        {
            _posX = 0;
            _posY = 0;
            _speedunit = 50; // две координаты в секунду
        }
        public Unit(int speedunit, int posX, int posY)
        {
            _speedunit = speedunit;
            _posX = posX;
            _posY = posY;
        }
    }
}
