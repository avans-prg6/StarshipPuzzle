using System;
using StarshipCommands.Interfaces;
namespace StarshipCommands.Classes
{
    public class StarshipCommand : IStarshipCommandTransient, IStarshipCommandScoped, IStarshipCommandSingleton, IStarshipCommandSingletonInstance
    {
        private static int commandNumber = 0;

        public StarshipCommand() : this(System.Threading.Interlocked.Increment(ref commandNumber))
        {

        }

        public StarshipCommand(int commandId)
        {
            CommandId = commandId;
        }

        public int CommandId { get; }

        public string Name { get; set; }

        public string Response { get; set; }
    }
}