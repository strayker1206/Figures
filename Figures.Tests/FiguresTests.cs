using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Figures.Tests
{
    [TestClass]
    public class FiguresTests
    {
        [TestMethod]
        public void CircleTest()
        {
            IFigure figure = new Circle(3);

            double area = figure.GetArea();

            Assert.AreEqual(28.2743, Math.Round(area, 4));
        }

        [TestMethod]
        public void CircleNegativeRadiusTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-2));
        }

        [TestMethod]
        public void TriangleTest()
        {
            ITriangle figure = new Triangle(3, 4, 5);

            double area = figure.GetArea();

            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void NonexistentTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() =>  new Triangle(3, 4, 8));
        }

        [TestMethod]
        public void TriangleWithNegativeSidesTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-3, 4, 5));
        }

        [TestMethod]
        public void RectangularTriangleTest()
        {
            ITriangle figure = new Triangle(3, 4, 5);

            bool isRectangular = figure.IsRectangular();

            Assert.AreEqual(true, isRectangular);
        }

        [TestMethod]
        public void NotRectangularTriangleTest()
        {
            ITriangle figure = new Triangle(3, 4, 6);

            bool isRectangular = figure.IsRectangular();

            Assert.AreEqual(false, isRectangular);
        }
    }
}
