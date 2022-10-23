namespace QuizzApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ChosenTopic
        {
            get { return chosenTopicComboBox.Text; }
            set { chosenTopicComboBox.Text = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chosenTopicComboBox.Items.Insert(0, "Movies");
            chosenTopicComboBox.Items.Insert(1, "Games");
            chosenTopicComboBox.Items.Insert(2, "Music");
            chosenTopicComboBox.Items.Insert(3, "Geography");
            chosenTopicComboBox.Items.Insert(4, "Maths");

        }

        private void chosenTopicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public int questionInc = 0; // Change this value manually to change on to the next question
        private void button1_Click(object sender, EventArgs e)
        {

            OnePlayerQuiz onePlayerQuiz = new OnePlayerQuiz();
            Engine.OpenOnePlayerForm();

            if (ChosenTopic == "Movies")
            {
                var engine = new Engine();
                engine.MoviesQuiz(questionInc); // When the user clicks the button in form 2 it needs to increment the questionInc
                                                // to move onto the next question

            }
            else if (ChosenTopic == "Games")
            {
                Engine.GamesQuiz();
            }
            else if (ChosenTopic == "Music")
            {
                Engine.MusicQuiz();
            }
            else if (ChosenTopic == "Geography")
            {
                Engine.GeographyQuiz();
            }
            else if (ChosenTopic == "Maths")
            {
                Engine.MathsQuiz();
            }
            #region
            //Hidden
            //else if (ChosenTopic == "LOTR")
            //{
            //    Engine.LOTRQuiz();
            //}
            #endregion
            else
            {
                MessageBox.Show("PLEASE CHOOSE THEME FOR THE QUIZ!");
            }
        }
    }
}