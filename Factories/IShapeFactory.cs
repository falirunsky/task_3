using System;
using System.Collections.Generic;
using System.Text;
using task_3.Shapes;

namespace task_3.Factories
{
    public interface IShapeFactory
    {
        IShape CreateCircle();
        IShape CreateSquare();
        IShape CreateTriangle();
    }
}
