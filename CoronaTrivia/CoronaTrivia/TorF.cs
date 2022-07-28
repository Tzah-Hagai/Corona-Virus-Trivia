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
    public partial class TorF : Form //Creates a true or false question without pictures and adds it to the gameData txt file.
    {
        public TorF()
        {
            InitializeComponent(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string[] qLines = File.ReadAllLines("DATA/gameData.txt");
                Game newQ = new Game();
                newQ.QNumber = qLines.Length + 1;
                newQ.QType = 0;
                newQ.Question = txtQuestion.Text;
                if (txtQuestion.Text != "")
                {
                    if (rbnTrue.Checked)
                    {
                        newQ.CorrectAnswer = rbnTrue.Text;
                        newQ.IncorrectAnswerOne = rbnFalse.Text;
                    }
                    if (rbnFalse.Checked)
                    {
                        newQ.CorrectAnswer = rbnFalse.Text;
                        newQ.IncorrectAnswerOne = rbnTrue.Text;
                    }
                    string insertQ = "\n" + newQ.QNumber + ";" + newQ.QType + ";" + newQ.Question + ";"
                           + newQ.CorrectAnswer + ";" + newQ.IncorrectAnswerOne;
                    StreamWriter sw = new StreamWriter("DATA/gameData.txt", true);
                    sw.Write(insertQ);
                    sw.Close();
                    new Menu().Show();
                    this.Close();
                }
                else MessageBox.Show("Please enter a question first!");
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
            new AddQuestion().Show();
            this.Close();
        }
    }
}
