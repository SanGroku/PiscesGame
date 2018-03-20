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
    public partial class Sustainability6 : Form
    {
        public static int PlayerAnswer;
        public Sustainability6()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Round6Summary summary = new Round6Summary();
            summary.Visible = true;
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
    }


}
