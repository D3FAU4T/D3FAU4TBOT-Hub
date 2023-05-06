using CefSharp.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub.Forms
{
    public partial class EditorForm : Form
    {
        private ChromiumWebBrowser ChromiumBrowser;
        public Uri EditorHTMLUri = new Uri(Path.Combine(Application.StartupPath, "Assets\\Editor.html"), UriKind.RelativeOrAbsolute);
        private long DiscordId;

        public EditorForm(bool IsLoggedIn, ChromiumWebBrowser Browser, long DiscordID)
        {
            InitializeComponent();
            this.DiscordId = DiscordID;
            ChromiumBrowser = Browser;
            PirateLoginCheck(IsLoggedIn);
        }

        private void PirateLoginCheck(bool IsLoggedIn)
        {
            if (IsLoggedIn && DiscordId != 0)
            {
                ModifyScript(this.DiscordId);
                IconBoxEditor.Visible = false;
                GreetLineEditor.Visible = false;
                BrandLabelEditor.Visible = false;
                this.BackColor = Color.White;
                if (EditorHTMLUri.IsFile)
                {
                    DisplayHTMLInPanel(EditorHTMLUri.AbsoluteUri, EditorPanel);
                }

                else
                {
                    MessageBox.Show("Error: File path must not contain any symbol");
                }
            }
        }

        private void ModifyScript(long DiscordId)
        {
            string Script = File.ReadAllText(Path.Combine(Application.StartupPath, "Assets\\script.js"));
            File.WriteAllText(Path.Combine(Application.StartupPath, "Assets\\scriptModified.js"), Script.Replace("System", DiscordId.ToString()));            
        }

        private void DisplayHTMLInPanel(string HTMLPath, Panel Panel)
        {
            ChromiumBrowser.Dock = DockStyle.Fill;
            Panel.Controls.Add(ChromiumBrowser);
            ChromiumBrowser.Load(HTMLPath);
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChromiumBrowser.Dock = DockStyle.None;
            EditorPanel.Controls.Remove(ChromiumBrowser);            
        }
    }
}
