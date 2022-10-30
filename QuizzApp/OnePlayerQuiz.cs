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
            Form form = Application.OpenForms["Form1"];
            string chosenTopicTxt = ((Form1)form).ChosenTopic;

            InitializeComponent();
            UnselectRadioBtns();

            if (chosenTopicTxt == "Movies")
            {
                MoviesQuiz(nextQuestion);
            }
            if(chosenTopicTxt == "Games")
            {
                GamesQuiz(nextQuestion);
            }
            if (chosenTopicTxt == "Music")
            {
                MusicQuiz(nextQuestion);
            }
            if (chosenTopicTxt == "Geography")
            {
                GeographyQuiz(nextQuestion);
            }
            if (chosenTopicTxt == "Maths")
            {
                MathsQuiz(nextQuestion);
            }
            if (chosenTopicTxt == "LOTR")
            {
                LOTRQuiz(nextQuestion);
            }
            showStats.Hide();
            backHomeBtn.Hide();
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
                    nameOfQuestionLbl.Text = "What year was the first Lord of the Rings released? ";
                    ansARadioBtn.Text = "2000";
                    ansBRadioBtn.Text = "2002";
                    ansCRadioBtn.Text = "2001"; // correct answer
                    ansDRadioBtn.Text = "1998";
                    break;

                case 3:
                    nameOfQuestionLbl.Text = "Where did Obi-Wan take Luke Skywalker after his birth?";
                    ansARadioBtn.Text = "Tatooine"; // correct answer
                    ansBRadioBtn.Text = "Naboo";
                    ansCRadioBtn.Text = "Hoth";
                    ansDRadioBtn.Text = "Coruscant";
                    break;

                case 4:
                    nameOfQuestionLbl.Text = "Who killed Vincent Vega, with his own weapon, when he was coming out of the toilet? ";
                    ansARadioBtn.Text = "Jules Winnfield";
                    ansBRadioBtn.Text = "Jimmy Dimmick";
                    ansCRadioBtn.Text = "Marselus Wallace";
                    ansDRadioBtn.Text = "Butch Coolidge"; // correc answer
                    break;
            }
        }

        private void GamesQuiz(int questions)
        {
            switch (questions)
            {
                case 0:
                    nameOfQuestionLbl.Text = "When exactly was the first Super Mario Bros. game created?";
                    ansARadioBtn.Text = "17 Oct 1967";
                    ansBRadioBtn.Text = "28 Jan 1973";
                    ansCRadioBtn.Text = "13 Sept 1985"; // correct answer
                    ansDRadioBtn.Text = "2 May 1989";
                    break;

                case 1:
                    nameOfQuestionLbl.Text = "What is the name of the first FPS game ever created?";
                    ansARadioBtn.Text = "Maze War"; // correct answer
                    ansBRadioBtn.Text = "DOOM";
                    ansCRadioBtn.Text = "Wolfenstein";
                    ansDRadioBtn.Text = "Quake";
                    break;

                case 2:
                    nameOfQuestionLbl.Text = "Which fighting game has the common voice line, 'FINISH HIM/HER'?";
                    ansARadioBtn.Text = "Street Fighter";
                    ansBRadioBtn.Text = "Tekkan";
                    ansCRadioBtn.Text = "Killer Instict";
                    ansDRadioBtn.Text = "Mortal Kombat"; // correct answer
                    break;

                case 3:
                    nameOfQuestionLbl.Text = "What does 'GG' stand for?";
                    ansARadioBtn.Text = "Green Gnome";
                    ansBRadioBtn.Text = "Good Graphics";
                    ansCRadioBtn.Text = "Good Game"; // correct answer
                    ansDRadioBtn.Text = "Great Game";
                    break;

                case 4:
                    nameOfQuestionLbl.Text = "What was Game of the Year in 2018?";
                    ansARadioBtn.Text = "God of War"; // correct answer
                    ansBRadioBtn.Text = "Assassins Creed Odyssey";
                    ansCRadioBtn.Text = "Marvel's Spider-Ma";
                    ansDRadioBtn.Text = "Red Dead Redemption 2";
                    break;
            }
        }     

        private void MusicQuiz(int questions)
        {
            switch (questions)
            {
                case 0:
                    nameOfQuestionLbl.Text = "What is Micheal Jackson's Greatest hit in January 1983?";
                    ansARadioBtn.Text = "Thriller";
                    ansBRadioBtn.Text = "Billie Jean"; // correct answer
                    ansCRadioBtn.Text = "Smooth Criminal";
                    ansDRadioBtn.Text = "Beat It";
                    break;

                case 1:
                    nameOfQuestionLbl.Text = "What is the name of the guitarist than played for Queen?";
                    ansARadioBtn.Text = "Roger Taylor";
                    ansBRadioBtn.Text = "Freddie Mercury";
                    ansCRadioBtn.Text = "John Deacon";
                    ansDRadioBtn.Text = "Brian May"; // correct answer
                    break;

                case 2:
                    nameOfQuestionLbl.Text = "Who sang 'Could you be Loved' that was released June 10 1980?";
                    ansARadioBtn.Text = "Bob Marley"; // correct answer
                    ansBRadioBtn.Text = "Joe Cooker";
                    ansCRadioBtn.Text = "UB40";
                    ansDRadioBtn.Text = "Lucky Dube";
                    break;

                case 3:
                    nameOfQuestionLbl.Text = "What year did The Rolling Stones form?";
                    ansARadioBtn.Text = "1981";
                    ansBRadioBtn.Text = "1962"; // cooret answer
                    ansCRadioBtn.Text = "1959";
                    ansDRadioBtn.Text = "1974";
                    break;

                case 4:
                    nameOfQuestionLbl.Text = "Who bought Beats Music in 2014?";
                    ansARadioBtn.Text = "Microsoft";
                    ansBRadioBtn.Text = "Sony";
                    ansCRadioBtn.Text = "Google";
                    ansDRadioBtn.Text = "Apple"; // corect answer
                    break;
            }
        }
        
        private void GeographyQuiz(int questions)
        {
            switch (questions)
            {
                case 0:
                    nameOfQuestionLbl.Text = "What is the biggest desert in the world?";
                    ansARadioBtn.Text = "Kalahari";
                    ansBRadioBtn.Text = "Gobi";
                    ansCRadioBtn.Text = "Patagonian";
                    ansDRadioBtn.Text = "Sahara"; // correct answer
                    break;

                case 1:
                    nameOfQuestionLbl.Text = "Where is the Burj Khalifa?";
                    ansARadioBtn.Text = "Sharjah";
                    ansBRadioBtn.Text = "Ajman";
                    ansCRadioBtn.Text = "Dubai"; // correct answer
                    ansDRadioBtn.Text = "Hatta";
                    break;

                case 2:
                    nameOfQuestionLbl.Text = "What is the biggest continent, in terms of land mass, in the world?";
                    ansARadioBtn.Text = "North America";
                    ansBRadioBtn.Text = "Asia"; // correct answer
                    ansCRadioBtn.Text = "Africa";
                    ansDRadioBtn.Text = "Europe";
                    break;

                case 3:
                    nameOfQuestionLbl.Text = "Which country's flag is solid green?";
                    ansARadioBtn.Text = "Libya"; // correct answer
                    ansBRadioBtn.Text = "Algeria";
                    ansCRadioBtn.Text = "Egypt";
                    ansDRadioBtn.Text = "Tunisia";
                    break;

                case 4:
                    nameOfQuestionLbl.Text = "What is the body of water called that connects the Mediterranean Sea to the Red Sea? ";
                    ansARadioBtn.Text = "Guatemala Canal";
                    ansBRadioBtn.Text = "Nicaragua Canal";
                    ansCRadioBtn.Text = "Panama Canal";
                    ansDRadioBtn.Text = "Suez Canal"; // correct answer
                    break;
            }
        }
        
        private void MathsQuiz(int questions)
        {
            switch (questions)
            {
                case 0:
                    nameOfQuestionLbl.Text = "6 / 2 (1 + 2)";
                    ansARadioBtn.Text = "2";
                    ansBRadioBtn.Text = "9"; // correct answer
                    ansCRadioBtn.Text = "1";
                    ansDRadioBtn.Text = "10";
                    break;

                case 1:
                    nameOfQuestionLbl.Text = "What is the value of Pi?";
                    ansARadioBtn.Text = "314.0";
                    ansBRadioBtn.Text = "31.4";
                    ansCRadioBtn.Text = "0.314";
                    ansDRadioBtn.Text = "3.14"; // correct answer
                    break;

                case 2:
                    nameOfQuestionLbl.Text = "How many Earth hours are in a Earth year?";
                    ansARadioBtn.Text = "12,471";
                    ansBRadioBtn.Text = "8,760"; // correct answer
                    ansCRadioBtn.Text = "21,948";
                    ansDRadioBtn.Text = "2,193";
                    break;

                case 3:
                    nameOfQuestionLbl.Text = "What is the base 10 equivilent for 1 0 0?";
                    ansARadioBtn.Text = "4"; // correct answer
                    ansBRadioBtn.Text = "8";
                    ansCRadioBtn.Text = "32";
                    ansDRadioBtn.Text = "16";
                    break;

                case 4:
                    nameOfQuestionLbl.Text = "What is 6 raised to the power 0?";
                    ansARadioBtn.Text = "1";
                    ansBRadioBtn.Text = "0"; 
                    ansCRadioBtn.Text = "-1"; // correct answer
                    ansDRadioBtn.Text = "2";
                    break;
            }
        }

        private void LOTRQuiz(int questions)
        {
            switch (questions)
            {
                case 0:
                    nameOfQuestionLbl.Text = "What is the name of the giant spider who tried to eat Frodo?";
                    ansARadioBtn.Text = "Balrog";
                    ansBRadioBtn.Text = "Morgoth";
                    ansCRadioBtn.Text = "Sauron";
                    ansDRadioBtn.Text = "Shelob";
                    break;
                case 1:
                    nameOfQuestionLbl.Text = "When Frodo and the other hobbits first meet Aragorn, what name does he use?";
                    ansARadioBtn.Text = "Ranger";
                    ansBRadioBtn.Text = "Aragon";
                    ansCRadioBtn.Text = "Strider";
                    ansDRadioBtn.Text = "Dunedain";
                    break;
                case 2:
                    nameOfQuestionLbl.Text = "Who made the three elven rings?";
                    ansARadioBtn.Text = "Celebrimbor";
                    ansBRadioBtn.Text = "Celeborn";
                    ansCRadioBtn.Text = "Sauron";
                    ansDRadioBtn.Text = "Galadriel";
                    break;
                case 3:
                    nameOfQuestionLbl.Text = "How many Oscars has the Lord of the Rings franchise won?";
                    ansARadioBtn.Text = "16";
                    ansBRadioBtn.Text = "12";
                    ansCRadioBtn.Text = "15";
                    ansDRadioBtn.Text = "19";
                    break;
                case 4:
                    nameOfQuestionLbl.Text = "What is Sauron and Gandalf in the Lord of the Rings?";
                    ansARadioBtn.Text = "Wizards";
                    ansBRadioBtn.Text = "Necromancers";
                    ansCRadioBtn.Text = "Maiar";
                    ansDRadioBtn.Text = "Valar";
                    break;

            }
        }

        private void selectAnswerBtn_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["Form1"];
            string chosenTopicTxt = ((Form1)form).ChosenTopic;
            nextQuestion++;


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

                if (nameOfQuestionLbl.Text == "What year was the first Lord of the Rings released? ")
                {
                    if (ansCRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MoviesQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "Where did Obi-Wan take Luke Skywalker after his birth?")
                {
                    if (ansARadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MoviesQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "Who killed Vincent Vega, with his own weapon, when he was coming out of the toilet? ")
                {
                    if (ansDRadioBtn.Checked == true)
                    {
                        Score++;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();

                    }
                    if (ansARadioBtn.Checked == true || ansBRadioBtn.Checked == true || ansCRadioBtn.Checked == true)
                    {
                        Score--;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();
                    }
                    UnselectRadioBtns();
                    MoviesQuiz(nextQuestion);
                }
            }

            if (chosenTopicTxt == "Games")
            {

                if (nameOfQuestionLbl.Text == "When exactly was the first Super Mario Bros. game created?")
                {
                    if (ansCRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    GamesQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What is the name of the first FPS game ever created?")
                {
                    if (ansARadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    GamesQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "Which fighting game has the common voice line, 'FINISH HIM/HER'?")
                {
                    if (ansDRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    GamesQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What does 'GG' stand for?")
                {
                    if (ansCRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    GamesQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What was Game of the Year in 2018?")
                {
                    if (ansARadioBtn.Checked == true)
                    {
                        Score++;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();

                    }
                    if (ansDRadioBtn.Checked == true || ansBRadioBtn.Checked == true || ansCRadioBtn.Checked == true)
                    {
                        Score--;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();
                    }
                    UnselectRadioBtns();
                    GamesQuiz(nextQuestion);

                }
            }

            if (chosenTopicTxt == "Music")
            {
                if (nameOfQuestionLbl.Text == "What is Micheal Jackson's Greatest hit in January 1983?")
                {
                    if (ansBRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MusicQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What is the name of the guitarist than played for Queen?")
                {
                    if (ansDRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MusicQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "Who sang 'Could you be Loved' that was released June 10 1980?")
                {
                    if (ansARadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MusicQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What year did The Rolling Stones form?")
                {
                    if (ansBRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MusicQuiz(nextQuestion);
                }


                if (nameOfQuestionLbl.Text == "Who bought Beats Music in 2014?")
                {
                    if (ansDRadioBtn.Checked == true)
                    {
                        Score++;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();

                    }
                    if (ansARadioBtn.Checked == true || ansBRadioBtn.Checked == true || ansCRadioBtn.Checked == true)
                    {
                        Score--;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();
                    }
                    UnselectRadioBtns();
                    MusicQuiz(nextQuestion);
                }
            }
                
            if (chosenTopicTxt == "Geography")
            {
                if (nameOfQuestionLbl.Text == "What is the biggest desert in the world?")
                {
                    if (ansDRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    GeographyQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "Where is the Burj Khalifa?")
                {
                    if (ansCRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    GeographyQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What is the biggest continent, in terms of land mass, in the world?")
                {
                    if (ansBRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    GeographyQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "Which country's flag is solid green?")
                {
                    if (ansARadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    GeographyQuiz(nextQuestion);
                }


                if (nameOfQuestionLbl.Text == "What is the body of water called that connects the Mediterranean Sea to the Red Sea? ")
                {
                    if (ansDRadioBtn.Checked == true)
                    {
                        Score++;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();

                    }
                    if (ansARadioBtn.Checked == true || ansBRadioBtn.Checked == true || ansCRadioBtn.Checked == true)
                    {
                        Score--;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();
                    }
                    UnselectRadioBtns();
                    GeographyQuiz(nextQuestion);
                }
            }
                
            if (chosenTopicTxt == "Maths")
            {
                if (nameOfQuestionLbl.Text == "6 / 2 (1 + 2)")
                {
                    if (ansBRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MathsQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What is the value of Pi?")
                {
                    if (ansDRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MathsQuiz(nextQuestion);
                }
                
                if (nameOfQuestionLbl.Text == "How many Earth hours are in a Earth year?")
                {
                    if (ansBRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MathsQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What is the base 10 equivilent for 1 0 0?")
                {
                    if (ansARadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    MathsQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What is 6 raised to the power 0?")
                {
                    if (ansCRadioBtn.Checked == true)
                    {
                        Score++;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();

                    }
                    if (ansARadioBtn.Checked == true || ansBRadioBtn.Checked == true || ansDRadioBtn.Checked == true)
                    {
                        Score--;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();
                    }
                    UnselectRadioBtns();
                    MathsQuiz(nextQuestion);
                }
            }

            if (chosenTopicTxt == "LOTR")
            {
                if (nameOfQuestionLbl.Text == "What is the name of the giant spider who tried to eat Frodo?")
                {
                    if (ansDRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    LOTRQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "When Frodo and the other hobbits first meet Aragorn, what name does he use?")
                {
                    if (ansCRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    LOTRQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "Who made the three elven rings?")
                {
                    if (ansARadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    LOTRQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "How many Oscars has the Lord of the Rings franchise won?")
                {
                    if (ansDRadioBtn.Checked == true)
                    {
                        Score++;
                    }
                    UnselectRadioBtns();
                    LOTRQuiz(nextQuestion);
                }

                if (nameOfQuestionLbl.Text == "What is Sauron and Gandalf in the Lord of the Rings?")
                {
                    if (ansCRadioBtn.Checked == true)
                    {
                        Score++;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();

                    }
                    if (ansARadioBtn.Checked == true || ansBRadioBtn.Checked == true || ansDRadioBtn.Checked == true)
                    {
                        Score--;
                        EndHideBtns();
                        showStats.Show();
                        backHomeBtn.Show();
                    }
                    UnselectRadioBtns();
                    LOTRQuiz(nextQuestion);
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
