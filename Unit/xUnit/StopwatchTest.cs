using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Unit.xUnit
{
    class StopwatchTest
    {
          [Fact]
         public void Method()
          {
            // Arrange
            double expected = 5;
            // Act
            double actual = 5;
            // Assert
            Assert.Equal(expected, actual);
          }
    }
}
