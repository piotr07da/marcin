namespace Simul.Engine
{
    public interface IBehavior
    {
        void Init(IComponent owner);
        void Update(double dt);
    }
}
