using System;
using Xunit;

namespace Geometry.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1.1, 1, 2)]
        [InlineData(1.1, -1, 2)]
        [InlineData(1.1, 1, 0)]
        public void Create_WithNegativeParameters_ThrowsArgumentException(double a, double b, double c)
        {
            var exception = Record.Exception(()=> new Triangle(a,b,c));
            Assert.IsType<ArgumentException>(exception);
        }
    }
}