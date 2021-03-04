using System;

namespace AbstractFactory
{
    abstract class AbstractTower
    {
        public abstract void Interact(AbstractTower tower);
    }
}
