using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private string currentPlayer;
        private List<Player> players;
        private string activePlayer;

        public Form1(List<Player> players, string activePlayer) : base()
        {
            InitializeComponent();
            this.players = players;
            this.activePlayer = activePlayer;
          
        }
        public Form1()
        {
            InitializeComponent();
            currentPlayer = "X";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "TIC-TAC-TOE", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login(players);
                loginForm.Show();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
            lblXScore.Text = "0";
            lblOScore.Text = "0";
        }

        private void button_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button1_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button3_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button4_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button5_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button6_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button7_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button8_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button9_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentPlayer = "X";
        }

        private void ButtonClick(object sender)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                button.Text = currentPlayer;
                if (CheckForWinner())
                {
                    if (currentPlayer == "X")
                    {
                        lblXScore.Text = (Int32.Parse(lblXScore.Text) + 1).ToString();
                    }
                    else
                    {
                        lblOScore.Text = (Int32.Parse(lblOScore.Text) + 1).ToString();
                    }
                    MessageBox.Show(currentPlayer + " wins!");
                    ResetGame();
                }
                else if (IsBoardFull())
                {
                    MessageBox.Show("It's a draw!");
                    ResetGame();
                }
                else
                {
                    currentPlayer = currentPlayer == "X" ? "O" : "X";
                }
            }
        }

        private bool CheckForWinner()
        {
            {
                if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
                    (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") ||
                    (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != ""))
                {
                    return true;
                }

                if ((button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
                    (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
                    (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != ""))
                {
                    return true;
                }

                if ((button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
                    (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != ""))
                {
                    return true;
                }

                return false;
            }
        }

        private bool IsBoardFull()
        {
            return !(button1.Text == "" || button2.Text == "" || button3.Text == "" ||
                     button4.Text == "" || button5.Text == "" || button6.Text == "" ||
                     button7.Text == "" || button8.Text == "" || button9.Text == "");
        }

        private void ResetGame()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            currentPlayer = "X";
        }
    }
}
