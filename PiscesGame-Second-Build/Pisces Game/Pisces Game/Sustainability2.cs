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
    public partial class Sustainability2 : Form
    {
        public static int PlayerAnswer;
        public Sustainability2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Answer.Value < 2)
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
            Round3 summary2 = new Round3();
            summary2.Visible = true;
            this.Hide();
        }
    }
}
