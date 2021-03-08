using System;
using System.Collections.Generic;
using System.Text;
using Unit.Units;
using Unit.Units.Units;

namespace Unit.UnitFactory
{
    public abstract class CreatorUnit
    {
        public abstract ProductUnit FactoryMethod(int _rank);
    }

    public class CreatorElfUnit : CreatorUnit
    {
        private int _rank = 0;
        public CreatorElfUnit(int rank)
         {
             _rank = rank;
         }
        public override ProductUnit FactoryMethod(int _rank)
        {
            return new ElfUnit(_rank);
        }
    }
    public class CreatorOrkUnit : CreatorUnit
    {
        private int _rank = 0;
        public CreatorOrkUnit(int rank)
        {
            _rank = rank;
        }
        public override ProductUnit FactoryMethod(int _rank)
        {
            return new OrkUnit(_rank);
        }
    }
}
