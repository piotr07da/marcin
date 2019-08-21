using Simul.Engine;
using System;

namespace Simul.World
{
    public class SimulatorRoot : IBehavior
    {
        private readonly Func<Creature> _creatureFactory;
        private IComponent _owner;

        public SimulatorRoot(Func<Creature> creatureFactory)
        {
            _creatureFactory = creatureFactory;
        }

        public void Init(IComponent owner)
        {
            _owner = owner;

            _owner.CreateChild(_creatureFactory());

        }

        public void Update(double dt)
        {

        }
    }
}
