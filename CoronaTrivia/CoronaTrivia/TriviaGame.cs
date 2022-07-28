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
    public partial class TriviaGame : Form
    {
        public static string userName = "";
        public TriviaGame()
        {
            InitializeComponent();
            picbox.ImageLocation = ("DIMAGES/Corona.jpg"); //Puts the image from the folder in the pic box
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                userName = txtName.Text;
                new Menu().Show();
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            }
            else MessageBox.Show("Please enter your full name!");
        }
    }
}
