using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.Tests
{
    public class AdditionTests
    {
        // Test set value using Fact first
        [Fact]
        public void Addition_AddingTwoInts()
        {
            // Arrange
            Addition addObject = new Addition();
            int expected = 5;

            // Act
            int actual = addObject.AddTwoNumbers(2, 3);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
