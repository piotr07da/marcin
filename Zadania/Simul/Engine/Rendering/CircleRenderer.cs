using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Simul.Engine.Rendering
{
    public class CircleRenderer : IBehavior
    {
        private IComponent _owner;
        private double _radius;
        private readonly IMainCanvasProvider _mainCanvasProvider;

        public CircleRenderer(double radius, IMainCanvasProvider mainCanvasProvider)
        {
            _radius = radius;
            _mainCanvasProvider = mainCanvasProvider;
        }

        public void Init(IComponent owner)
        {
            _owner = owner;
        }

        public void Update(double dt)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                var circle = new Ellipse()
                {
                    Width = _radius,
                    Height = _radius,
                    Fill = new SolidColorBrush(Colors.Red)
                };

                _mainCanvasProvider.Get().Children.Add(circle);

                var p = _owner.Transform.Position;
                Canvas.SetLeft(circle, p.X - _radius / 2.0);
                Canvas.SetTop(circle, p.Y - _radius / 2.0);
            });
        }
    }
}
