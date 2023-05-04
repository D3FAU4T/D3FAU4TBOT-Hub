using System;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub
{
    public partial class LoginForm : Form
    {
        public long DiscordID = 0;
        public event EventHandler LoggedIn;

        public LoginForm()
        {
            InitializeComponent();            
        }        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (DiscordID != 0)
            {
                MessageBox.Show("Login Successful");
                this.LoggedIn?.Invoke(this, EventArgs.Empty);
            }

            else
            {
                MessageBox.Show("Invalid User ID");
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e) => long.TryParse(LoginTextBox.Text, out DiscordID);
    }
}
