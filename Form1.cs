using System.Diagnostics;
using System.Runtime.InteropServices;

namespace KingForm
{
    public partial class Form1 : Form
    {
        [DllImport("shell32.dll")]
        static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

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
        private void btnOpenTask_Click(object sender, EventArgs e)
        {
            string filePath = "Task.txt";
            OpenFileWithDefaultApp(filePath);
        }
        private void OpenFileWithDefaultApp(string filePath)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = filePath;
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenJudgement_Click(object sender, EventArgs e)
        {
            string filePath = "Judgement.txt";
            OpenFileWithDefaultApp(filePath);
        }
    }
}