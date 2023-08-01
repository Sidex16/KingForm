namespace KingForm
{
    public partial class Form1 : Form
    {
        public static List<string> _players = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addPlayer(TextBox inputText)
        {
            if (inputText.Text != "" && inputText.Text != " ")
            {
                _players.Add(inputText.Text);
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            addPlayer(textBox1);
            addPlayer(textBox2);
            addPlayer(textBox3);
            addPlayer(textBox4);
            addPlayer(textBox5);
            addPlayer(textBox6);
            addPlayer(textBox7);
            addPlayer(textBox8);

            this.Hide();

            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();

        }
    }
}