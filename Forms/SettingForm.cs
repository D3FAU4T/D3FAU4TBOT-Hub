using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub.Forms
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            SetRichText();
        }

        private void SetRichText()
        {
            // Load the changelog from a resource or file
            string changelog =
                "# Version 0.1.0 - May 1, 2022\r\n- Added feature 1\r\n- Added feature 2\r\n- Fixed bug 1\r\n\r\n# Version 0.2.0 - June 1, 2022\r\n- Added feature 3\r\n- Fixed bug 2\r\n- Improved performance";

            // Set the text of the RichTextBox control to the changelog
            ChangelogTextBox.Text = changelog;

            // Format the text as needed, for example, make the version numbers bold
            foreach (Match match in Regex.Matches(changelog, @"^\s*#(.+)$", RegexOptions.Multiline))
            {
                int startIndex = match.Index;
                int length = match.Length;
                ChangelogTextBox.SelectionStart = startIndex;
                ChangelogTextBox.SelectionLength = length;
                ChangelogTextBox.SelectionFont = new Font(ChangelogTextBox.Font, FontStyle.Bold);
                ChangelogTextBox.SelectionColor = Color.Blue;
            }

            // Format the list items as bullet points
            foreach (Match match in Regex.Matches(changelog, @"^- (.+)$", RegexOptions.Multiline))
            {
                int startIndex = match.Index;
                ChangelogTextBox.SelectionStart = startIndex;
                ChangelogTextBox.SelectionLength = 1;
                ChangelogTextBox.SelectionBullet = true;
            }
        }
    }
}
