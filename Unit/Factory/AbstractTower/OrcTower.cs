using System;

namespace AbstractFactory
{
    class OrcTower : AbstractTower
    {
        public override void Interact(AbstractTower tower)
        {
            Console.WriteLine(this + " interacts with " + tower);
        }
    }
}
