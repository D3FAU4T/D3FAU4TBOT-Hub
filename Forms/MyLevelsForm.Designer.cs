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
            this.SuspendLayout();
            // 
            // LevelName
            // 
            this.LevelName.Text = "LevelName";
            this.LevelName.Width = 100;
            // 
            // ExplorerBrowser
            // 
            this.ExplorerBrowser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExplorerBrowser.Location = new System.Drawing.Point(12, 71);
            this.ExplorerBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.ExplorerBrowser.Name = "ExplorerBrowser";
            this.ExplorerBrowser.Size = new System.Drawing.Size(690, 408);
            this.ExplorerBrowser.TabIndex = 0;
            // 
            // MyLevelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.ExplorerBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyLevelsForm";
            this.Text = "MyLevelsForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader LevelName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.WebBrowser ExplorerBrowser;
    }
}