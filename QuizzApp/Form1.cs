namespace QuizzApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chosenTopicComboBox.Items.Insert(0, "Movies");
            chosenTopicComboBox.Items.Insert(1, "Games");
            chosenTopicComboBox.Items.Insert(2, "Music");
            chosenTopicComboBox.Items.Insert(3, "Geography");
            chosenTopicComboBox.Items.Insert(4, "Maths");

        }

        public string ChosenTopic
        {
            get { return chosenTopicComboBox.Text; }
            set { chosenTopicComboBox.Text = value; }
        }

        private void chosenTopicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}