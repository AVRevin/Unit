using System;

namespace AbstractFactory
{
    class OrcFactory : AbstractFactory
    {
        public override AbstractTower CreateTower()
        {
            return new OrcTower();
        }

        public override AbstractUnit CreateUnit()
        {
            return new OrcUnit();
        }
    }
}
