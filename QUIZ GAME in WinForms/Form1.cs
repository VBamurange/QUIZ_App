using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ_GAME_in_WinForms
{
    /// <summary>
    /// Represents the main for quiz game
    /// </summary>
    public partial class Form1 : Form
    {
        Dictionary<int, int> questionScores = new Dictionary<int, int>();
        int correctAnswer;
        int questionNumber = 1;
        int score = 0;
        int totalScore = 0;
        int percentage;
        int totalQuestions;
        bool answeConfirmed = false;
        bool isCorrectAnswer = false;

        /// <summary>
        /// Initilaize a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            questionScores.Add(1, 10);
            questionScores.Add(2, 12);
            questionScores.Add(3, 10);
            questionScores.Add(4, 3);
            questionScores.Add(5, 10);
            questionScores.Add(6, 15);
            questionScores.Add(7, 5);


            askQuestion(questionNumber);

            totalQuestions = 7;
        }

        /// <summary>
        /// Handles the click event for the answer buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score += questionScores[questionNumber];
                isCorrectAnswer = true;
            } else {
                isCorrectAnswer = false;
            }
            totalScore += questionScores[questionNumber];
            UpdatePercentage();
            answeConfirmed = true;
        }


        /// <summary>
        /// Asks a question
        /// </summary>
        /// <param name="qnum"></param>
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    lblQuestion.Text = "Who is the most famous Pharaoh?";

                    button1.Text = "Khufu";
                    button2.Text = "Cleopatra";
                    button3.Text = " Tutanhum";
                    button4.Text = "Djoser";

                    correctAnswer = 3;

                    break;

                case 2:
                    lblQuestion.Text = "Who is the father of Mathematics?";

                    button1.Text = "Alan Turing";
                    button2.Text = "Pythagoras";
                    button3.Text = " Euclid";
                    button4.Text = "Archimedes";

                    correctAnswer = 4;

                    break;

                case 3:
                    lblQuestion.Text = "Which president was mostly recently assasinated?";

                    button1.Text = "Jovenel Moise";
                    button2.Text = "Abraham Lincoln";
                    button3.Text = " Tutanhum";
                    button4.Text = "William McKinley";

                    correctAnswer = 1;

                    break;

                case 4:
                    lblQuestion.Text = "How long was Queen Elizabeth II 's reign?";

                    button1.Text = "64 years";
                    button2.Text = "71 years";
                    button3.Text = " 57 years";
                    button4.Text = "70 years";

                    correctAnswer = 4;

                    break;

                case 5:
                    lblQuestion.Text = "How big was Zaire?";

                    button1.Text = "49 million sqkm";
                    button2.Text = "11 million sqkm";
                    button3.Text = "2 million sqkm";
                    button4.Text = "2.345 million sqkm";

                    correctAnswer = 4;

                    break;

                case 6:
                    lblQuestion.Text = "Which is considered the greatest African Empire?";

                    button1.Text = "Shonghai";
                    button2.Text = "Mali";
                    button3.Text = "Kush";
                    button4.Text = "Zimbabwe";

                    correctAnswer = 1;

                    break;

                case 7:
                    lblQuestion.Text = "How many students are in the AR/VR class?";

                    button1.Text = "11";
                    button2.Text = "12";
                    button3.Text = "4";
                    button4.Text = "2";

                    correctAnswer = 3;

                    break;
            }
        }

        /// <summary>
        /// Updates the percentage score
        /// </summary>
    private void UpdatePercentage()
        {
           if (totalScore >0)
            {
                percentage = (int)Math.Round((double)score * 100 / totalScore);
            }
            else
            {
                percentage = 0;
            }
       }
        /// <summary>
        /// Asks the next question when cofirm button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmButton(object sender, EventArgs e)
        {
            if (answeConfirmed)
            {
                if(isCorrectAnswer)
                {
                    MessageBox.Show("Answer is correct");
                } else
                {
                    MessageBox.Show("Answer is incorrect");
                }
                isCorrectAnswer = false; //reset correct answer checking variable
                MoveToNextQuestion();
            }
            else
            {
                MessageBox.Show("Please select an answer and confirm.");
            }
        }

        // Private Methods

        /// <summary>
        /// Moves to the next question
        /// </summary>
    private void MoveToNextQuestion()
        {
            if (questionNumber == totalQuestions)
            {
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "Score: " + score + Environment.NewLine +
                    "Total percentage"  +  percentage  +  "%" + Environment.NewLine +
                    "Click OK to play again"
                    );
                score = 0;
                totalScore = 0;
                questionNumber = 1;
                askQuestion(questionNumber);
            }
            else
            {
                questionNumber++;
                askQuestion(questionNumber);
                answeConfirmed = false;
            }
        }

    
    }
}
