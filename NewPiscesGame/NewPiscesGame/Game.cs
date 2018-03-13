using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPiscesGame
{
    class Game
    {
        public double totalFishIinLake = 403;      //Fish in the lake
        public double playerFishTaken;             //How many fish are taken from the lake
        public double compFishTaken;

        public void ComputerFishTake()
        {
            int[] choices;
            choices = new int[12];

            choices[0] = 1;
            choices[1] = 2;
            choices[2] = 3;
            choices[3] = 4;
            choices[4] = 5;
            choices[5] = 6;
            choices[6] = 7;
            choices[7] = 8;
            choices[8] = 9;
            choices[9] = 10;
            choices[10] = 11;
            choices[11] = 12;

            Random Descision = new Random();
            compFishTaken = Descision.Next(choices.Length);
            Console.WriteLine(compFishTaken);
        }

        public void Instructions()
        { }

        //Player cannot inevest fish this round
        public void PlayerTurn()
        {
            Console.WriteLine("How many fish do you wish to eat?");
            playerFishTaken = Convert.ToDouble(Console.ReadLine());

            if (playerFishTaken == 4)
            {
                Console.WriteLine("You ate enough fish to survive.");
            }
            if (playerFishTaken < 4)
            {
                Console.WriteLine("You did not eat enough to survive");
            }
        }

        public void MainGame()
        {

        }
    }
}
