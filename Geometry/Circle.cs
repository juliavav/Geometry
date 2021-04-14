using System;

namespace Geometry
{
    public class Circle : Figure
    {
        private readonly double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be non-negative.");
            this.radius = radius;
        }

        public override double CountSquare()
        {
            return radius * radius * Math.PI;
        }
    }
}