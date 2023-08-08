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

        private void AddPlayers()
        {
            for (int i = 1; i <= 8; i++)
            {
                TextBox textBox = Controls.Find($"textBox{i}", true).FirstOrDefault() as TextBox;
                if (textBox.Text != "" && textBox.Text != " ")
                {
                    _players.Add(textBox.Text);
                }
            }
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            AddPlayers();

            this.Hide();

            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();

        }
        private void btnOpenTask_Click(object sender, EventArgs e)
        {
            string filePath = "Task.txt";
            OpenFileWithDefaultApp(filePath);
        }

        private void btnOpenJudgement_Click(object sender, EventArgs e)
        {
            string filePath = "Judgement.txt";
            OpenFileWithDefaultApp(filePath);
        }
    }
}