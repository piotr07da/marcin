using System.Windows.Controls;

namespace Simul.Engine.Rendering
{
    public interface IMainCanvasProvider
    {
        Canvas Get();
        void Register(Canvas canvas);
    }
}
