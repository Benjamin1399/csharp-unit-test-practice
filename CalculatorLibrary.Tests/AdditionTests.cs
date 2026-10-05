using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.Tests
{
    public class AdditionTests
    {
        // Test set value using Fact first
        [Fact]
        public void Addition_AddingTwoIntsSumOfFive()
        {
            // Arrange
            Addition addObject = new Addition();
            int expected = 5;

            // Act
            int actual = addObject.AddTwoNumbers(2, 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Testing various values
        [Theory]
        [InlineData(1, 4, 5)]
        [InlineData(10, 90, 100)]
        [InlineData(25000, 25000, 50000)]
        [InlineData(7, 5, 12)]
        public void Addition_AddingTwoInts(int a, int b, int expected)
        {
            // Arrange
            Addition addObject = new Addition();

            // Act
            int actual = addObject.AddTwoNumbers(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
