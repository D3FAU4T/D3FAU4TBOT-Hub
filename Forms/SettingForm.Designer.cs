namespace D3FAU4TBOT_Hub.Forms
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckForUpdatesButton = new System.Windows.Forms.Button();
            this.UpdateHeader = new System.Windows.Forms.Label();
            this.UpdateText = new System.Windows.Forms.Label();
            this.ChangelogHeader = new System.Windows.Forms.Label();
            this.ChangelogTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CheckForUpdatesButton
            // 
            this.CheckForUpdatesButton.BackColor = System.Drawing.Color.Fuchsia;
            this.CheckForUpdatesButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.CheckForUpdatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckForUpdatesButton.ForeColor = System.Drawing.Color.White;
            this.CheckForUpdatesButton.Location = new System.Drawing.Point(53, 120);
            this.CheckForUpdatesButton.Name = "CheckForUpdatesButton";
            this.CheckForUpdatesButton.Size = new System.Drawing.Size(107, 23);
            this.CheckForUpdatesButton.TabIndex = 0;
            this.CheckForUpdatesButton.Text = "Check for updates";
            this.CheckForUpdatesButton.UseVisualStyleBackColor = false;
            this.CheckForUpdatesButton.Click += new System.EventHandler(this.CheckForUpdatesButton_Click);
            // 
            // UpdateHeader
            // 
            this.UpdateHeader.AutoSize = true;
            this.UpdateHeader.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateHeader.ForeColor = System.Drawing.Color.Gainsboro;
            this.UpdateHeader.Location = new System.Drawing.Point(49, 53);
            this.UpdateHeader.Name = "UpdateHeader";
            this.UpdateHeader.Size = new System.Drawing.Size(82, 24);
            this.UpdateHeader.TabIndex = 1;
            this.UpdateHeader.Text = "Update:";
            // 
            // UpdateText
            // 
            this.UpdateText.AutoSize = true;
            this.UpdateText.ForeColor = System.Drawing.Color.Gainsboro;
            this.UpdateText.Location = new System.Drawing.Point(50, 95);
            this.UpdateText.Name = "UpdateText";
            this.UpdateText.Size = new System.Drawing.Size(198, 13);
            this.UpdateText.TabIndex = 2;
            this.UpdateText.Text = "D3FAU4TBOT Hub is already up to date";
            // 
            // ChangelogHeader
            // 
            this.ChangelogHeader.AutoSize = true;
            this.ChangelogHeader.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangelogHeader.ForeColor = System.Drawing.Color.Gainsboro;
            this.ChangelogHeader.Location = new System.Drawing.Point(49, 164);
            this.ChangelogHeader.Name = "ChangelogHeader";
            this.ChangelogHeader.Size = new System.Drawing.Size(110, 24);
            this.ChangelogHeader.TabIndex = 3;
            this.ChangelogHeader.Text = "Changelog:";
            // 
            // ChangelogTextBox
            // 
            this.ChangelogTextBox.BackColor = System.Drawing.Color.Blue;
            this.ChangelogTextBox.ForeColor = System.Drawing.Color.White;
            this.ChangelogTextBox.Location = new System.Drawing.Point(53, 207);
            this.ChangelogTextBox.Name = "ChangelogTextBox";
            this.ChangelogTextBox.ReadOnly = true;
            this.ChangelogTextBox.Size = new System.Drawing.Size(592, 217);
            this.ChangelogTextBox.TabIndex = 4;
            this.ChangelogTextBox.Text = "";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.ChangelogTextBox);
            this.Controls.Add(this.ChangelogHeader);
            this.Controls.Add(this.UpdateText);
            this.Controls.Add(this.UpdateHeader);
            this.Controls.Add(this.CheckForUpdatesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckForUpdatesButton;
        private System.Windows.Forms.Label UpdateHeader;
        private System.Windows.Forms.Label UpdateText;
        private System.Windows.Forms.Label ChangelogHeader;
        private System.Windows.Forms.RichTextBox ChangelogTextBox;
    }
}