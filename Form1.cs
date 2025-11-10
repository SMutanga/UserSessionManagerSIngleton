using System;
using System.Windows.Forms;

namespace UserSessionManagerSIngleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateStatus();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSessionManager.Instance.Logout();
            MessageBox.Show("Logged out!");
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            var session = UserSessionManager.Instance;

            lblStatus.Text = session.IsLoggedIn ? "Logged in" : "Not logged in";
            lblUsername.Text = $"Username: {session.Username}";
            lblRole.Text = $"Role: {session.Role}";
        }

        private void btnCheckSession_Click(object sender, EventArgs e)
        {
            var session = UserSessionManager.Instance;
            MessageBox.Show($"Check Session:\nIsLoggedIn = {session.IsLoggedIn}\nUsername = {session.Username}\nRole = {session.Role}");
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string role = txtRole.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please enter both username and role.");
                return;
            }

            UserSessionManager.Instance.Login(username, role);

            MessageBox.Show($"Logged in!\nIsLoggedIn = {UserSessionManager.Instance.IsLoggedIn}\nUsername = {UserSessionManager.Instance.Username}\nRole = {UserSessionManager.Instance.Role}");


            UpdateStatus();
        }
    }
}
