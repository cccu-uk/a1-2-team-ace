using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp
{
    public sealed class Engine
    {
        public static void OpenOnePlayerForm()
        {
            Form1 form1 = new Form1();
            OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
        }
        public static void MoviesQuiz(int questions)
        {
            OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
            onePlayerQuiz.QuestionLblTxt = "Movieeeeeee";
            //------------------------------------------------------------//

            switch (questions)
            {
                case 0:
                    onePlayerQuiz.QuestionLblTxt = "When was the movie 'shawshank redemption' released? ";

                    onePlayerQuiz.ansARadioBtn.Text = "1994";
                    onePlayerQuiz.ansBRadioBtn.Text = "1995";
                    onePlayerQuiz.ansCRadioBtn.Text = "1996";
                    onePlayerQuiz.ansDRadioBtn.Text = "1997";

                    break;

                case 1:
                    onePlayerQuiz.QuestionLblTxt = "What's the name of the skyscraper in Die Hard? ";

                    onePlayerQuiz.ansARadioBtn.Text = "Nakatomi Plaza";
                    onePlayerQuiz.ansBRadioBtn.Text = "Willis Tower";
                    onePlayerQuiz.ansCRadioBtn.Text = "The St. Regis Chicago";
                    onePlayerQuiz.ansDRadioBtn.Text = "Fake ans";

                    break;

                case 2:
                    onePlayerQuiz.QuestionLblTxt = "When was the movie 'shawshank redemption' released? ";

                    onePlayerQuiz.ansARadioBtn.Text = "1994";
                    onePlayerQuiz.ansBRadioBtn.Text = "1995";
                    onePlayerQuiz.ansCRadioBtn.Text = "1996";
                    onePlayerQuiz.ansDRadioBtn.Text = "1997";

                    break;

                case 3:
                    onePlayerQuiz.QuestionLblTxt = "When was the movie 'shawshank redemption' released? ";

                    onePlayerQuiz.ansARadioBtn.Text = "1994";
                    onePlayerQuiz.ansBRadioBtn.Text = "1995";
                    onePlayerQuiz.ansCRadioBtn.Text = "1996";
                    onePlayerQuiz.ansDRadioBtn.Text = "1997";

                    break;

                case 4:
                    onePlayerQuiz.QuestionLblTxt = "When was the movie 'shawshank redemption' released? ";

                    onePlayerQuiz.ansARadioBtn.Text = "1994";
                    onePlayerQuiz.ansBRadioBtn.Text = "1995";
                    onePlayerQuiz.ansCRadioBtn.Text = "1996";
                    onePlayerQuiz.ansDRadioBtn.Text = "1997";

                    break;
            }

            //------------------------------------------------------------//
            onePlayerQuiz.Show();
        }

        public static void MusicQuiz()
        {
            OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
            onePlayerQuiz.QuestionLblTxt = "Musicccccccccccc";
            //------------------------------------------------------------//



            //------------------------------------------------------------//
            onePlayerQuiz.Show();
        }

        public static void GamesQuiz()
        {
            OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
            onePlayerQuiz.QuestionLblTxt = "Gamesssssssssssss";
            //------------------------------------------------------------//

            //------------------------------------------------------------//
            onePlayerQuiz.Show();
        }
        
        public static void GeographyQuiz()
        {
            OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
            onePlayerQuiz.QuestionLblTxt = "Geographyyyyyyyyyy";
            //------------------------------------------------------------//

            //------------------------------------------------------------//
            onePlayerQuiz.Show();
        }

        public static void MathsQuiz()
        {
            OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
            onePlayerQuiz.QuestionLblTxt = "Mathsssssssss";
            //------------------------------------------------------------//

            //------------------------------------------------------------//
            onePlayerQuiz.Show();
        }
        #region
        //public static void LOTRQuiz()
        //{
        //    OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
        //    onePlayerQuiz.QuestionLblTxt = "Hidden";
        //    //------------------------------------------------------------//

        //    //------------------------------------------------------------//
        //    onePlayerQuiz.Show();
        //}
        #endregion
    }
}
