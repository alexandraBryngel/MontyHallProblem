using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MontyHallProblem.Models
{
    public class Game
    {
        public Door FirstDoor { get; set; }

        public Door SecondDoor { get; set; }

        public Door ThirdDoor { get; set; }

        public List<Door> Doors { get; set; }

        public Game()
        {
            FirstDoor = new Door();
            SecondDoor = new Door();
            ThirdDoor = new Door();

            Doors.Add(FirstDoor);
            Doors.Add(SecondDoor);
            Doors.Add(ThirdDoor);

            var rand = new Random();

            Doors[rand.Next(1, Doors.Count)].HasMoney = true;
        }
    }
}