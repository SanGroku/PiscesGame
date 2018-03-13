using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPiscesGame
{
    enum PlayerState { Alive, Dead }

    class Game
    {
        private PlayerState state;
        public double totalFishIinLake = 403;      //Fish in the lake
        public double playerFishTaken;             //How many fish are taken from the lake
        public double compFishTaken;

        string playerZodiacSign;

        public double AriesFish;
        public double TaurusFish;
        public double GeminiFish;
        public double CancerFish;
        public double LeoFish;
        public double VirgoFish;
        public double LibraFish;
        public double ScorpioFish;
        public double SagittariusFish;
        public double CapricornFish;
        public double AquariusFish;
        public double PiscesFish;

        public void ComputerFishTake()
        {
            int[] choices;
            choices = new int[12];

            //choices[0] = 1;
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
        }

        public void Instructions()
        { }

        public void PlayerZodiac()
        {
            Console.WriteLine("What is your zodiac sign?");
            playerZodiacSign = Console.ReadLine();

            if (playerZodiacSign == "Aries")
            {
                playerFishTaken = AriesFish;
            }
            if (playerZodiacSign == "Taurus")
            {
                playerFishTaken = TaurusFish;
            }
            if (playerZodiacSign == "Gemini")
            {
                playerFishTaken = GeminiFish;
            }
            if (playerZodiacSign == "Cancer")
            {
                playerFishTaken = CancerFish;
            }
            if (playerZodiacSign == "Leo")
            {
                playerFishTaken = LeoFish;
            }
            if (playerZodiacSign == "Virgo")
            {
                playerFishTaken = VirgoFish;
            }
            if (playerZodiacSign == "Libra")
            {
                playerFishTaken = LibraFish;
            }
            if (playerZodiacSign == "Scorpio")
            {
                playerFishTaken = ScorpioFish;
            }
            if (playerZodiacSign == "Sagittarius")
            {
                playerFishTaken = SagittariusFish;
            }
            if (playerZodiacSign == "Capricorn")
            {
                playerFishTaken = CapricornFish;
            }
            if (playerZodiacSign == "Aquarius")
            {
                playerFishTaken = AquariusFish;
            }
            if (playerZodiacSign == "Pisces")
            {
                playerFishTaken = PiscesFish;
            }

        }

        //Player cannot inevest fish this round
        public void PlayerTurn()
        {
            Console.WriteLine("How many fish do you wish to eat?");
            playerFishTaken = Convert.ToDouble(Console.ReadLine());

            if (playerFishTaken == 4)
            {
                Console.WriteLine("You ate enough fish to survive.");
                state = PlayerState.Alive;
            }
            if (playerFishTaken < 4)
            {
                Console.WriteLine("You did not eat enough to survive");
                state = PlayerState.Dead;
            }
            if (playerFishTaken > 12)
            {
                Console.WriteLine("You cannot take more than 12 fish at a time");
                state = PlayerState.Alive;
            }

            Console.WriteLine("[Press Enter To Continue]");
            Console.ReadKey();
            Console.Clear();
        }

        public void ComputerTurn()
        {
            //First Pick
            ComputerFishTake(); 
            Console.WriteLine("Aries: " + compFishTaken);
            AriesFish = compFishTaken;

            //Second
            Console.WriteLine("Taurus: " + compFishTaken);
            TaurusFish = compFishTaken;

            //Third
            Console.WriteLine("Gemini: " + compFishTaken);
            GeminiFish = compFishTaken;

            //Fourth
            Console.WriteLine("Cancer: " + compFishTaken);
            CancerFish = compFishTaken;

            Console.WriteLine("Leo: " + compFishTaken);
            LeoFish = compFishTaken;

            Console.WriteLine("Virgo: " + compFishTaken);
            VirgoFish = compFishTaken;

            Console.WriteLine("Libra: " + compFishTaken);
            LibraFish = compFishTaken;

            Console.WriteLine("Scorpio: " + compFishTaken);
            ScorpioFish = compFishTaken;

            Console.WriteLine("Sagittarius: " + compFishTaken);
            SagittariusFish = compFishTaken;

            Console.WriteLine("Capricorn: " + compFishTaken);
            CapricornFish = compFishTaken;

            Console.WriteLine("Aquarius: " + compFishTaken);
            AquariusFish = compFishTaken;

            Console.WriteLine("Pisces: " + compFishTaken);
            PiscesFish = compFishTaken;
        }

        public void Calculate()
        {
            totalFishIinLake = totalFishIinLake - (playerFishTaken + AriesFish + TaurusFish + GeminiFish + CancerFish + LeoFish + VirgoFish + LibraFish + ScorpioFish + SagittariusFish + CapricornFish + AquariusFish + PiscesFish);
        }

        public void MainGame()
        {
            for (int i = 0; i <= 8; i++)
            {
                switch (state)
                {
                    case PlayerState.Alive:
                        PlayerTurn();
                        ComputerTurn();
                        break;

                    case PlayerState.Dead:
                        i = 8;
                        Console.WriteLine("Game Over");
                        break;
                }
            }
        }
    }
}
