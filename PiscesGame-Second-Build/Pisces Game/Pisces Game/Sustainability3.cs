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
    public partial class Sustainability3 : Form
    {
        public static int PlayerAnswer;
        public Sustainability3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Answer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Incorrect_Click(object sender, EventArgs e)
        {

        }

        private void Correct_Click(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Round3Summary summary2 = new Round3Summary();
            summary2.Visible = true;
            this.Hide();
        }
    }
}
