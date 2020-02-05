using System;
using System.Collections.Generic;

namespace Ludo
{
    class Program
    {
        private static List<Player> Players = new List<Player>();
        private Player Starter;

        static void Main(string[] args)
        {
            try
            {
                Player playerRed = new Player();
                Players.Add(playerRed);
                Player playerYellow = new Player();
                Players.Add(playerYellow);

                Player playerR = new Player();
                Players.Add(playerR);
                Player playerY = new Player();
                Players.Add(playerY);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Player Starter = DetermineStarter(Players);
            Console.WriteLine("*******************");
            Console.WriteLine("**" + Starter.color + " starts! **");
            Console.WriteLine("*******************");

            int startIndex = Players.FindIndex(x => x == Starter);
            Console.WriteLine(startIndex);

            StartGame(Starter);
        }
        static int c = 0;

        static Player DetermineStarter( List<Player> playerList)
        { 
            // Sort the Players list by startValue in descending order
            playerList.Sort((p1, p2) => {
                return p2.StartValue - p1.StartValue;
            });

            if (playerList[0].StartValue == playerList[1].StartValue)
            {
                List<Player> rePlayers = new List<Player>()
                {
                    playerList[0],
                    playerList[1]
                };
                if (playerList.Count > 2)
                {
                    if (playerList[1].StartValue == playerList[2].StartValue)
                    {
                        rePlayers.Add(playerList[2]);

                        if (playerList.Count > 3)
                        {
                            if (playerList[2].StartValue == playerList[3].StartValue)
                            {
                                rePlayers.Add(playerList[3]);
                            }
                        }
                    }
                    
                }
                Dice d = new Dice();
                foreach (Player p in rePlayers)
                {
                    p.StartValue = d.Roll();
                }

                return DetermineStarter(rePlayers);
            }
            return playerList[0];
        }

        static void StartGame(Player starter)
        {
            Dice die = new Dice();
            for (int i = 0, res = 0; i < 3 && res != 6; i++)
            {
                res = die.Roll();
                Console.WriteLine($"{starter.color} got a {res}");
            }
            

        }
    }
}
