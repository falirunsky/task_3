using System;
using System.Collections.Generic;
using System.Text;
using task_3.Shapes;
using System.Windows.Media;
namespace task_3.Creators
{
    public class TriangleCreator : ShapeCreator
    {
        public override IShape CreateShape(Brush brush)
        {
            return new Triangle(brush);
        }
    }
}
