using System;

namespace AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractUnit CreateUnit();
        public abstract AbstractTower CreateTower();
    }
}
