using System;
using Xunit;

namespace Geometry.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(2, 12.56)]
        [InlineData(5, 78.5)]
        public void Circle_CountSquare_ReturnsCorrectResult(double radius, double expectedResult)
        {
            var result = new Circle(radius).CountSquare();
            Assert.Equal(expectedResult, result, 1);
        }


        [Theory]
        [InlineData(-1.1)]
        [InlineData(0)]
        public void Create_WithNegativeRadius_ThrowsArgumentException(double input)
        {
            var exception = Record.Exception(() => new Circle(input));
            Assert.IsType<ArgumentException>(exception);
        }
    }
}