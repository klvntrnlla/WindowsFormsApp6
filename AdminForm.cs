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
    public partial class AdminForm : Form
    {
        private List<Player> players;

        public AdminForm(List<Player> players)
        {
            InitializeComponent();
            this.players = players ?? new List<Player>();
        }

        private void cupButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to sign out?", "Confirm Signout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login(players); 
                loginForm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = cupTextBoxUsername.Text;
            string password = cupTextBoxPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            Player player = new Player(username, password);
            players.Add(player);
            MessageBox.Show($"Player created successfully! Total players: {players.Count}", "Success!");

            cupTextBoxUsername.Text = "";
            cupTextBoxPass.Text = "";
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void updatePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPasswordTextBox.Text;
            string newPassword = npTextBox.Text;
            string username = usName.Text;

            Player player = players.Find(p => p.VerifyLogin(username, oldPassword));

            if (player != null)
            {
                if (players.Any(p => p.GetUserId() == username))
                {
                    player.UpdatePassword(newPassword);
                    MessageBox.Show("Password updated successfully!", "Success!");
                }
                else
                {
                    MessageBox.Show("Username not found or old password is incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Player not found or old password is incorrect.");
            }
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
