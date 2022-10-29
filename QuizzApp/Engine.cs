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
            form1.Hide();
            OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
            onePlayerQuiz.Closed += (s, args) => form1.Close();
            onePlayerQuiz.Show();
        }
        
        public static void MusicQuiz(int question)
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
    }
}
