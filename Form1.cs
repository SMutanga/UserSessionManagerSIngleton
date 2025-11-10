using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonExample;

namespace UserSessionManagerSIngleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateStatus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string role = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please enter both username and role.");
                return;
            }

            // Login using the Singleton
            var session = UserSessionManager.Instance;
            session.Login(username, role);

            UpdateStatus();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var session = UserSessionManager.Instance;
            session.Logout();

            UpdateStatus();
        }

        private void UpdateStatus()
        {
            var session = UserSessionManager.Instance;

            lblStatus.Text = session.IsLoggedIn ? "Logged in" : "Not logged in";
            lblUsername.Text = $"Username: {session.Username}";
            lblRole.Text = $"Role: {session.Role}";
        }
    }
}
