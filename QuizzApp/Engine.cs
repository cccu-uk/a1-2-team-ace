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

        public static void MoviesQuiz()
        {
            OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
            onePlayerQuiz.QuestionLblTxt = "Movieeeeeee";
            //------------------------------------------------------------//

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
