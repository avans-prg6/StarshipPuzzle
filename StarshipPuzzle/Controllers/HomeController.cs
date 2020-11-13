using Microsoft.AspNetCore.Mvc;
using StarshipCommands.Classes;
using StarshipCommands.Interfaces;
using StarshipCommands.Services;
using StarshipPuzzles.Models;

namespace StarshipPuzzles.Controllers
{
    public class HomeController : Controller
    {
        private readonly StarshipCommandService _torpedoService;
        private readonly IStarshipCommandTransient _firePhazors;
        private readonly IStarshipCommandScoped _raiseShields;
        private readonly IStarshipCommandSingleton _warpSpeed;
        private readonly IStarshipCommandSingletonInstance _teleport;

        public HomeController(StarshipCommandService commandService,
            IStarshipCommandTransient firePhazorsTransient,
            IStarshipCommandScoped raiseShieldsScoped,
            IStarshipCommandSingleton warpSpeedSingleton,
            IStarshipCommandSingletonInstance teleportSingletonInstance)
        {
            _torpedoService = commandService;
            _firePhazors = firePhazorsTransient;
            _raiseShields = raiseShieldsScoped;
            _warpSpeed = warpSpeedSingleton;
            _teleport = teleportSingletonInstance;
        }

        public IActionResult Index()
        {
            var result = new StarshipControlsVM();

            _firePhazors.Name = "Fire Phazors!";
            _firePhazors.Response = "Kazzang!";
            _raiseShields.Name = "Raise Shields!";
            _raiseShields.Response = "Zwoooiinngg!";
            _warpSpeed.Name = "Engage Warp!";
            _warpSpeed.Response = "Roger, make it so!";
            _teleport.Name = "Start transporters";
            _teleport.Response = "Beam me up Scotty!";

            result.AddCommand(new StarshipCommandVM(new StarshipCommand(1) { Name = "Ignition", Response = "Engine starts humming "  }));

            result.AddCommand(new StarshipCommandVM(_firePhazors));
            result.AddCommand(new StarshipCommandVM(_raiseShields));
            result.AddCommand(new StarshipCommandVM(_warpSpeed));
            result.AddCommand(new StarshipCommandVM(_teleport));
            result.AddCommand(new StarshipCommandVM(_torpedoService.LaunchTorpedoesScoped));
            return View(result);
        }

    }
}
