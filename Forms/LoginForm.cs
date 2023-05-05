using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub
{
    public partial class LoginForm : Form
    {
        public long DiscordID { get; private set; }
        public event EventHandler LoggedIn;
        public bool StayLoggedIn = false;

        public LoginForm()
        {
            InitializeComponent();            
        }        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (DiscordID != 0)
            {
                Config ConfigData = new Config
                {
                    DiscordID = this.DiscordID.ToString(),
                    StayLoggedIn = this.StayLoggedIn
                };

                string ConfigJson = JsonConvert.SerializeObject(ConfigData);
                File.WriteAllText(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "D3FAU4TBOT Hub"), "Config.json"), ConfigJson);

                MessageBox.Show("Login Successful");                
                this.LoggedIn?.Invoke(this, EventArgs.Empty);
                LoginTextBox.TextChanged -= LoginTextBox_TextChanged;
            }

            else
            {
                MessageBox.Show("Invalid User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(LoginTextBox.Text, out long discordId))
            {
                DiscordID = discordId;
            }
        }

        private void StayLoggedInCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StayLoggedInCheckBox.Checked) { StayLoggedIn = true; }
            else { StayLoggedIn = false; }
        }
    }
}