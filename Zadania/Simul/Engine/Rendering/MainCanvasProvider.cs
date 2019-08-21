using System.Windows.Controls;

namespace Simul.Engine.Rendering
{
    public class MainCanvasProvider : IMainCanvasProvider
    {
        private static Canvas _canvas;

        public Canvas Get()
        {
            return _canvas;
        }

        public void Register(Canvas canvas)
        {
            _canvas = canvas;
        }
    }
}
