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
    public partial class Gaming : Form
    {
        ArrayList gameArr = new ArrayList();
        Game gameItem = new Game();
        public static List<Game> wrongArr = new List<Game>(); //Will be used to get the wrong answers.
        public static List<int> savedNumArr = new List<int>(); //Will be used to repeat the game.
        int index = 0;
        int score = 0;
        int correctAnswers = 0;
        int wrongAnswers = 0;
        public static int flag = 0; //Will determine if its a new game or the same one.
        public Gaming()
        {
            InitializeComponent();
            try
            {
                string[] gameLines = File.ReadAllLines("DATA/gameData.txt");
                List<int> numArr = new List<int>();
                for (int i = 0; i < gameLines.Length; i++)
                {
                    numArr.Add(i);
                }
                var numArrShuffled = numArr.OrderBy(x => Guid.NewGuid()).ToList(); //Creating a new array of randomized numbers.
                for (int i = 0; i < numArrShuffled.Count; i++)
                {
                    savedNumArr.Add(numArrShuffled[i]); //Gets the correct randomized array of numbers, for repeating the same game.
                }
                for (int i = 0; i < gameLines.Length; i++)
                {
                    string[] gamestr;
                    if (flag == 0) gamestr = gameLines[numArrShuffled[i]].Split(';'); //For a new game - gamestr array each time gets an random index
                    else gamestr = gameLines[savedNumArr[i]].Split(';'); //For repeating the same game!
                    if (gamestr.Length == 5) gameArr.Add(new Game(int.Parse(gamestr[0]), int.Parse(gamestr[1]), gamestr[2], gamestr[3], gamestr[4]));
                    if (gamestr.Length == 6) gameArr.Add(new Game(int.Parse(gamestr[0]), int.Parse(gamestr[1]), gamestr[2], gamestr[3], gamestr[4], gamestr[5]));
                }
                gameItem = (Game)gameArr[index];
                lblQuestion.Text = (index + 1) + ". " + gameItem.Question;
                if (gameItem.QType == 1)
                {
                    rbn3.Enabled = true;
                    rbn3.Visible = true;
                    List<string> stemp3 = new List<string>(); //Creates a list of strings
                    stemp3.Add(gameItem.CorrectAnswer);
                    stemp3.Add(gameItem.IncorrectAnswerOne);
                    stemp3.Add(gameItem.IncorrectAnswerTwo);
                    var shuffled3 = stemp3.OrderBy(x => Guid.NewGuid()).ToList(); //Randomizing the answers and puts them in a new array.
                    rbn1.Text = "" + shuffled3[0];
                    rbn2.Text = "" + shuffled3[1];
                    rbn3.Text = "" + shuffled3[2];
                }
                else if (gameItem.QType == 0) 
                {
                    rbn3.Enabled = false;
                    rbn3.Visible = false;
                    List<string> stemp4 = new List<string>();
                    stemp4.Add(gameItem.CorrectAnswer);
                    stemp4.Add(gameItem.IncorrectAnswerOne);
                    var shuffled4 = stemp4.OrderBy(x => Guid.NewGuid()).ToList();
                    rbn1.Text = "" + shuffled4[0];
                    rbn2.Text = "" + shuffled4[1];
                }
                txtScore.Text = "" + score;
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
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            txtScore.Text = "" + score;
            if (rbn1.Checked == false && rbn2.Checked == false && rbn3.Checked == false)
            {
                MessageBox.Show("Please choose an answer!");
                return;
            }
            if (index < 9)
            {
                Correct(rbn1, gameItem); //Checking if the radio button holds the correct answer.
                Correct(rbn2, gameItem);
                Correct(rbn3, gameItem);
                rbn1.Checked = false;
                rbn2.Checked = false;
                rbn3.Checked = false;
                btnAnswer.Enabled = true;
                index++;
                gameItem = (Game)gameArr[index];
                lblQuestion.Text = (index + 1) + ". " + gameItem.Question;
                if (gameItem.QType == 1)
                {
                    rbn3.Enabled = true;
                    rbn3.Visible = true;
                    List<string> stemp = new List<string>();
                    stemp.Add(gameItem.CorrectAnswer);
                    stemp.Add(gameItem.IncorrectAnswerOne);
                    stemp.Add(gameItem.IncorrectAnswerTwo);
                    var shuffled = stemp.OrderBy(x => Guid.NewGuid()).ToList();
                    rbn1.Text = "" + shuffled[0];
                    rbn2.Text = "" + shuffled[1];
                    rbn3.Text = "" + shuffled[2];
                }
                else if (gameItem.QType == 0)
                {
                    rbn3.Enabled = false;
                    rbn3.Visible = false;
                    List<string> stemp2 = new List<string>();
                    stemp2.Add(gameItem.CorrectAnswer);
                    stemp2.Add(gameItem.IncorrectAnswerOne);
                    var shuffled2 = stemp2.OrderBy(x => Guid.NewGuid()).ToList();
                    rbn1.Text = "" + shuffled2[0];
                    rbn2.Text = "" + shuffled2[1];
                }
            }
            else //Trivia ends
            {
                Correct(rbn1, gameItem);
                Correct(rbn2, gameItem);
                Correct(rbn3, gameItem);
                btnAnswer.Enabled = false;
                DialogResult dr;
                dr = MessageBox.Show("Well Done! Here are your Satistics:\n" +
                    "Your Score is: " + score + "\nYou had " + correctAnswers + " correct answers" +
                    " and " + wrongAnswers + " wrong ones.\nClick OK to proceed.");
                string todayDate = DateTime.Now.ToString(); //Gets the current date and time.
                char[] chars = { '/', ':', ' ' }; //Array of chars.
                string[] splitDate = todayDate.Split(chars); //Splits the time string when encounter one of the chars into a new array of strings.
                string dateStr = "" + splitDate[2] + "-" + splitDate[1] + "-" + splitDate[0]
                    + "T" + splitDate[3] + "_" + splitDate[4] + "_" + splitDate[5];
                StreamWriter sw = new StreamWriter("DATA/outdata_" + dateStr + ".txt");  //Creating a new text file with the date in the name.
                sw.Write("Name: " + TriviaGame.userName + "\nScore: " + score + "\nCorrect Answers: " //Saves the data of the user in the text file.
                    + correctAnswers + "\nWrong Answers: " + wrongAnswers); 
                sw.Close();

                if (dr == System.Windows.Forms.DialogResult.OK) //If the user clicked OK.
                {
                    new NewMenu().Show();
                    this.Close();
                }
            }
        }
        private void Correct(RadioButton rdobutton, Game temp) //Checking if the radio buttons holds the right answer. 
        {
            if (rdobutton.Checked == true)
            {
                if (rdobutton.Text.Equals(temp.CorrectAnswer))
                {
                    score += 10;                                //Adds 10 to the score if the answer is true.
                    txtScore.Text = "" + score; 
                    correctAnswers++;
                    MessageBox.Show("Correct! You get 10 Points!");
                }
                else
                {
                    MessageBox.Show("Wrong!");
                    wrongAnswers++;
                    wrongArr.Add(temp);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Close();
        }
    }
}
