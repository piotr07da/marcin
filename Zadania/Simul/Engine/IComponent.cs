using System.Collections.Generic;

namespace Simul.Engine
{
    public interface IComponent
    {
        Transform Transform { get; }

        IEnumerable<IComponent> Children { get; }
        IEnumerable<IBehavior> Behaviors { get; }

        IComponent CreateChild();
        IComponent CreateChild(IBehavior mainBehavior);
        void AppendBehavior(IBehavior behavior);
    }
}
