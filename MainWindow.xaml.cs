using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using task_3.Creators;
using task_3.Shapes;

namespace task_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += (_, _) => DrawShapes();
        }

        private void OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            if (!IsLoaded) return;
            DrawShapes();
        }

        private void DrawShapes()
        {
            canvas.Children.Clear();

            Brush brush = GetSelectedBrush();
            List<ShapeCreator> creators = GetSelectedCreators();

            double x = 20;

            foreach (var creator in creators)
            {
                IShape shape = creator.CreateShape(brush);
                shape.Draw(canvas);

                UIElement element = canvas.Children[^1];
                Canvas.SetLeft(element, x);
                Canvas.SetTop(element, 40);

                x += 120;
            }
        }

        private Brush GetSelectedBrush()
        {
            string color =
                ((ComboBoxItem)ColorComboBox.SelectedItem)?.Content?.ToString();

            return color switch
            {
                "Blue" => Brushes.Blue,
                "Green" => Brushes.Green,
                _ => Brushes.Red
            };
        }

        private List<ShapeCreator> GetSelectedCreators()
        {
            var creators = new List<ShapeCreator>();

            if (CircleCheckBox.IsChecked == true)
                creators.Add(new CircleCreator());

            if (SquareCheckBox.IsChecked == true)
                creators.Add(new SquareCreator());

            if (TriangleCheckBox.IsChecked == true)
                creators.Add(new TriangleCreator());

            return creators;
        }
    }
}