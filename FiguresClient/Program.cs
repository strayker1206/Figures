using Figures;
using System;
using System.Collections.Generic;

namespace FiguresClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<IFigure>();
            figures.Add(new Circle(5));
            figures.Add(new Triangle(3, 4, 5));

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.GetArea());
            }

            Console.ReadKey();
        }
    }
}
