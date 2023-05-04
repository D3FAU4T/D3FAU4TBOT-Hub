namespace D3FAU4TBOT_Hub
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HomeSubMenu = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.GreetLine = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SideMenuPanel.SuspendLayout();
            this.HomeSubMenu.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SideMenuPanel.Controls.Add(this.ExitButton);
            this.SideMenuPanel.Controls.Add(this.HomeSubMenu);
            this.SideMenuPanel.Controls.Add(this.HomeButton);
            this.SideMenuPanel.Controls.Add(this.LogoPanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(220, 530);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.Location = new System.Drawing.Point(0, 485);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitButton.Size = new System.Drawing.Size(220, 45);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HomeSubMenu
            // 
            this.HomeSubMenu.Controls.Add(this.LoginButton);
            this.HomeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeSubMenu.Location = new System.Drawing.Point(0, 145);
            this.HomeSubMenu.Name = "HomeSubMenu";
            this.HomeSubMenu.Size = new System.Drawing.Size(220, 47);
            this.HomeSubMenu.TabIndex = 2;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.LoginButton.Location = new System.Drawing.Point(0, 0);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.LoginButton.Size = new System.Drawing.Size(220, 40);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.HomeButton.Location = new System.Drawing.Point(0, 100);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(220, 45);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(220, 100);
            this.LogoPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.IconBox);
            this.MainPanel.Controls.Add(this.BrandLabel);
            this.MainPanel.Controls.Add(this.GreetLine);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(220, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(730, 530);
            this.MainPanel.TabIndex = 1;
            // 
            // IconBox
            // 
            this.IconBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IconBox.Image = ((System.Drawing.Image)(resources.GetObject("IconBox.Image")));
            this.IconBox.Location = new System.Drawing.Point(301, 145);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(155, 145);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconBox.TabIndex = 0;
            this.IconBox.TabStop = false;
            // 
            // BrandLabel
            // 
            this.BrandLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Play", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.BrandLabel.Location = new System.Drawing.Point(271, 290);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(216, 40);
            this.BrandLabel.TabIndex = 1;
            this.BrandLabel.Text = "D3FAU4TBOT";
            // 
            // GreetLine
            // 
            this.GreetLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GreetLine.AutoSize = true;
            this.GreetLine.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetLine.ForeColor = System.Drawing.Color.Gainsboro;
            this.GreetLine.Location = new System.Drawing.Point(322, 330);
            this.GreetLine.Name = "GreetLine";
            this.GreetLine.Size = new System.Drawing.Size(116, 21);
            this.GreetLine.TabIndex = 2;
            this.GreetLine.Text = "AHOY, Matey!";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(730, 32);
            this.TopPanel.TabIndex = 3;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(950, 530);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 530);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D3FAU4TBOT Hub";
            this.SideMenuPanel.ResumeLayout(false);
            this.HomeSubMenu.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel HomeSubMenu;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label GreetLine;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel TopPanel;
    }
}

