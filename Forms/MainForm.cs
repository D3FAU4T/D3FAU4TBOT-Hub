using CefSharp;
using CefSharp.WinForms;
using D3FAU4TBOT_Hub.Forms;
using System;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub
{
    public partial class MainForm : Form
    {
        private string ConfigFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "D3FAU4TBOT Hub");
        private ChromiumWebBrowser Browser;
        private Form ActiveForm = null;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public bool LoggedIn = false;
        private long DiscordID;
        public string Version;

        public MainForm()
        {
            InitializeComponent();
            SetupOrFetchConfig();
            InitializeBrowser();
            CustomizeDesign();
            VersionNumber.Text = $"Version: {Version}";
            if (LoggedIn)
            {
                LoginStatusText.Text = $"Login status: Logged in as\n{DiscordID}";
            }
        }

        private void SetupOrFetchConfig()
        {            
            if (!Directory.Exists(ConfigFolderPath))
            {
                Directory.CreateDirectory(ConfigFolderPath);
            }

            string ConfigFilePath = Path.Combine(ConfigFolderPath, "Config.json");

            if (File.Exists(ConfigFilePath))
            {
                string SerializedJson = File.ReadAllText(ConfigFilePath);
                Config ConfigData = JsonConvert.DeserializeObject<Config>(SerializedJson);
                Version = ConfigData.Version;
                if (ConfigData.StayLoggedIn)
                {
                    if (long.TryParse(ConfigData.DiscordID, out long discordId))
                    {
                        DiscordID = discordId;
                    }
                    LoggedIn = true;
                }
            }

            else
            {
                Config ConfigData = new Config
                {
                    DiscordID = "",
                    StayLoggedIn = false,
                };
                Version = ConfigData.Version;
                string ConfigJson = JsonConvert.SerializeObject(ConfigData);
                File.WriteAllText(ConfigFilePath, ConfigJson);
            }
        }

        private void InitializeBrowser()
        {
            CefSettings settings = new CefSettings();
            settings.CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharpCache");
            settings.UserAgent = "Custom User Agent";

            Cef.Initialize(settings);

            Browser = new ChromiumWebBrowser();
        }

        private void CustomizeDesign()
        {
            HomeSubMenu.Visible = false;
            WordsOnStreamSubMenu.Visible = false;
        }

        private void HideSubMenus()
        {
            if (HomeSubMenu.Visible) 
                HomeSubMenu.Visible = false;
            if (WordsOnStreamSubMenu.Visible)
                WordsOnStreamSubMenu.Visible = false;
        }

        private void ShowSubMenus(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenus();
                SubMenu.Visible = true;
            } 
            
            else
            {
                SubMenu.Visible = false;
            }
        }

        public void OpenChildForm(Form ChildForm)
        {
            ActiveForm?.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(ChildForm);
            MainPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ShowSubMenus(HomeSubMenu);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            OpenChildForm(LoginForm);
            LoginForm.LoggedIn += (s, ev) =>
            {
                LoggedIn = true;
                OpenChildForm(new IdleForm());
                LoginStatusText.Text = $"Login status: Logged in as\n{LoginForm.DiscordID}";
                DiscordID = LoginForm.DiscordID;

            };
        }

        private void ExitButton_Click(Object sender, EventArgs e)
        {
            Browser.Dispose();
            Cef.Shutdown();
            this.Close();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void WordsOnStreamButton_Click(object sender, EventArgs e)
        {
            ShowSubMenus(WordsOnStreamSubMenu);
        }

        private void EditorButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditorForm(LoggedIn, Browser));
        }
    }
}
