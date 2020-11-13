using System;

namespace StarshipCommands.Interfaces
{
    public interface IStarshipCommand
    {
        string Name { get; set; }
        int CommandId { get; }
        string Response { get; set; }
    }

    public interface IStarshipCommandTransient : IStarshipCommand
    {
    }

    public interface IStarshipCommandScoped : IStarshipCommand
    {
    }

    public interface IStarshipCommandSingleton : IStarshipCommand
    {
    }

    public interface IStarshipCommandSingletonInstance : IStarshipCommand
    {
    }
}