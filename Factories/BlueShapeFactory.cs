using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Media;
using task_3.Shapes;

namespace task_3.Factories
{
    public class BlueShapeFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Brushes.Blue);
        public IShape CreateSquare() => new Square(Brushes.Blue);
        public IShape CreateTriangle() => new Triangle(Brushes.Blue);
    }
}