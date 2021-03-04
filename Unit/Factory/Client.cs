using System;

namespace AbstractFactory
{
    class Client
    {
        private AbstractTower tower;
        private AbstractUnit unit;

        public Client(AbstractFactory factory)
        {
            // Абстрагирование процесса инстанцирования.
            tower = factory.CreateTower();
            unit = factory.CreateUnit();
        }

        public void Run()
        {
            // Абстрагирование вариантов использования.
            unit.Interact(unit);
        }
    }
}
