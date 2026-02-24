using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using task_3.Shapes;

namespace task_3.Creators
{
    public abstract class ShapeCreator
    {
        public abstract IShape CreateShape(Brush brush);
    }
}
