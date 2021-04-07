using System;
using Xunit;

namespace Geometry.Tests
{
    public class CircleTests
    {
        
        
        [Theory]
        [InlineData(-1.1)]
        [InlineData(0)]
        public void Create_WithNegativeRadius_ThrowsArgumentException(double input)
        {
            var exception = Record.Exception(()=> new Circle(input));
            Assert.IsType<ArgumentException>(exception);
        }
    }
}