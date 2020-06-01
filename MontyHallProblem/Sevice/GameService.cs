using MontyHallProblem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MontyHallProblem.Sevice
{
    public class GameService
    {
        public Game SimulateGame(Random rand, bool changeDoor)
        {
            Game game = new Game();

            //Bestäm dörr med pengar            
            var moneyDoor = rand.Next(0, 3);
            game.Doors[moneyDoor].HasMoney = true;

            //Välj dörr
            int chooseDoor = rand.Next(0, 3);

            //Monty öppnar dörr
            int montyDoor = 0;

            if(chooseDoor == 0)
            {
                if(game.Doors[1].HasMoney == true)
                {
                    montyDoor = 2;
                }
                else
                {
                    montyDoor = 1;
                }
            }
            
            if(chooseDoor == 1)
            {
                if(game.Doors[2].HasMoney == true)
                {
                    montyDoor = 0;
                }
                else
                {
                    montyDoor = 2;
                }
            }
            if(chooseDoor == 2)
            {
                if(game.Doors[1].HasMoney == true)
                {
                    montyDoor = 0;
                }
                else
                {
                    montyDoor = 1;
                }
            }


            //Byt dörr eller inte
            if(changeDoor == true)
            {
                chooseDoor = 3 - montyDoor - chooseDoor;
            }

            //Öppna dörren
            if(game.Doors[chooseDoor].HasMoney == true)
            {
                game.win = true;
            }

            return game; 
        }

        public PlayedGames SimulateGames(int numberOfGames, bool changeDoor)
        {
            var played = new PlayedGames();
            var rand = new Random();

            for (int i = 0; i < numberOfGames; i++)
            {
                played.Games.Add(SimulateGame(rand, changeDoor));
            }

            played.NumberOfWins = played.Games.Where(g => g.win == true).Count();

            return played;
        }
    }
}