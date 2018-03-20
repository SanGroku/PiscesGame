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
    public partial class Round2Summary : Form
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

        public Round2Summary()
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
            Round3 summary2 = new Round3();
            summary2.Visible = true;
            this.Hide();
        }

        private void CanFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void TaurusLbl_Click(object sender, EventArgs e)
        {

        }

        private void TaurusFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void GemFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void AriesLbl_Click(object sender, EventArgs e)
        {

        }

        private void AriesFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void GeminiLbl_Click(object sender, EventArgs e)
        {

        }

        private void FishTakenLbl_Click(object sender, EventArgs e)
        {

        }

        private void CancerLbl_Click(object sender, EventArgs e)
        {

        }

        private void LeoLbl_Click(object sender, EventArgs e)
        {

        }

        private void LeoFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void VirFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void VirgoLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TotalFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PiscesLbl_Click(object sender, EventArgs e)
        {

        }

        private void PiscFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void AquaFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void CapFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void SagFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void ScorFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void LibFishLbl_Click(object sender, EventArgs e)
        {

        }

        private void LibraLbl_Click(object sender, EventArgs e)
        {

        }

        private void ScorpioLbl_Click(object sender, EventArgs e)
        {

        }

        private void SagLbl_Click(object sender, EventArgs e)
        {

        }

        private void CapLbl_Click(object sender, EventArgs e)
        {

        }

        private void AquaLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
