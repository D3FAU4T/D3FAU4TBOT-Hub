using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub.Forms
{
    public partial class EditorForm : Form
    {
        private static string EditorHTML = File.ReadAllText("./Assets/Editor.html")
            .Replace("stylesheet.css", Path.Combine(Application.StartupPath, "Assets\\stylesheet.css"))
            .Replace("favicon.ico", Path.Combine(Application.StartupPath, "Assets\\favicon.ico"))
            .Replace("script.js", Path.Combine(Application.StartupPath, "Assets\\script.js"));

        public EditorForm(bool IsLoggedIn)
        {
            InitializeComponent();
            MessageBox.Show(Path.Combine(Application.StartupPath, "Assets/script.js"));
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
                DisplayHTMLInPanel(EditorHTML, EditorPanel);
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
