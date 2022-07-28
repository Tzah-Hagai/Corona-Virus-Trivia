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
    public partial class Menu : Form 
    {
        public Menu() //Only a form with buttons
        {
            InitializeComponent();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            new Learning().Show();
            this.Close();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            new Gaming().Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new Update().Show();
            this.Close();
        }
    }
}
