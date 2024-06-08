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
    public partial class Login : Form
    {
        private Administrator admin;
        private List<Player> players;

        public Login()
        {
            InitializeComponent();
            admin = new Administrator("Kelvin", "klvn", "tornilla");
            players = new List<Player>();
        }
        public Login(List<Player> players)
        {
            InitializeComponent();
            admin = new Administrator("Kelvin", "klvn", "tornilla");
            this.players = players ?? new List<Player>();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string password = passWord.Text;

            if (admin.VerifyLogin(username, password))
            {
                MessageBox.Show("Successful login as Admin!", "Success!");
                AdminForm adminForm = new AdminForm(players);
                adminForm.Show();
                this.Hide();
            }
            else
            {
                Player player = players.Find(p => p.VerifyLogin(username, password));
                if (player != null)
                {
                    MessageBox.Show("Successful login as Player!", "Success!");
                    Form1 gameForm = new Form1(players, player.GetUserId());
                    gameForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
    }
}