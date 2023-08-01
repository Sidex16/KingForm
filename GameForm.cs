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
        public GameForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            LblPlayersFill();
            RenameLbl();
            FindKing();
            btnNewKing.Hide();
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            lblInfo.Hide();
            ShowKing();
            btnNewKing.Show();
            confirmButton.Hide();
        }
        static void FindKing()
        {
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

        private void btnNewKing_Click(object sender, EventArgs e)
        {
            _numbers.Clear();
            FindKing();
            ShowKing();
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
        private void RenameLbl()
        {
            for (int i = 0; i < Form1._players.Count(); i++)
            {
                _lblPlayers[i].Text = Form1._players[i];
            }
        }

        private void pbxUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
