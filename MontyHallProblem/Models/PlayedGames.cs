using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MontyHallProblem.Models
{
    public class PlayedGames
    {

        public int NumberOfWins { get; set; }
        public List<Game> Games { get; set; }

        public PlayedGames()
        {
            Games = new List<Game>();
        }

        


    }
}