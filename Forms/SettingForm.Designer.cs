﻿namespace D3FAU4TBOT_Hub.Forms
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
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateHeader = new System.Windows.Forms.Label();
            this.UpdateText = new System.Windows.Forms.Label();
            this.ChangelogHeader = new System.Windows.Forms.Label();
            this.ChangelogTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check for updates";
            this.button1.UseVisualStyleBackColor = true;
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
            this.ChangelogTextBox.Location = new System.Drawing.Point(53, 207);
            this.ChangelogTextBox.Name = "ChangelogTextBox";
            this.ChangelogTextBox.ReadOnly = true;
            this.ChangelogTextBox.Size = new System.Drawing.Size(592, 217);
            this.ChangelogTextBox.TabIndex = 4;
            this.ChangelogTextBox.Text = "# Version 0.1.0 - May 1, 2022\n- Added feature 1\n- Added feature 2\n- Fixed bug 1\n\n" +
    "# Version 0.2.0 - June 1, 2022\n- Added feature 3\n- Fixed bug 2\n- Improved perfor" +
    "mance";
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
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UpdateHeader;
        private System.Windows.Forms.Label UpdateText;
        private System.Windows.Forms.Label ChangelogHeader;
        private System.Windows.Forms.RichTextBox ChangelogTextBox;
    }
}