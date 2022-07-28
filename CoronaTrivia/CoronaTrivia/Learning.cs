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
    public partial class Learning : Form
    {
        List<Data> dataArr = new List<Data>();
        int i = 0;
        public Learning()
        {
            InitializeComponent();
            try
            {
                string[] dataLines = File.ReadAllLines("DATA/infoData.txt");
                for (int i = 0; i < dataLines.Length; i++)
                {
                    string[] datastr = dataLines[i].Split(';'); //Stop reading the text when encounter ";".
                    if (datastr.Length == 3) dataArr.Add(new Data(int.Parse(datastr[0]), datastr[1], datastr[2])); //For true or false question
                    if (datastr.Length == 4) dataArr.Add(new Data(int.Parse(datastr[0]), datastr[1], datastr[2], datastr[3]));
                }
                lblTopic.Text = (i + 1) + ". " + dataArr[i].DataTopic;
                lblContent.Text = "" + dataArr[i].DataContent;
                if (dataArr[i].DataImage != null) picBox.ImageLocation = ("DIMAGES/" + dataArr[i].DataImage); //Adding image if the element has one
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (FileLoadException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i < dataArr.Count - 1)
            {
                i++;                                                     //Puts a new info every time 'Next' is clicked.
                lblTopic.Text = (i + 1) + ". " + dataArr[i].DataTopic;
                lblContent.Text = "" + dataArr[i].DataContent;
                btnBack.Enabled = true;
                picBox.Visible = false;
                if (dataArr[i].DataImage != null)
                {
                    picBox.ImageLocation = ("DIMAGES/" + dataArr[i].DataImage);
                    picBox.Visible = true;
                }
            }
            else btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                lblTopic.Text = (i + 1) + ". " + dataArr[i].DataTopic; //Goes to the previous info when 'Back' is clicked.
                lblContent.Text = "" + dataArr[i].DataContent;
                btnNext.Enabled = true;
                picBox.Visible = false;
                if (dataArr[i].DataImage != null)
                {
                    picBox.ImageLocation = ("DIMAGES/" + dataArr[i].DataImage);
                    picBox.Visible = true;
                }
            }
            else btnBack.Enabled = false;
        }

        private void btnBackto_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Close();
        }
    }
}
