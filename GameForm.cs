using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void GameForm_Load(object sender, EventArgs e)
        {
            LblNumbersFill();
            LblPlayersFill();
            RenameLblPlayers();
            FindKing();
            pbxPlay.Hide();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _isGameStarted = true;
            lblInfo.Hide();
            HideNumbers();
            ShowKing();
            pbxPlay.Show();
            btnConfirm.Hide();
        }

        private void pbxShow_Click(object sender, EventArgs e)
        {
            if (_isGameStarted)
            {
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
            HideNumbers();
            FindKing();
            ShowKing();
        }


    }
}
