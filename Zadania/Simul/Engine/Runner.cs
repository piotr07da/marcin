using Simul.Engine.Rendering;
using System.Threading;
using System.Windows;

namespace Simul.Engine
{
    public class Runner
    {
        private const double FixedDeltaTime = 0.250;

        private readonly IMainCanvasProvider _mainCanvasProvider;
        private bool _stopRequested;

        public Runner(IMainCanvasProvider mainCanvasProvider)
        {
            _mainCanvasProvider = mainCanvasProvider;
        }

        public void Run(IComponent component)
        {
            _stopRequested = false;

            while (!_stopRequested)
            {
                UpdateComponent(component, FixedDeltaTime);
                Thread.Sleep((int)(FixedDeltaTime * 1000.0));

                Application.Current.Dispatcher.Invoke(() =>
                {
                    _mainCanvasProvider.Get().Children.Clear();
                });
            }
        }

        public void Stop()
        {
            _stopRequested = true;
        }

        private void UpdateComponent(IComponent component, double dt)
        {
            foreach (var c in component.Children)
            {
                UpdateComponent(c, dt);
            }

            foreach (var b in component.Behaviors)
            {
                b.Update(dt);
            }
        }
    }
}
