using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void DisplayHTMLInPanel(string HTML, Panel Panel)
        {
            WebBrowser browser = new WebBrowser
            {
                Dock = DockStyle.Fill,
            };
            Panel.Controls.Add(browser);
            browser.DocumentText = HTML;
        }
    }
}
