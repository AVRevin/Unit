using System;

namespace AbstractFactory
{
    class Client
    {
        private AbstractTower tower;
        private AbstractUnit unit;

        public Client(AbstractFactory factory)
        {
            // ��������������� �������� ���������������.
            tower = factory.CreateTower();
            unit = factory.CreateUnit();
        }

        public void Run()
        {
            // ��������������� ��������� �������������.
            unit.Interact(unit);
        }
    }
}
