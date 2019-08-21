using Simul.Engine;
using Simul.Engine.Rendering;
using System;

namespace Simul.World
{
    public class Creature : IBehavior
    {
        private const double InitialSize = 10;

        private readonly Func<double, CircleRenderer> _rendererFactory;

        public Creature(Func<double, CircleRenderer> rendererFactory)
        {
            _rendererFactory = rendererFactory;
        }

        public void Init(IComponent owner)
        {
            owner.Transform.Position.Set(100, 100);

            var renderer = _rendererFactory(InitialSize);
            owner.AppendBehavior(renderer);

            var rBody = new RigidBody(new Vector2() { X = 20, Y = 10 });
            owner.AppendBehavior(rBody);
        }

        public void Update(double dt)
        {

        }

    }
}
