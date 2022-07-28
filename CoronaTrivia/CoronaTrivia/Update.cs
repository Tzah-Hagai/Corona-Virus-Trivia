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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
           new AddQuestion().Show();
           this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new AddInfo().Show();
            this.Close();
        }

        private void btnBackto_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Close();
        }
    }
}
