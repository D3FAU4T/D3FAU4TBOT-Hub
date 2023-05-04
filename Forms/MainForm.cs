using System;
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

        private void CustomizeDesign()
        {
            HomeSubMenu.Visible = false;
        }

        private void HideSubMenus()
        {
            if (HomeSubMenu.Visible) 
                HomeSubMenu.Visible = false;
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
    }
}
