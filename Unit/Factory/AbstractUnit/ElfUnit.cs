using System;

namespace AbstractFactory
{
    class ElfUnit : AbstractUnit
    {
        public override void Interact(AbstractUnit unit)
        {
            Console.WriteLine(this + " interacts with " + unit);
        }
    }
}
