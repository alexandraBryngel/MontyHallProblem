using MontyHallProblem.Models;
using MontyHallProblem.Sevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MontyHallProblem.Controllers
{
    public class GameController : ApiController
    {
        [HttpPost]
        public  PlayedGames SimulateGames([FromBody] GameSimulation gameSimulation)
        {
            var service = new GameService();

            return service.SimulateGames(gameSimulation.NumberOfGames, gameSimulation.ChangeDoor);
        }
    }
}
