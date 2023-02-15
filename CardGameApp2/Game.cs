using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp2
{
    public class Game
    {
        public Player player = new Player();
        public ApplesOranges apples = new ApplesOranges();
        public bool GameOver = false;
        //runs the start up
        public void StartUp()
        {
            Console.Clear();
            Console.WriteLine("What game would you like to play?");
            Console.WriteLine("1. Apples or Oranges");
            Console.WriteLine("2. Quit");
            switch (Console.ReadLine())
            {
                case "1":
                    apples.StartingUp(player);
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("input not valid");
                    Console.ReadLine();
                    StartUp();
                    break;

            }
        }
    }
}
