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
        //Create values for each sign
        public int AriesFish;
        public int TaurusFish;
        public int GeminiFish;
        public int CancerFish;
        public int LeoFish;
        public int VirgoFish;
        public int LibraFish;
        public int ScorpioFish;
        public int SagittariusFish;
        public int CapricornFish;
        public int AquariusFish;
        public int PiscesFish;

        public Round1Summary()
        {
            InitializeComponent();
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
                Round1.playerFishTaken = AriesFish;
            }
            if (Instructions.playerZodiacSign == "Taurus")
            {
                Round1.playerFishTaken = TaurusFish;
            }
            if (Instructions.playerZodiacSign == "Gemini")
            {
                Round1.playerFishTaken = GeminiFish;
            }
            if (Instructions.playerZodiacSign == "Cancer")
            {
                Round1.playerFishTaken = CancerFish;
            }
            if (Instructions.playerZodiacSign == "Leo")
            {
                Round1.playerFishTaken = LeoFish;
            }
            if (Instructions.playerZodiacSign == "Virgo")
            {
                Round1.playerFishTaken = VirgoFish;
            }
            if (Instructions.playerZodiacSign == "Libra")
            {
                Round1.playerFishTaken = LibraFish;
            }
            if (Instructions.playerZodiacSign == "Scorpio")
            {
                Round1.playerFishTaken = ScorpioFish;
            }
            if (Instructions.playerZodiacSign == "Sagittarius")
            {
                Round1.playerFishTaken = SagittariusFish;
            }
            if (Instructions.playerZodiacSign == "Capricorn")
            {
                CapricornFish = Round1.playerFishTaken;
            }
            if (Instructions.playerZodiacSign == "Aquarius")
            {
                Round1.playerFishTaken = AquariusFish;
            }
            if (Instructions.playerZodiacSign == "Pisces")
            {
                Round1.playerFishTaken = PiscesFish;
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

        }

        public void TotalFishInPond()
        {
            Round1.totalFishInLake = Round1.totalFishInLake - (AriesFish + TaurusFish + GeminiFish + CancerFish + LeoFish + VirgoFish + LibraFish + ScorpioFish + SagittariusFish + CapricornFish + AquariusFish + PiscesFish);
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
