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
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void btnTorF_Click(object sender, EventArgs e)
        {
            new TorF().Show();
            this.Close();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            new MultiC().Show();
            this.Close();
        }

        private void btnTorFI_Click(object sender, EventArgs e)
        {
            new TorFi().Show();
            this.Close();
        }

        private void btnMI_Click(object sender, EventArgs e)
        {
            new MultiCi().Show();
            this.Close();
        }

        private void btnBackto_Click(object sender, EventArgs e)
        {
            new Update().Show();
            this.Close();
        }
    }
}
