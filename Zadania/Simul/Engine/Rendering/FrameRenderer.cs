using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Simul.Engine.Rendering
{
    public class FrameRenderer : IBehavior
    {
        private IComponent _owner;
        private double _width;
        private readonly IMainCanvasProvider _mainCanvasProvider;

        public FrameRenderer(double width, double height, IMainCanvasProvider mainCanvasProvider)
        {
            _width = width;
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
                var rect = new Rectangle()
                {
                    Width = _width,
                    Height = _width,
                    Stroke = new SolidColorBrush(Colors.Blue),
                    StrokeThickness = 2,
                };

                _mainCanvasProvider.Get().Children.Add(rect);

                var p = _owner.Transform.Position;
                Canvas.SetLeft(rect, p.X - _width / 2.0);
                Canvas.SetTop(rect, p.Y - _width / 2.0);
            });
        }
    }
}
