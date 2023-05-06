using Octokit;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub.Forms
{
    public partial class SettingForm : Form
    {        
        private bool UpdateAvailableBool = false;
        private Release GlobalRelease;
        private string ConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "D3FAU4TBOT Hub");

        public SettingForm(bool IsUpdateAvailable, Release LatestRelease)
        {
            InitializeComponent();
            UpdateAvailableBool = IsUpdateAvailable;
            GlobalRelease = LatestRelease;
            UpdateAvailable(IsUpdateAvailable, LatestRelease);
            SetRichText();
        }

        private void SetRichText()
        {
            string Changelog = File.ReadAllText(Path.Combine(ConfigPath, "Changelog.md"));
            ChangelogTextBox.Text = Changelog;

            foreach (Match match in Regex.Matches(Changelog, @"^\s*#(.+)$", RegexOptions.Multiline))
            {
                int startIndex = match.Index;
                int length = match.Length;
                ChangelogTextBox.SelectionStart = startIndex;
                ChangelogTextBox.SelectionLength = length;
                ChangelogTextBox.SelectionFont = new Font(ChangelogTextBox.Font, FontStyle.Bold);
                ChangelogTextBox.SelectionColor = Color.LimeGreen;
            }

            foreach (Match match in Regex.Matches(Changelog, @"^- (.+)$", RegexOptions.Multiline))
            {
                int startIndex = match.Index;
                ChangelogTextBox.SelectionStart = startIndex;
                ChangelogTextBox.SelectionLength = 1;
                ChangelogTextBox.SelectionBullet = true;
            }
        }

        private void UpdateAvailable(bool UpdateAvailable, Release LatestRelease)
        {
            if (UpdateAvailable)
            {
                CheckForUpdatesButton.Text = "Download";
                UpdateText.Text = "Update available. Please download latest version from https://github.com/D3FAU4T/D3FAU4TBOT-Hub/releases";
                File.WriteAllText(Path.Combine(ConfigPath, "Changelog.md"), LatestRelease.Body);
                SetRichText();
            }

            else
            {
                UpdateText.Text = "D3FAU4TBOT Hub is already up to date";
                CheckForUpdatesButton.Text = "Check for updates";
            }
        }

        private void CheckForUpdatesButton_Click(object sender, System.EventArgs e)
        {
            if (UpdateAvailableBool)
            {
                Process.Start("https://github.com/D3FAU4T/D3FAU4TBOT-Hub/releases");
            }

            else
            {
                Config ConfigData = new Config();
                if (GlobalRelease.TagName.Replace("v", "") == ConfigData.Version)
                {
                    UpdateText.Text = "D3FAU4TBOT Hub is already up to date";
                };
            }
        }
    }
}
