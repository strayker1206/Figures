using System;

namespace Figures
{
    public class Circle : ICircle
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            private set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Negative radius");
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
