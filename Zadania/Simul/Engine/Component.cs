using System.Collections.Generic;

namespace Simul.Engine
{
    public class Component : IComponent
    {
        private readonly Transform _transform;
        private readonly IList<IComponent> _children;
        private readonly IList<IBehavior> _behaviors;

        public Component()
        {
            _transform = new Transform();
            _children = new List<IComponent>();
            _behaviors = new List<IBehavior>();
        }

        public Transform Transform => _transform;

        public IEnumerable<IComponent> Children => _children;
        public IEnumerable<IBehavior> Behaviors => _behaviors;

        public IComponent CreateChild()
        {
            var child = new Component();
            _children.Add(child);
            return child;
        }

        public IComponent CreateChild(IBehavior mainBehavior)
        {
            var child = CreateChild();
            child.AppendBehavior(mainBehavior);
            return child;
        }

        public void AppendBehavior(IBehavior behavior)
        {
            _behaviors.Add(behavior);
            behavior.Init(this);
        }
    }
}
