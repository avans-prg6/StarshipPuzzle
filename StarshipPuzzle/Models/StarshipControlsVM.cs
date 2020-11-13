using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipPuzzles.Models
{
    public class StarshipControlsVM
    {
        public List<StarshipCommandVM> Commands { get; set; }

        public void AddCommand(StarshipCommandVM command)
        {
            if (Commands == null)
                Commands = new List<StarshipCommandVM>();
            Commands.Add(command);
        }

    }
}
