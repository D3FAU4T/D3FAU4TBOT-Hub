using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub.Forms
{
    public partial class EditorForm : Form
    {
        public EditorForm(bool IsLoggedIn)
        {
            InitializeComponent();
            PirateLoginCheck(IsLoggedIn);
        }

        private void PirateLoginCheck(bool IsLoggedIn)
        {
            if (IsLoggedIn)
            {
                IconBoxEditor.Visible = false;
                GreetLineEditor.Visible = false;
                BrandLabelEditor.Visible = false;
                this.BackColor = Color.White;
            }
        }

        private void DisplayHTMLInPanel(string html, Panel panel)
        {
            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;
            panel.Controls.Add(browser);
            browser.DocumentText = html;
        }
    }
}
