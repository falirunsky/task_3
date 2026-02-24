using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Media;
using task_3.Shapes;

namespace task_3.Factories
{
    public class GreenShapeFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Brushes.Green);
        public IShape CreateSquare() => new Square(Brushes.Green);
        public IShape CreateTriangle() => new Triangle(Brushes.Green);
    }
}
