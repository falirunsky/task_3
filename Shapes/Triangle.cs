using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace task_3.Shapes
{
    public class Triangle : IShape
    {
        private readonly Brush _brush;

        public Triangle(Brush brush)
        {
            _brush = brush;
        }

        public void Draw(Canvas canvas)
        {
            canvas.Children.Add(new Polygon
            {
                Fill = _brush,
                Points = new PointCollection
            {
                new System.Windows.Point(40, 0),
                new System.Windows.Point(80, 80),
                new System.Windows.Point(0, 80)
            },
            });
        }
    }
}
