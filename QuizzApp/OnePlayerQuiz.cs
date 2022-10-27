using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class OnePlayerQuiz : Form
    {
        int nextQuestion = 0;
        int Score = 0;
        public OnePlayerQuiz()
        {
            InitializeComponent();
            MoviesQuiz(nextQuestion);
            showStats.Hide();


            //engine.MoviesQuiz(1);
        }

        public string QuestionLblTxt
        {
            get { return this.nameOfQuestionLbl.Text; }
            set { this.nameOfQuestionLbl.Text = value; }
        }

        private void OnePlayerQuiz_Load(object sender, EventArgs e)
        {
            //Engine.MoviesQuiz(3);
        }
        // public bool selectAnswerBtnWasClicked = false;

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        string correctAnswer;

        private void MoviesQuiz(int questions)
        {
            switch (questions)
            {
                case 0:
                    nameOfQuestionLbl.Text = "When was the movie 'shawshank redemption' released? ";
                    ansARadioBtn.Text = "1994";
                    ansBRadioBtn.Text = "1995";
                    ansCRadioBtn.Text = "1996";
                    ansDRadioBtn.Text = "1997";
                    break;

                case 1:
                    nameOfQuestionLbl.Text = "What's the name of the skyscraper in Die Hard? ";
                    ansARadioBtn.Text = "Nakatomi Plaza";
                    ansBRadioBtn.Text = "Willis Tower";
                    ansCRadioBtn.Text = "The St. Regis Chicago";
                    ansDRadioBtn.Text = "Fake ans";
                    break;

                case 2:
                    nameOfQuestionLbl.Text = "Test 3 ";
                    ansARadioBtn.Text = "1994";
                    ansBRadioBtn.Text = "1995";
                    ansCRadioBtn.Text = "1996";
                    ansDRadioBtn.Text = "1997";
                    break;

                case 3:
                    nameOfQuestionLbl.Text = "Test 4 ";
                    ansARadioBtn.Text = "1994";
                    ansBRadioBtn.Text = "1995";
                    ansCRadioBtn.Text = "1996";
                    ansDRadioBtn.Text = "1997";
                    break;

                case 4:
                    nameOfQuestionLbl.Text = "Test 5 ";
                    ansARadioBtn.Text = "1994";
                    ansBRadioBtn.Text = "1995";
                    ansCRadioBtn.Text = "1996";
                    ansDRadioBtn.Text = "1997";
                    break;
            }

            //------------------------------------------------------------//
        }


        public void UnselectRadioBtns()
        {
            ansARadioBtn.Checked = false;
            ansBRadioBtn.Checked = false;
            ansCRadioBtn.Checked = false;
            ansDRadioBtn.Checked = false;
        }


        private void selectAnswerBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form form = System.Windows.Forms.Application.OpenForms["Form1"];
            string chosenTopicTxt = ((Form1)form).ChosenTopic;
            //var senderObject = (RadioButton)sender;
            //var checkedButton = container.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (nameOfQuestionLbl.Text == "When was the movie 'shawshank redemption' released? ")
            {
                if (ansARadioBtn.Checked == true)
                {
                    Score++;
                }
                nextQuestion++;
                UnselectRadioBtns();
                MoviesQuiz(nextQuestion);
            }

            if (nameOfQuestionLbl.Text == "What's the name of the skyscraper in Die Hard? ")
            {
                if (ansARadioBtn.Checked == true)
                {
                    Score++;
                }
                nextQuestion++;
                UnselectRadioBtns();
                MoviesQuiz(nextQuestion);
            }

            if (nameOfQuestionLbl.Text == "Test 3 ")
            {
                if (ansARadioBtn.Checked == true)
                {
                    Score++;
                }
                nextQuestion++;
                UnselectRadioBtns();
                MoviesQuiz(nextQuestion);
            }

            if (nameOfQuestionLbl.Text == "Test 4 ")
            {
                if (ansBRadioBtn.Checked == true)
                {
                    Score++;
                }
                nextQuestion++;
                UnselectRadioBtns();
                MoviesQuiz(nextQuestion);

            }

            if (nameOfQuestionLbl.Text == "Test 5 ")
            {
                if (ansBRadioBtn.Checked == true)
                {
                    Score++;
                }
                nextQuestion++;
                UnselectRadioBtns();
                MoviesQuiz(nextQuestion);
                showStats.Show();
            }


            if (chosenTopicTxt == "Movies")
            {
                return;
            }
        }

        private void showStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Score.ToString());
        }
    }
}
