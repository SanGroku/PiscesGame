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
    public partial class Round6Summary : Form
    {
        public int AriesFish = 11;
        public int TaurusFish = 12;
        public int GeminiFish = 12;
        public int CancerFish = 8;
        public int LeoFish = 10;
        public int VirgoFish = 7;
        public int LibraFish = 9;
        public int ScorpioFish = 8;
        public int SagittariusFish = 10;
        public int CapricornFish = 6;
        public int AquariusFish = 12;
        public int PiscesFish = 11;

        public int TotalCompFish;

        public Round6Summary()
        {
            InitializeComponent();
            DisplayFish();
        }












   

        public void DeterminePlayerSign()
        {
            //Figures out which sign the player is
            if (Instructions.playerZodiacSign == "Aries")
            {
                AriesFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Taurus")
            {
                TaurusFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Gemini")
            {
                GeminiFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Cancer")
            {
                CancerFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Leo")
            {
                LeoFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Virgo")
            {
                VirgoFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Libra")
            {
                LibraFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Scorpio")
            {
                ScorpioFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Sagittarius")
            {

                SagittariusFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Capricorn")
            {
                CapricornFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Aquarius")
            {
                AquariusFish = Round2.playerFishCaught;
            }
            if (Instructions.playerZodiacSign == "Pisces")
            {
                PiscesFish = Round2.playerFishCaught;
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
            Round1Summary.totalFishInLake -= TotalCompFish;

            //Gets the total
            Round1Summary.totalFishInLake += (Convert.ToInt32(0.3) * Round1Summary.totalFishInLake);
            TotalFishLbl.Text = Convert.ToString(Round1Summary.totalFishInLake);
        }






        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            Round7 summary2 = new Round7();
            summary2.Visible = true;
            this.Hide();
        }
    }
}
