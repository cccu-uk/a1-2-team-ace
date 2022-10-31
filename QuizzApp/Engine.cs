using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp
{
    public sealed class Engine
    {
        private static readonly Engine instance = new Engine();
        public static void OpenOnePlayerForm()
        {
            Form1 form1 = new Form1();
            form1.Hide();
            OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
            onePlayerQuiz.Closed += (s, args) => form1.Close();
            onePlayerQuiz.Show();

            
        }
        public static void OpenTwoPlayerForm() 
        {
            Form1 form2 = new Form1();
            form2.Hide();
            TwoPlayerQuiz twoPlayerQuiz = new TwoPlayerQuiz();
            twoPlayerQuiz.Closed += (s, args) => form2.Close();
            twoPlayerQuiz.Show();
        }
        public static Engine Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
