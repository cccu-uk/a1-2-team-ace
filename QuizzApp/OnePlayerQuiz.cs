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
            backHomeBtn.Hide();


            //engine.MoviesQuiz(1);
        }

        public void UnselectRadioBtns()
        {
            ansARadioBtn.Checked = false;
            ansBRadioBtn.Checked = false;
            ansCRadioBtn.Checked = false;
            ansDRadioBtn.Checked = false;
        }

        public void EndHideBtns()
        {
            selectAnswerBtn.Hide();
            nameOfQuestionLbl.Hide();
            ansARadioBtn.Hide();
            ansBRadioBtn.Hide();
            ansCRadioBtn.Hide();
            ansDRadioBtn.Hide();
            pictureBox.Hide();
        }

        public string QuestionLblTxt
        {
            get { return this.nameOfQuestionLbl.Text; }
            set { this.nameOfQuestionLbl.Text = value; }
        }

        private void OnePlayerQuiz_Load(object sender, EventArgs e)
        {
            UnselectRadioBtns();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MoviesQuiz(int questions)
        {
            UnselectRadioBtns();
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

        private void selectAnswerBtn_Click(object sender, EventArgs e)
        {
            nextQuestion++;
            Form form = Application.OpenForms["Form1"];
            string chosenTopicTxt = ((Form1)form).ChosenTopic;

            if (chosenTopicTxt == "Movies")
            {
                if (nameOfQuestionLbl.Text == "When was the movie 'shawshank redemption' released? ")
                {
                    if (ansARadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    MoviesQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What's the name of the skyscraper in Die Hard? ")
                {
                    if (ansARadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MoviesQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "Test 3 ")
                {
                    if (ansARadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MoviesQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "Test 4 ")
                {
                    if (ansBRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MoviesQuiz(nextQuestion);

                }

                if (nameOfQuestionLbl.Text == "Test 5 ")
                {
                    if (ansBRadioBtn.Checked == true)
                    {
                        Score++;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();

                    }
                    if (ansARadioBtn.Checked == true || ansCRadioBtn.Checked == true || ansDRadioBtn.Checked == true)
                    {
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();
                    }
                    UnselectRadioBtns();
                    MoviesQuiz(nextQuestion);
                }
            }





        }

        private void showStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your results are " + Score.ToString() + " / 5 ");
        }

        private void backHomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
