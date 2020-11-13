using StarshipCommands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipPuzzles.Models
{
    public class StarshipCommandVM
    {
        public int CommandId { get; }
        public string Name { get; set; }
        public string Tip { get; set; }

        public StarshipCommandVM(IStarshipCommand command)
        {
            CommandId = command.CommandId;
            Name = $"{command.CommandId}. {command.Name}";
            Tip = command.Response;
        }
    }
}
