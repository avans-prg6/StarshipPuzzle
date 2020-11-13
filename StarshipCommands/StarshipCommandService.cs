
using StarshipCommands.Interfaces;

namespace StarshipCommands.Services
{
    public class StarshipCommandService
    {
        private int commandId;
        public IStarshipCommandTransient LaunchTorpedoesTransient { get; }
        public IStarshipCommandScoped LaunchTorpedoesScoped { get; }
        public IStarshipCommandSingleton LaunchTorpedoesSingleton { get; }
        public IStarshipCommandSingletonInstance LaunchTorpedoesSingletonInstance { get; }

        public StarshipCommandService(IStarshipCommandTransient transient,
            IStarshipCommandScoped scoped,
            IStarshipCommandSingleton singleton,
            IStarshipCommandSingletonInstance singletonInstance)
        {
            LaunchTorpedoesTransient = transient;
            LaunchTorpedoesScoped = scoped;
            LaunchTorpedoesSingleton = singleton;
            LaunchTorpedoesSingletonInstance = singletonInstance;
           
        }
    }
}