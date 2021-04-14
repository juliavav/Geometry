using System;
using Xunit;

namespace Geometry.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(2, 6, 5, 4.68)]
        [InlineData(5, 6, 7, 14.7)]
        public void Triangle_CountSquare_ReturnsCorrectResult(double a, double b, double c, double expectedResult)
        {
            var result = new Triangle(a, b, c).CountSquare();
            Assert.Equal(expectedResult, result, 1);
        }

        [Theory]
        [InlineData(4, 5, 6, true)]
        [InlineData(5, 6, 9, false)]
        public void Triangle_IsRight_ReturnsCorrectResult(double a, double b, double c, bool expectedResult)
        {
            var result = new Triangle(a, b, c).IsRight();
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(-1.1, 1, 2)]
        [InlineData(1.1, -1, 2)]
        [InlineData(1.1, 1, 0)]
        public void Create_WithNegativeParameters_ThrowsArgumentException(double a, double b, double c)
        {
            var exception = Record.Exception(() => new Triangle(a, b, c));
            Assert.IsType<ArgumentException>(exception);
        }
    }
}