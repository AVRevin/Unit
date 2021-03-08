using System;
using System.Diagnostics;
using Unit.gameLoops;
using Unit.Units.Units;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var elfunit = new ElfUnit();
            long milliseconds = 15000;
            //ACT
            int _xPos = elfunit.Update(milliseconds);        
            Assert.Equal(1, _xPos);         
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var elfunit = new ElfUnit();
            long milliseconds = 9000;
            //ACT
            int _xPos = elfunit.Update(milliseconds);
            Assert.NotEqual(1, _xPos);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            var elfunit = new ElfUnit();
            long milliseconds = 15000;
            //ACT
            int _xPos = elfunit.Update(milliseconds);
            // Assert
            Assert.NotEqual(3, _xPos);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            var elfunit = new ElfUnit();
            //ACT
            string name = elfunit.name;

            Assert.Equal(null,name);
        }
    }
}
