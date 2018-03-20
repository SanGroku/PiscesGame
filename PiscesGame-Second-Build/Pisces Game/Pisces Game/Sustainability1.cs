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
    public partial class Sustainability1 : Form
    {
        public static int PlayerAnswer;
        public Sustainability1()
        {
            InitializeComponent();
            Continue.Visible = false;

        }

        private void Answer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (Answer.Value > 3)
            {
                Correct.Visible = true;
                Continue.Visible = true;
            }

            else
            {
                Incorrect.Visible = true;

                Continue.Visible = false;

            }
            PlayerAnswer = Convert.ToInt32(Answer.Value);

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Round1Summary summary = new Round1Summary();
            summary.Visible = true;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Correct_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
