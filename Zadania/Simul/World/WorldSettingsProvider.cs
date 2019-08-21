namespace Simul.World
{
    public class WorldSettingsProvider : IWorldSettingsProvider
    {
        private static WorldSettings _settings;

        public WorldSettings Get()
        {
            return _settings;
        }

        public void Register(WorldSettings settings)
        {
            _settings = settings;
        }
    }
}
