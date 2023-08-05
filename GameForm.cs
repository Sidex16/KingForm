﻿using System;
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
        private void FindKing()
        {
            Color defaultColor = Color.FromArgb(0, 192, 192);
            _numbers.Clear();
            Random rand = new Random();
            bool tut;
            int r;
            for (int i = 0; i < Form1._players.Count();)
            {
                tut = false;
                r = rand.Next(0, Form1._players.Count());
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
                    _numbers.Add(r);
                    i++;
                }
            }
            for (int i = 0; i < Form1._players.Count(); i++)
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
            for (int i = 0; i < Form1._players.Count(); i++)
            {
                if (_numbers[i] == 0)
                {
                    temp = _numbers[i];
                    tempI = i;
                }
            }
            _numbers.Clear();
            for (int i = 0; i < Form1._players.Count(); i++)
            {
                _numbers.Add(1);
            }
            Random rand = new Random();
            bool tut;
            int r;
            for (int i = 0; i < Form1._players.Count();)
            {
                tut = false;
                r = rand.Next(0, Form1._players.Count());
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
                    _numbers[i] = r;
                    i++;
                }
            }
            for (int i = 0; i < Form1._players.Count(); i++)
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
            for (int i = 0; i < Form1._players.Count(); i++)
            {
                if (_numbers[i] == 0)
                {
                    lblKing.Text = $"{Form1._players[i]} - Король";
                }
            }
        }
        private void LblPlayersFill()
        {
            _lblPlayers.Add(lblPlayer1);
            _lblPlayers.Add(lblPlayer2);
            _lblPlayers.Add(lblPlayer3);
            _lblPlayers.Add(lblPlayer4);
            _lblPlayers.Add(lblPlayer5);
            _lblPlayers.Add(lblPlayer6);
            _lblPlayers.Add(lblPlayer7);
            _lblPlayers.Add(lblPlayer8);
        }
        private void LblNumbersFill()
        {
            _lblNumbers.Add(lblNumber1);
            _lblNumbers.Add(lblNumber2);
            _lblNumbers.Add(lblNumber3);
            _lblNumbers.Add(lblNumber4);
            _lblNumbers.Add(lblNumber5);
            _lblNumbers.Add(lblNumber6);
            _lblNumbers.Add(lblNumber7);
            _lblNumbers.Add(lblNumber8);
        }
        private void RenameLblPlayers()
        {
            for (int i = 0; i < Form1._players.Count(); i++)
            {

                if (!_lblPlayers[i].Visible)
                {
                    _lblPlayers[i].Show();
                }
                _lblPlayers[i].Text = Form1._players[i];
            }
        }
        private void RenameLblNumbers()
        {
            for (int i = 0; i < Form1._players.Count(); i++)
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
        private void GameForm_Load(object sender, EventArgs e)
        {
            LblNumbersFill();
            LblPlayersFill();
            RenameLblPlayers();
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
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _isGameStarted = true;
            lblInfo.Hide();
            HideNumbers();
            ShowKing();
            pbxPlay.Show();
            pbxShow.Show();
            pbxReroll.Show();
            pbxJudgement.Show();
            pbxTask.Show();
            btnConfirm.Hide();
            pbxAddPlayer.Show();
            pbxDeletePlayer.Show();

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
            if (Form1._players.Count < 8)
            {
                lblInfo.Text = "Введіть нового гравця*";
                lblInfo.Show();
                tbxInputPlayer.Show();
                lblConfirm.Show();
                lblCancel.Show();
            }
            else
                MessageBox.Show("Перевищено ліміт гравців");
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Form1._players.Add(tbxInputPlayer.Text);
            _numbers.Add(rand.Next(8));
            RenameLblPlayers();
            UpdateNumbers();
            tbxInputPlayer.Hide();
            lblCancel.Hide();
            lblConfirm.Hide();
            tbxInputPlayer.Text = "";
            lblInfo.Hide();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            tbxInputPlayer.Hide();
            lblCancel.Hide();
            lblConfirm.Hide();
            lblInfo.Hide();
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
                for (int i = 0; i < Form1._players.Count(); i++)
                {
                    if (sender == _lblPlayers[i])
                    {
                        Form1._players.RemoveAt(i);
                        _numbers.RemoveAt(i);
                        _lblPlayers[Form1._players.Count()].Hide();
                        RenameLblPlayers();
                        break;
                    }
                }
                _abilityToDelete = false;
                lblInfo.Hide();
            }
        }
    }
}
