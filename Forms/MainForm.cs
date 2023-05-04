using D3FAU4TBOT_Hub.Forms;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private Form ActiveForm = null;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public bool LoggedIn = false;

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
            };
        }

        private void ExitButton_Click(Object sender, EventArgs e)
        {
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
            OpenChildForm(new EditorForm(LoggedIn));
        }
    }
}
