using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaTrivia
{
    public partial class AnswersForm : Form
    {
        int i = 0;
        public AnswersForm() //Form that gets the right answers and present them to the user.
        {
            InitializeComponent(); 
            lblReQuestion.Text = (i + 1) + ". " + Gaming.wrongArr[i].Question;
            lblAnswer.Text = Gaming.wrongArr[i].CorrectAnswer; 
            if (Gaming.wrongArr.Count == 0)
            {
                MessageBox.Show("Wow, You had no wrong answers! Click OK to go back.");
                new NewMenu().Close();
            }
        }

        private void btnNextQ_Click(object sender, EventArgs e)
        {
            if(i < Gaming.wrongArr.Count - 1)
            {
                i++;
                lblReQuestion.Text = (i + 1) + ". " + Gaming.wrongArr[i].Question;
                lblAnswer.Text = "" + Gaming.wrongArr[i].CorrectAnswer;
                btnBackQ.Enabled = true;
            }
            else btnNextQ.Enabled = false;
        }

        private void btnBackQ_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                lblReQuestion.Text = (i + 1) + ". " + Gaming.wrongArr[i].Question;
                lblAnswer.Text = "" + Gaming.wrongArr[i].CorrectAnswer;
                btnNextQ.Enabled = true;
            }
            else btnBackQ.Enabled = false;
        }

        private void btnBackto_Click(object sender, EventArgs e)
        {
            new NewMenu().Show();
            this.Close();
        }
    }
}
