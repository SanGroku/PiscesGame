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
    public partial class Round6 : Form
    {
        public static int playerFishCaught; //How many fish the player catches this round
        public int playerFishEaten;
        public static int privatePlayerPond;

        public Round6()
        {
            InitializeComponent();
        }

        

        private void catchfishBtn_Click(object sender, EventArgs e)
        {
            playerFishCaught = Convert.ToInt32(catchFishBox.Value);   //Takes the value from the box
            fishCaughtLbl.Visible = true;   //Show player how many fish they caught

            //Check to see if they took a substantial amount of fish
            if (playerFishCaught < 4)
            {
                fishCaughtLbl.Text = "You would not survive this round. Don't be shy! Catch some more!";
            }
            else if (playerFishCaught > 12)
            {
                fishCaughtLbl.Text = "that's too many fish! Lighten the load a bit!";
            }
            else
            {
                catchfishBtn.Visible = false;
                fishCaughtLbl.Text = "Good haul!";

                //Show the next prompt
                eatPromptLbl.Visible = true;
                eatFishBox.Visible = true;
                eatFishBtn.Visible = true;
            }
        }

        private void eatFishBtn_Click(object sender, EventArgs e)
        {
            playerFishEaten = Convert.ToInt32(eatFishBox.Value);    //Stores value in box
            eatFishLbl.Visible = true;

            //Show the player what they did
            if (playerFishEaten < 4)
            {
                eatFishLbl.Text = "That is not enough to survive";
            }
            else if (playerFishEaten > 12)
            {
                eatFishLbl.Text = "Don't be silly! You don't have that many fish!";
            }
            else
            {
                eatFishLbl.Text = "You ate enough to survive!";
                eatFishBtn.Visible = false;
            }

            //See how much fish the player has total now
            //playerFishCaught -= playerFishEaten;

            //Show the last part
            investPromptLbl.Visible = true;
            yesBtn.Visible = true;
            noBtn.Visible = true;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            noBtn.Visible = false;  //No going back now

            //See if they can even invest
            if (playerFishCaught <= 0)
            {
                investFishLbl.Visible = true;
                investFishLbl.Text = "You do not have enough fish to invest";
            }
            else
            {
                investBox.Visible = true;
                investBtn.Visible = true;
            }
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            yesBtn.Visible = false;

            investFishLbl.Visible = true;
            investFishLbl.Text = "That is a-okay!"; //Be nice to the player (' u ')
        }

        private void investBtn_Click(object sender, EventArgs e)
        {
            investFishLbl.Visible = true;

            investFishLbl.Text = "You invested " + Convert.ToString(investBox.Value) + " fish into a private pond!";

            //Here's the pond value. Can be reused too! :)
            privatePlayerPond = Convert.ToInt32(investBox.Value);
        }

        private void round1EndBtn_Click(object sender, EventArgs e)
        {
            Sustainability2 summary2 = new Sustainability2();
            summary2.Visible = true;
            this.Hide();
        } 
    }
}
