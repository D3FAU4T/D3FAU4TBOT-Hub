using System;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub
{
    public partial class LoginForm : Form
    {
        public long DiscordID { get; private set; }
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
                LoginTextBox.TextChanged -= LoginTextBox_TextChanged;
            }

            else
            {
                MessageBox.Show("Invalid User ID");
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(LoginTextBox.Text, out long discordId))
            {
                DiscordID = discordId;
            }
        }
    }
}