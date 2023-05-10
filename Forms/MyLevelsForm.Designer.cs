namespace D3FAU4TBOT_Hub.Forms
{
    partial class MyLevelsForm
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
            this.LevelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExplorerBrowser = new System.Windows.Forms.WebBrowser();
            this.SyncWithServerButton = new System.Windows.Forms.Button();
            this.SyncingText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LevelName
            // 
            this.LevelName.Text = "LevelName";
            this.LevelName.Width = 100;
            // 
            // ExplorerBrowser
            // 
            this.ExplorerBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExplorerBrowser.Location = new System.Drawing.Point(12, 71);
            this.ExplorerBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.ExplorerBrowser.Name = "ExplorerBrowser";
            this.ExplorerBrowser.Size = new System.Drawing.Size(690, 408);
            this.ExplorerBrowser.TabIndex = 0;
            // 
            // SyncWithServerButton
            // 
            this.SyncWithServerButton.Location = new System.Drawing.Point(12, 24);
            this.SyncWithServerButton.Name = "SyncWithServerButton";
            this.SyncWithServerButton.Size = new System.Drawing.Size(96, 23);
            this.SyncWithServerButton.TabIndex = 1;
            this.SyncWithServerButton.Text = "Sync with server";
            this.SyncWithServerButton.UseVisualStyleBackColor = true;
            this.SyncWithServerButton.Click += new System.EventHandler(this.SyncWithServerButton_Click);
            // 
            // SyncingText
            // 
            this.SyncingText.AutoSize = true;
            this.SyncingText.ForeColor = System.Drawing.Color.Gainsboro;
            this.SyncingText.Location = new System.Drawing.Point(123, 29);
            this.SyncingText.Name = "SyncingText";
            this.SyncingText.Size = new System.Drawing.Size(54, 13);
            this.SyncingText.TabIndex = 2;
            this.SyncingText.Text = "Syncing...";
            this.SyncingText.Visible = false;
            // 
            // MyLevelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.SyncingText);
            this.Controls.Add(this.SyncWithServerButton);
            this.Controls.Add(this.ExplorerBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyLevelsForm";
            this.Text = "MyLevelsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader LevelName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.WebBrowser ExplorerBrowser;
        private System.Windows.Forms.Button SyncWithServerButton;
        private System.Windows.Forms.Label SyncingText;
    }
}