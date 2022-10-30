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
        public static Engine Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
