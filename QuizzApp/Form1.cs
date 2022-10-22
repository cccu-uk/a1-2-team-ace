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
            get { return this.chosenTopicComboBox.Text; }
            set { this.chosenTopicComboBox.Text = value; }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Engine.OpenOnePlayerForm();


            if (ChosenTopic == "Movies")
            {
                Engine.MathsQuiz();
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
                MessageBox.Show("PLEASE CHOOSE A GOD DAMN THEME FOR THE QUIZ!");
            }
        }
    }
}