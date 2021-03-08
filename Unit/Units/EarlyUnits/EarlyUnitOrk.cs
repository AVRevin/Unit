using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.Units.EarlyUnits
{
    // Скорее всего нужно переделать на свойства
    public abstract class EarlyUnitOrk
    {
        public int rank;
        public string name;
        public int cost;
        public int damage;
        public int fullheathpoint;
        public long speedunit;
    }

    public class EarlyUnitOrkOne: EarlyUnitOrk
    {
        public int rank = 1;
        public string name = "Рядовой";
        public int cost = 15;
        public int damage = 5;
        public int fullheathpoint = 100;
        public long speedunit = 100;
    }

    public class EarlyUnitOrkTwo : EarlyUnitOrk
    {
        public int rank = 2;
        public string name = "Рядовой";
        public int cost = 15;
        public int damage = 5;
        public int fullheathpoint = 100;
        public long speedunit = 100;
    }

    public class EarlyUnitOrkThree : EarlyUnitOrk
    {
        public int rank = 3;
        public string name = "Рядовой";
        public int cost = 15;
        public int damage = 5;
        public int fullheathpoint = 100;
        public long speedunit = 100;
    }

    public class EarlyUnitOrkFour : EarlyUnitOrk
    {
        public int rank = 4;
        public string name = "Рядовой";
        public int cost = 15;
        public int damage = 5;
        public int fullheathpoint = 100;
        public long speedunit = 100;
    }

    public class EarlyUnitOrkFive : EarlyUnitOrk
    {
        public int rank = 5;
        public string name = "Рядовой";
        public int cost = 15;
        public int damage = 5;
        public int fullheathpoint = 100;
        public long speedunit = 100;
    }

}
