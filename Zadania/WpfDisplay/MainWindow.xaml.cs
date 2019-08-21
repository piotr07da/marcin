using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDisplay.Functions;

namespace WpfDisplay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double Range = 100;
        private const double Resolution = 2;
        private const double InvertedResolution = 1 / Resolution;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WhiteNoiseButton_Click(object sender, RoutedEventArgs e)
        {
            Draw(new WhiteNoiseFunction(1));
        }

        private void SineButton_Click(object sender, RoutedEventArgs e)
        {
            Draw(new SineFunction(0.05, 1));
        }

        private void WhiteNoiseSmaButton_Click(object sender, RoutedEventArgs e)
        {
            Draw(new SimpleMovingAverageFunction(new WhiteNoiseFunction(1), 10));
        }

        private void SineSmaButton_Click(object sender, RoutedEventArgs e)
        {
            Draw(new SimpleMovingAverageFunction(new SineFunction(0.05, 1), 10));
        }

        private void Draw(IFunction function)
        {
            var values = CalculateFunctionValues(function, out double minValue, out double maxValue);
            NormalizeValues(values, minValue, maxValue);
            var points = ConvertToCanvasPoints(values);
            DrawPolyline(points);
        }

        private double[] CalculateFunctionValues(IFunction function, out double minValue, out double maxValue)
        {
            var values = new List<double>();
            minValue = double.MaxValue;
            maxValue = double.MinValue;
            for (double x = 0; x <= Range; x += InvertedResolution)
            {
                var value = function.Call(x);
                values.Add(value);

                if (value < minValue) minValue = value;
                if (value > maxValue) maxValue = value;
            }
            return values.ToArray();
        }

        private void NormalizeValues(double[] values, double minValue, double maxValue)
        {
            var maxDev = Math.Max(Math.Abs(minValue), Math.Abs(maxValue));
            var normalizationScale = 1 / maxDev;
            for (var i = 0; i < values.Length; ++i)
                values[i] *= normalizationScale;
        }

        private IEnumerable<Point> ConvertToCanvasPoints(double[] values)
        {
            var canvasW = MainCanvas.ActualWidth;
            var canvasH = MainCanvas.ActualHeight;
            var canvasHDiv2 = canvasH / 2.0;

            var points = new List<Point>();

            for (int i = 0; i < values.Length; ++i)
            {
                var x = i * canvasW / values.Length;
                var y = canvasHDiv2 + values[i] * canvasHDiv2;
                var point = new Point(x, y);
                points.Add(point);
            }

            return points;
        }

        private void DrawPolyline(IEnumerable<Point> points)
        {
            var polyLine = new Polyline();
            polyLine.StrokeThickness = 1;
            polyLine.Stroke = new SolidColorBrush(Colors.Black);
            polyLine.Points = new PointCollection(points);
            MainCanvas.Children.Clear();
            MainCanvas.Children.Add(polyLine);
        }
    }
}
