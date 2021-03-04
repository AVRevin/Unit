using System;

namespace AbstractFactory
{
    class ElfTower : AbstractTower
    {
        public override void Interact(AbstractTower tower)
        {
            Console.WriteLine(this + " interacts with " + tower);
        }
    }
}
