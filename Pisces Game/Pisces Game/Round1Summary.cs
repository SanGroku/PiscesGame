using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisces_Game
{
    public partial class Round1Summary : Form
    {
        public int totalFishInLake = 403;    //How many fish are in communal lake

        //Create values for each sign
        public int AriesFish = 8;
        public int TaurusFish = 10;
        public int GeminiFish = 12;
        public int CancerFish;
        public int LeoFish;
        public int VirgoFish;
        public int LibraFish;
        public int ScorpioFish;
        public int SagittariusFish;
        public int CapricornFish;
        public int AquariusFish;
        public int PiscesFish;

        public int TotalCompFish;

        public Round1Summary()
        {
            InitializeComponent();
            DisplayFish();
        }

        //Insert random somewhere in here
        public void RandomFishCPU()
        {
            int[] pick;
            pick = new int[12];

            pick[0] = 1;
            pick[1] = 2;
            pick[2] = 3;
            pick[3] = 4;
            pick[4] = 5;
            pick[5] = 6;
            pick[6] = 7;
            pick[7] = 8;
            pick[8] = 9;
            pick[9] = 10;
            pick[10] = 11;
            pick[11] = 12;

            Random pickFish = new Random();
            int nextFish = pickFish.Next(pick.Length);
        }

        public void DeterminePlayerSign()
        {
            //Figures out which sign the player is
            if (Instructions.playerZodiacSign == "Aries")
            {
                AriesFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Taurus")
            {
                TaurusFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Gemini")
            {
                GeminiFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Cancer")
            {
                CancerFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Leo")
            {
                LeoFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Virgo")
            {
                VirgoFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Libra")
            {
                LibraFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Scorpio")
            {
                ScorpioFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Sagittarius")
            {
                
                SagittariusFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Capricorn")
            {
                CapricornFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Aquarius")
            {
                AquariusFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Pisces")
            {
                PiscesFish = Round1.playerFishTaken;
            }
        }

        public void DisplayFish()
        {
            //Figure out player sign
            DeterminePlayerSign();

            //Display everyones fish
            AriesFishLbl.Text = Convert.ToString(AriesFish);
            TaurusFishLbl.Text = Convert.ToString(TaurusFish);
            GemFishLbl.Text = Convert.ToString(GeminiFish);
            CanFishLbl.Text = Convert.ToString(CancerFish);
            LeoFishLbl.Text = Convert.ToString(LeoFish);
            VirFishLbl.Text = Convert.ToString(VirgoFish);
            LibFishLbl.Text = Convert.ToString(LibraFish);
            ScorFishLbl.Text = Convert.ToString(ScorpioFish);
            SagFishLbl.Text = Convert.ToString(SagittariusFish);
            CapFishLbl.Text = Convert.ToString(CapricornFish);
            AquaFishLbl.Text = Convert.ToString(AquariusFish);
            PiscFishLbl.Text = Convert.ToString(PiscesFish);

            TotalFishInPond();
        }

        public void TotalFishInPond()
        {
            //Add all the comp fish
            TotalCompFish = AriesFish + TaurusFish + GeminiFish + CancerFish + LeoFish + VirgoFish + LibraFish + ScorpioFish + SagittariusFish + CapricornFish + AquariusFish + PiscesFish;

            //Subtracts fish from total
            totalFishInLake -= TotalCompFish;

            //Gets the total
            totalFishInLake += (Convert.ToInt32(0.3) * totalFishInLake);
            TotalFishLbl.Text = Convert.ToString(totalFishInLake);
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
