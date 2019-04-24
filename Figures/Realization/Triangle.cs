using System;

namespace Figures
{
    public class Triangle : ITriangle
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            ValidateTringle(a, b, c);
            A = a;
            B = b;
            C = c;
        }

        private void ValidateTringle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("One or more sides of the triangle are negative");

            if (a + b <= c ||
                a + c <= b ||
                b + c <= a)
                throw new ArgumentException("There is no such triangle!");
        }

        public double GetArea()
        {
            double halfPerimeter = (A + B + C) / 2;
            return Math.Sqrt(halfPerimeter *
                (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }

        public bool IsRectangular()
        {
            return (A*A + B*B == C*C) ||
                   (A*A + C*C == B*B) ||
                   (C*C + B*B == A*A);
        }
    }
}
