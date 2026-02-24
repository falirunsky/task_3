using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Media;
using task_3.Shapes;

namespace task_3.Factories
{
    public class RedShapeFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Brushes.Red);
        public IShape CreateSquare() => new Square(Brushes.Red);
        public IShape CreateTriangle() => new Triangle(Brushes.Red);
    }
}
