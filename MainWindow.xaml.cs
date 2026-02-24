using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using task_3.Factories;
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

            IShapeFactory factory = CreateFactory();

            double x = 20;

            if (CircleCheckBox.IsChecked == true)
                Draw(factory.CreateCircle(), ref x);

            if (SquareCheckBox.IsChecked == true)
                Draw(factory.CreateSquare(), ref x);

            if (TriangleCheckBox.IsChecked == true)
                Draw(factory.CreateTriangle(), ref x);
        }

        private void Draw(IShape shape, ref double x)
        {
            shape.Draw(canvas);

            var element = canvas.Children[^1];
            Canvas.SetLeft(element, x);
            Canvas.SetTop(element, 40);

            x += 120;
        }

        private IShapeFactory CreateFactory()
        {
            string color =
                ((ComboBoxItem)ColorComboBox.SelectedItem)?.Content?.ToString();

            return color switch
            {
                "Blue" => new BlueShapeFactory(),
                "Green" => new GreenShapeFactory(),
                _ => new RedShapeFactory()
            };
        }
    }
}