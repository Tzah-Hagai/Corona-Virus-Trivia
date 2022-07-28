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
    public partial class AddInfo : Form
    {
        public AddInfo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Update().Show();
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new Info().Show();
            this.Close();
        }

        private void btnInfoIma_Click(object sender, EventArgs e)
        {
            new InfoImage().Show();
            this.Close();
        }

    }
}
