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
    public partial class MultiC : Form //Creates a multiple answer question without pictures and adds it to the gameData txt file.
    {
        public MultiC()
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
                newQ.QType = 1;
                newQ.Question = txtQuestion.Text;
                newQ.CorrectAnswer = txtCAnswer.Text;
                newQ.IncorrectAnswerOne = txtInc1.Text;
                newQ.IncorrectAnswerTwo = txtInc2.Text;
                if (txtQuestion.Text != "" && txtCAnswer.Text != ""
                    && txtInc1.Text != "" && txtInc2.Text != "")
                {
                    string insertQ = "\n" + newQ.QNumber + ";" + newQ.QType + ";" + newQ.Question + ";"
                           + newQ.CorrectAnswer + ";" + newQ.IncorrectAnswerOne + ";" + newQ.IncorrectAnswerTwo;
                    StreamWriter sw = new StreamWriter("DATA/gameData.txt", true);
                    sw.Write(insertQ);
                    sw.Close();
                    new Menu().Show();
                    this.Close();
                }
                else MessageBox.Show("Please fill up all the text boxes first!");
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
