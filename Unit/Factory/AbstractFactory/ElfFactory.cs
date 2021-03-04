using System;

namespace AbstractFactory
{
    class ElfFactory : AbstractFactory
    {
        public override AbstractTower CreateTower()
        {
            return new ElfTower();
        }

        public override AbstractUnit CreateUnit()
        {
            return new ElfUnit();
        }
    }
}
