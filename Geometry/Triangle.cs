using System;
using System.Linq;

namespace Geometry
{
    public class Triangle : Figure
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Parameters were out of range. Must be non-negative.");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CountSquare()
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRight()
        {
            var sides = new[] {a, b, c}.OrderByDescending(x => x).ToList();
            var difference = Math.Abs(sides[0] * .00001);
            return Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2) < difference;
        }
    }
}