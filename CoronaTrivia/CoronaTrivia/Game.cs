using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTrivia
{
    public class Game
    {
        //Fields
        protected int qNumber;
        protected int qType;
        protected string question;
        protected string correctAnswer;
        protected string incorrectAnswerOne;
        protected string incorrectAnswerTwo;
        //Properties
        public int QNumber { get => qNumber; set => qNumber = value; }
        public int QType { get => qType; set => qType = value; }
        public string Question { get => question; set => question = value; }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public string IncorrectAnswerOne { get => incorrectAnswerOne; set => incorrectAnswerOne = value; }
        public string IncorrectAnswerTwo { get => incorrectAnswerTwo; set => incorrectAnswerTwo = value; }
        //Constructors
        public Game() //Empty Constructor
        {

        }
        public Game(int qNumber, int qType, string question, string correctAnswer, string incorrectAnswerOne)
        //Constructor with 2 answers
        {
            QNumber = qNumber;
            QType = qType;
            Question = question;
            CorrectAnswer = correctAnswer;
            IncorrectAnswerOne = incorrectAnswerOne;
        }
        public Game(int qNumber, int qType, string question, string correctAnswer, string incorrectAnswerOne, string incorrectAnswerTwo)
        //Constructor with 3 answers
        {
            QNumber = qNumber;
            QType = qType;
            Question = question;
            CorrectAnswer = correctAnswer;
            IncorrectAnswerOne = incorrectAnswerOne;
            IncorrectAnswerTwo = incorrectAnswerTwo;
        }
    }
}
