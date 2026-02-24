using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
namespace task_3.Shapes
{
    public class Square : IShape
    {
        private readonly Brush _brush;

        public Square(Brush brush)
        {
            _brush = brush;
        }
        public void Draw(Canvas canvas)
        {
            canvas.Children.Add(new Rectangle
            {
                Width = 80,
                Height = 80,
                Fill = _brush,
            });
        }
    }
}
