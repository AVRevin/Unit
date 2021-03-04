using System;

namespace AbstractFactory
{
    class OrcUnit : AbstractUnit
    {
        public override void Interact(AbstractUnit unit)
        {
            Console.WriteLine(this + " interacts with " + unit);
        }
    }
}
