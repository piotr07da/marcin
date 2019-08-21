namespace Simul.Engine
{
    public class RigidBody : IBehavior
    {
        private IComponent _owner;
        private Vector2 _velocity;

        public RigidBody(Vector2 velocity)
        {
            _velocity = velocity;
        }

        public Vector2 Position
        {
            get => _owner.Transform.Position;
            set
            {
                var p = _owner.Transform.Position;
                p.X = value.X;
                p.Y = value.Y;
            }
        }
        public Vector2 Velocity
        {
            get => _velocity;
            set => _velocity = value;
        }

        public void Init(IComponent owner)
        {
            _owner = owner;
        }

        public void Update(double dt)
        {
            var p = _owner.Transform.Position;
            p.X += dt * Velocity.X;
            p.Y += dt * Velocity.Y;
        }
    }
}
