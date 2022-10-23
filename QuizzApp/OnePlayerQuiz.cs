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
        public int nextQuestion = 0;
        public OnePlayerQuiz()
        {
            InitializeComponent();
        }

        public string QuestionLblTxt
        {
            get { return this.nameOfQuestionLbl.Text; }
            set { this.nameOfQuestionLbl.Text = value; }
        }

        private void OnePlayerQuiz_Load(object sender, EventArgs e)
        {
        }
        // public bool selectAnswerBtnWasClicked = false;
        public string chosenTopic;


        private void selectAnswerBtn_Click(object sender, EventArgs e)
        {
            //Engine.MoviesQuiz(questionInc);

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
