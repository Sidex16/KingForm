using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace KingForm
{
    public partial class GameForm : Form
    {
        private static List<int> _numbers = new List<int>();
        private static List<Label> _lblPlayers = new List<Label>();
        private static List<Label> _lblNumbers = new List<Label>();
        private static bool _isGameStarted = false;
        private static bool _isNumbersShown = false;
        private static bool _isJudgementShown = false;
        private static bool _isTaskShown = false;
        private static bool _abilityToDelete = false;
        public GameForm()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void UniqueNumbers()
        {
            Random rand = new Random();
            for (int i = 0; i < Form1.Players.Count;)
            {
                bool tut = false;
                int r = rand.Next(0, Form1.Players.Count);

                for (int j = 0; j < i; j++)
                {
                    if (_numbers[j] == r)
                    {
                        tut = true;
                        break;
                    }
                }

                if (!tut)
                {
                    if (i < _numbers.Count)
                    {
                        _numbers[i] = r;
                    }
                    else
                    {
                        _numbers.Add(r);
                    }

                    i++;
                }
            }
        }
        private void FindKing()
        {
            Color defaultColor = Color.FromArgb(0, 192, 192);
            _numbers.Clear();
            UniqueNumbers();
            for (int i = 0; i < Form1.Players.Count(); i++)
            {
                if (_numbers[i] == 0)
                {
                    _lblPlayers[i].ForeColor = Color.SlateGray;
                }
                else
                {
                    _lblPlayers[i].ForeColor = defaultColor;
                }
            }
        }
        private void UpdateNumbers()
        {
            int temp = 0, tempI = 0;
            for (int i = 0; i < Form1.Players.Count(); i++)
            {
                if (_numbers[i] == 0)
                {
                    tempI = i;
                }
            }
            UniqueNumbers();
            for (int i = 0; i < Form1.Players.Count(); i++)
            {
                if (_numbers[i] == 0)
                {
                    temp = _numbers[tempI];
                    _numbers[tempI] = 0;
                    _numbers[i] = temp;
                }

            }
        }
        private void ShowKing()
        {
            for (int i = 0; i < Form1.Players.Count(); i++)
            {
                if (_numbers[i] == 0)
                {
                    lblKing.Text = $"{Form1.Players[i]} - Король";
                }
            }
        }
        private void LblPlayersFill()
        {
            for (int i = 1; i <= 8; i++)
            {
                Label lbl = Controls.Find($"lblPlayer{i}", true).FirstOrDefault() as Label;
                _lblPlayers.Add(lbl);

            }
        }
        private void LblNumbersFill()
        {
            for (int i = 1; i <= 8; i++)
            {
                Label lbl = Controls.Find($"lblNumber{i}", true).FirstOrDefault() as Label;
                _lblNumbers.Add(lbl);
            }
        }
        private void RenameLbls(List<Label> list)
        {
            for (int i = 0; i < Form1.Players.Count(); i++)
            {

                if (!list[i].Visible)
                {
                    list[i].Show();
                }
                list[i].Text = Form1.Players[i];
            }
        }
        private void RenameLblNumbers()
        {
            for (int i = 0; i < Form1.Players.Count(); i++)
            {
                if (_numbers[i] == 0)
                {
                    _lblNumbers[i].Text = "";
                    continue;
                }
                _lblNumbers[i].Text = _numbers[i].ToString();
            }
        }
        private void HideNumbers()
        {
            for (int i = 0; i < _lblNumbers.Count(); i++)
            {
                _lblNumbers[i].Text = "";
            }
        }
        private void ShowRandomJudgement()
        {
            Random rand = new Random();

            string[] judgements = File.ReadAllLines("Judgement.txt");
            lblJudgement.Text = judgements[rand.Next(judgements.Count())];
            lblJudgement.Show();


        }
        private void ShowRandomTask()
        {
            Random rand = new Random();

            string[] tasks = File.ReadAllLines("Task.txt");
            lblTask.Text = tasks[rand.Next(tasks.Count())];
            lblTask.Show();
        }
        private void HideDots()
        {
            for (int i = 0; i < _lblPlayers.Count(); i++)
            {
                if (_lblPlayers[i].Text == "..." || !_lblPlayers[i].Visible)
                {
                    _lblPlayers[i].Hide();
                    _lblNumbers[i].Hide();
                }
                else
                {
                    _lblPlayers[i].Show();
                    _lblNumbers[i].Show();
                }

            }
        }
        private void PerformAction()
        {
            _isGameStarted = true;

            HideNumbers();
            ShowKing();

            lblInfo.Hide();
            pbxPlay.Show();
            pbxShow.Show();
            pbxReroll.Show();
            pbxJudgement.Show();
            pbxTask.Show();
            pbxAddPlayer.Show();
            pbxDeletePlayer.Show();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            LblNumbersFill();
            LblPlayersFill();
            RenameLbls(_lblPlayers);
            FindKing();
            HideDots();

            pbxPlay.Hide();
            pbxShow.Hide();
            pbxReroll.Hide();
            pbxJudgement.Hide();
            lblJudgement.Hide();
            pbxTask.Hide();
            lblTask.Hide();
            tbxInputPlayer.Hide();
            lblCancel.Hide();
            lblConfirm.Hide();
            pbxAddPlayer.Hide();
            pbxDeletePlayer.Hide();
        }
        private void pbxShow_Click(object sender, EventArgs e)
        {
            if (_isGameStarted)
            {
                HideDots();
                _isNumbersShown = true;
                for (int i = 0; i < _lblPlayers.Count(); i++)
                {
                    if (_lblPlayers[i].Text != "...")
                    {
                        RenameLblNumbers();
                    }
                    else
                    {
                        _lblPlayers[i].Hide();
                        _lblNumbers[i].Hide();
                    }
                }
            }
        }
        private void pbxReroll_Click(object sender, EventArgs e)
        {
            if (_isGameStarted && _isNumbersShown)
            {
                HideNumbers();
                UpdateNumbers();
                RenameLblNumbers();
            }

        }
        private void pbxPlay_Click(object sender, EventArgs e)
        {
            _isNumbersShown = false;
            _isJudgementShown = false;
            _isTaskShown = false;

            HideNumbers();
            FindKing();
            ShowKing();

            lblJudgement.Hide();
            lblTask.Hide();
        }
        private void pbxJudgement_Click(object sender, EventArgs e)
        {
            if (!_isJudgementShown)
            {
                ShowRandomJudgement();
                _isJudgementShown = true;
            }
        }
        private void pbxTask_Click(object sender, EventArgs e)
        {
            if (!_isTaskShown)
            {
                ShowRandomTask();
                _isTaskShown = true;
            }
        }
        private void pbxAddPlayer_Click(object sender, EventArgs e)
        {
            if (Form1.Players.Count < 8)
            {
                lblInfo.Text = "Введіть нового гравця*";
                lblInfo.Show();
                tbxInputPlayer.Show();
                lblConfirm.Show();
                lblCancel.Show();
            }
            else
                MessageBox.Show("В грі максимальна кількість гравців!");
        }
        private void lblConfirm_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (tbxInputPlayer.Text != "" && tbxInputPlayer.Text != " ")
            {
                Form1.Players.Add(tbxInputPlayer.Text);
                _numbers.Add(rand.Next(8));
                RenameLbls(_lblPlayers);
                UpdateNumbers();
            }
            tbxInputPlayer.Hide();
            lblCancel.Hide();
            lblConfirm.Hide();
            lblInfo.Hide();
            tbxInputPlayer.Text = "";
        }
        private void lblCancel_Click(object sender, EventArgs e)
        {
            tbxInputPlayer.Hide();
            lblCancel.Hide();
            lblConfirm.Hide();
            lblInfo.Hide();
            tbxInputPlayer.Text = "";
        }
        private void pbxDeletePlayer_Click(object sender, EventArgs e)
        {
            _abilityToDelete = true;
            lblInfo.Text = "Нажміть на гравця, якого хочете видалити*";
            lblInfo.Show();
        }
        private void lblPlayers_Click(object sender, EventArgs e)
        {
            if (_abilityToDelete)
            {
                for (int i = 0; i < Form1.Players.Count(); i++)
                {
                    if (sender == _lblPlayers[i])
                    {
                        Form1.Players.RemoveAt(i);
                        _numbers.RemoveAt(i);
                        _lblPlayers[Form1.Players.Count()].Hide();
                        _lblNumbers[Form1.Players.Count()].Hide();
                        RenameLbls(_lblPlayers);
                        break;
                    }
                }
                _abilityToDelete = false;
                lblInfo.Hide();
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformAction();
            }
        }

    }
}
