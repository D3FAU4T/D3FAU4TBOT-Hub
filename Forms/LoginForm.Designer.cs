namespace D3FAU4TBOT_Hub
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.DiscordIDLabel = new System.Windows.Forms.Label();
            this.StayLoggedInCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Play", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(196, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to D3FAU4TBOT";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginButton.Location = new System.Drawing.Point(220, 255);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(270, 52);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTextBox.Location = new System.Drawing.Point(301, 201);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(189, 20);
            this.LoginTextBox.TabIndex = 2;
            this.LoginTextBox.Text = "Type your Discord ID here";
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // DiscordIDLabel
            // 
            this.DiscordIDLabel.AutoSize = true;
            this.DiscordIDLabel.Font = new System.Drawing.Font("Play", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordIDLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.DiscordIDLabel.Location = new System.Drawing.Point(217, 202);
            this.DiscordIDLabel.Name = "DiscordIDLabel";
            this.DiscordIDLabel.Size = new System.Drawing.Size(74, 17);
            this.DiscordIDLabel.TabIndex = 3;
            this.DiscordIDLabel.Text = "Discord ID:";
            // 
            // StayLoggedInCheckBox
            // 
            this.StayLoggedInCheckBox.AutoSize = true;
            this.StayLoggedInCheckBox.Font = new System.Drawing.Font("Play", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StayLoggedInCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.StayLoggedInCheckBox.Location = new System.Drawing.Point(220, 227);
            this.StayLoggedInCheckBox.Name = "StayLoggedInCheckBox";
            this.StayLoggedInCheckBox.Size = new System.Drawing.Size(110, 21);
            this.StayLoggedInCheckBox.TabIndex = 4;
            this.StayLoggedInCheckBox.Text = "Stay Logged In";
            this.StayLoggedInCheckBox.UseVisualStyleBackColor = true;
            this.StayLoggedInCheckBox.CheckedChanged += new System.EventHandler(this.StayLoggedInCheckBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.StayLoggedInCheckBox);
            this.Controls.Add(this.DiscordIDLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label DiscordIDLabel;
        private System.Windows.Forms.CheckBox StayLoggedInCheckBox;
    }
}