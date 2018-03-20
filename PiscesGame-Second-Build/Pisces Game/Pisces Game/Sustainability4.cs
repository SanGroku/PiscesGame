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
    public partial class Sustainability4 : Form
    {
        public static int PlayerAnswer;
        public Sustainability4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Round4Summary summary2 = new Round4Summary();
            summary2.Visible = true;
            this.Hide();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Answer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Correct_Click(object sender, EventArgs e)
        {

        }

        private void Incorrect_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
