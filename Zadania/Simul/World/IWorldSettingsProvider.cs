namespace Simul.World
{
    public interface IWorldSettingsProvider
    {
        WorldSettings Get();

        void Register(WorldSettings settings);
    }
}
