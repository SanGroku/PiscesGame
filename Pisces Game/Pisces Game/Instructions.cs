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
    public partial class Instructions : Form
    {
        public static string playerZodiacSign;     //Stores the sign of the player

        public Instructions()
        {
            InitializeComponent();
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            ZodiacLbl.Visible = true;       //Make the label visible
            ZodiacLbl.Text = "Your zodiac sign is " + ZodiacBox.Text + "!";     //Displays whatever is in the combo box
            playerZodiacSign = ZodiacBox.Text;  //stores whatever the user picks

            ConfirmBtn.Visible = false;     //Make it so that they cannot pick again.
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            Round1 startRound = new Round1();
            startRound.Visible = true;
            this.Hide();
        }

    }
}
