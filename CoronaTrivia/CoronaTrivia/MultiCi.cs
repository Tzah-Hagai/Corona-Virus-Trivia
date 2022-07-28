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
    public partial class MultiCi : Form //Creates a multiple answer question with pictures and adds it to the gameData txt file.
    {
        OpenFileDialog trueImage = new OpenFileDialog();
        OpenFileDialog falseImage1 = new OpenFileDialog();
        OpenFileDialog falseImage2 = new OpenFileDialog();
        public MultiCi()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] qLines = File.ReadAllLines("DATA/gameData.txt");
                Game newQ = new Game();
                newQ.QNumber = qLines.Length + 1;
                newQ.QType = 3;
                newQ.Question = txtQuestion.Text;
                string tPicAddr = trueImage.FileName;
                string tPicName = Path.GetFileName(tPicAddr);
                newQ.CorrectAnswer = tPicName;
                string fPicAddr1 = falseImage1.FileName;
                string fPicName1 = Path.GetFileName(fPicAddr1);
                newQ.IncorrectAnswerOne = fPicName1;
                string fPicAddr2 = falseImage2.FileName;
                string fPicName2 = Path.GetFileName(fPicAddr2);
                newQ.IncorrectAnswerTwo = fPicName2;
                if (txtQuestion.Text != "" && pcbTrue.Image != null && 
                    pcbFalse1.Image != null && pcbFalse2!= null)
                { 
                    string insertQ = "\n" + newQ.QNumber + ";" + newQ.QType + ";" + newQ.Question + ";"
                           + newQ.CorrectAnswer + ";" + newQ.IncorrectAnswerOne + ";" + newQ.IncorrectAnswerTwo;
                    StreamWriter sw = new StreamWriter("DATA/gameData.txt", true);
                    sw.Write(insertQ);
                    sw.Close();
                    File.Copy(tPicAddr, "QIMAGES/" + tPicName);
                    File.Copy(fPicAddr1, "QIMAGES/" + fPicName1);
                    File.Copy(fPicAddr2, "QIMAGES/" + fPicName2);
                    new Menu().Show();
                    this.Close();
                }
                else if (txtQuestion.Text == "")
                {
                    MessageBox.Show("Please enter a question!");
                }
                else if (pcbTrue.Image == null)
                {
                    MessageBox.Show("Please add a True Image!");
                }
                else if (pcbFalse1.Image == null)
                {
                    MessageBox.Show("Please add your first False Image!");
                }
                else if (pcbFalse2.Image == null)
                {
                    MessageBox.Show("Please add your second False Image!");
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

        private void btnAddT_Click(object sender, EventArgs e)
        {
            trueImage.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (trueImage.ShowDialog() == DialogResult.OK)
            {
                pcbTrue.Image = Image.FromFile(trueImage.FileName);
            }
        }

        private void btnFAdd1_Click(object sender, EventArgs e)
        {
            falseImage1.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (falseImage1.ShowDialog() == DialogResult.OK)
            {
                pcbFalse1.Image = Image.FromFile(falseImage1.FileName);
            }
        }

        private void btnFAdd2_Click(object sender, EventArgs e)
        {
            falseImage2.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (falseImage2.ShowDialog() == DialogResult.OK)
            {
                pcbFalse2.Image = Image.FromFile(falseImage2.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AddQuestion().Show();
            this.Close();
        }
    }
}
