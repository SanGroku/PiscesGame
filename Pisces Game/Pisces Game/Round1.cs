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
    public partial class Round1 : Form
    {
        public static int totalPlayers = 12;        //How many people are playing
        public static int playerFishTaken;
        public static int totalFishInLake = 403;    //How many fish are in communal lake

        public Round1()
        {
            InitializeComponent();

            showZodiacLbl.Visible = true;
            showZodiacLbl.Text = Instructions.playerZodiacSign;
        }

        private void eatFishBtn_Click(object sender, EventArgs e)
        {
            if (eatFishBox.Value < 4)
            {
                eatFishLbl.Visible = true;
                eatFishLbl.Text = "You will not survive if you eat that many.";
            }
            else if (eatFishBox.Value > 4)
            {
                eatFishBox.Value = playerFishTaken;
                eatFishLbl.Visible = true;
                eatFishLbl.Text = playerFishTaken.ToString();
                eatFishBtn.Visible = false;
                
            }
            else if (eatFishBox.Value > 12)
            {
                eatFishLbl.Visible = true;
                eatFishLbl.Text = "That's way too many fish...";
            }
            else
            {
                eatFishLbl.Visible = true;
                eatFishLbl.Text = "You ate enough to survive.";
                eatFishBtn.Visible = false;
                eatFishBox.Value = playerFishTaken;
            }
        }

        public void calculatePlayerFishTaken()
        {
            totalFishInLake = totalFishInLake - playerFishTaken;
        }

        private void round1EndBtn_Click(object sender, EventArgs e)
        {
            Round1Summary summary = new Round1Summary();
            summary.Visible = true;
            this.Hide();
        }
    }
}
