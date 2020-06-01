using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MontyHallProblem.Models
{
    public class Game
    {
        public List<Door> Doors { get; set; }
        public bool win { get; set; }

        public Game()
        {
            Doors = new List<Door>();

            Doors.Add(new Door());
            Doors.Add(new Door());
            Doors.Add(new Door());

            
        }
    }
}