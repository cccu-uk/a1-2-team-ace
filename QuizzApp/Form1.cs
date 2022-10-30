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
            chosenTopicComboBox.Items.Insert(4, "LOTR");

        }

        private void chosenTopicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ChosenTopic == "Movies")
            {
                Engine.OpenOnePlayerForm();
            }
            else if (ChosenTopic == "Games")
            {
                Engine.OpenOnePlayerForm();
            }
            else if (ChosenTopic == "Music")
            {
                Engine.OpenOnePlayerForm();
            }
            else if (ChosenTopic == "Geography")
            {
                Engine.OpenOnePlayerForm();
            }
            else if (ChosenTopic == "Maths")
            {
                Engine.OpenOnePlayerForm();
            }
            else if (ChosenTopic == "LOTR")
            {
                Engine.OpenOnePlayerForm();
            }
            #region
            //Hidden
            //else if (ChosenTopic == "LOTR")
            //{
            ///Engine.OpenOnePlayerForm();
            //}
            #endregion
            else
            {
                MessageBox.Show("PLEASE CHOOSE THEME FOR THE QUIZ!");
            }
        }
    }
}