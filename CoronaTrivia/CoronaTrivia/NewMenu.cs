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
    public partial class NewMenu : Form
    {
        public NewMenu()
        {
            InitializeComponent();
        }
    
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (Gaming.wrongArr.Count == 0)
            {
                MessageBox.Show("Wow, You had no wrong answers!");
                btnCheck.Enabled = false;
            }
            else
            {
                new AnswersForm().Show();
                this.Close();

            } 
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            Gaming.flag = 1;
            new Gaming().Show();
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Gaming.flag = 0;
            new Gaming().Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Learning().Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new Update().Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
