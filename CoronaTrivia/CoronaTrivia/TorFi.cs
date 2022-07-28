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
    public partial class TorFi : Form //Creates a true or false question without pictures and adds it to the gameData txt file.
    {
        OpenFileDialog correctImage = new OpenFileDialog();
        OpenFileDialog incorrectImage = new OpenFileDialog();
        public TorFi()
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
                newQ.QType = 2;
                newQ.Question = txtQuestion.Text;
                string tPicAddr = correctImage.FileName;
                string tPicName = Path.GetFileName(tPicAddr);
                newQ.CorrectAnswer = tPicName;
                string fPicAddr = incorrectImage.FileName;
                string fPicName = Path.GetFileName(fPicAddr);
                newQ.IncorrectAnswerOne = fPicName;
                if (txtQuestion.Text != "" && pcbTrue.Image != null && pcbFalse.Image != null)
                {
                    string insertQ = "\n" + newQ.QNumber + ";" + newQ.QType + ";" + newQ.Question + ";"
                           + newQ.CorrectAnswer + ";" + newQ.IncorrectAnswerOne;
                    StreamWriter sw = new StreamWriter("DATA/gameData.txt", true);
                    sw.Write(insertQ);
                    sw.Close();
                    File.Copy(tPicAddr, "QIMAGES/" + tPicName);
                    File.Copy(fPicAddr, "QIMAGES/" + fPicName);
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
                else if (pcbFalse.Image == null)
                {
                    MessageBox.Show("Please add a False Image!");
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

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            correctImage.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (correctImage.ShowDialog() == DialogResult.OK)
            {
                pcbTrue.Image = Image.FromFile(correctImage.FileName);
            }
        }

        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            incorrectImage.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (incorrectImage.ShowDialog() == DialogResult.OK)
            {
                pcbFalse.Image = Image.FromFile(incorrectImage.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AddQuestion().Show();
            this.Close();
        }
    }
}
