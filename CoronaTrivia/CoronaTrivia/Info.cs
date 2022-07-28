using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace CoronaTrivia
{
    public partial class Info : Form //Creates a new Info text without picture and adds it to the infoData txt file.
    {
        public Info()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dLines = File.ReadAllLines("DATA/infoData.txt");
                Data newInfo = new Data();
                newInfo.DataNumber = dLines.Length + 1;
                newInfo.DataTopic = txtHead.Text;
                newInfo.DataContent = txtBody.Text;
                if (txtHead.Text != "" && txtBody.Text != "")
                {
                    string insertData = "\n" + newInfo.DataNumber + ";" + newInfo.DataTopic + ";" + newInfo.DataContent;      
                    StreamWriter sw = new StreamWriter("DATA/infoData.txt", true);
                    sw.Write(insertData);
                    sw.Close();
                    new Menu().Show();
                    this.Close();
                }
                else if (txtHead.Text == "")
                {
                    MessageBox.Show("Please add an headline!");
                }
                else if (txtBody.Text == "")
                {
                    MessageBox.Show("Please add some content!");
                }
            }
            catch (FileNotFoundException e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch (FileLoadException e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch (IOException e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AddInfo().Show();
            this.Close();
        }
    }
}
