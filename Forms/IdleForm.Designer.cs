namespace D3FAU4TBOT_Hub
{
    partial class IdleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdleForm));
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.GreetLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IconBox
            // 
            this.IconBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IconBox.Image = ((System.Drawing.Image)(resources.GetObject("IconBox.Image")));
            this.IconBox.Location = new System.Drawing.Point(287, 162);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(155, 145);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconBox.TabIndex = 3;
            this.IconBox.TabStop = false;
            // 
            // BrandLabel
            // 
            this.BrandLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Play", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.BrandLabel.Location = new System.Drawing.Point(257, 307);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(216, 40);
            this.BrandLabel.TabIndex = 4;
            this.BrandLabel.Text = "D3FAU4TBOT";
            // 
            // GreetLine
            // 
            this.GreetLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GreetLine.AutoSize = true;
            this.GreetLine.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetLine.ForeColor = System.Drawing.Color.Gainsboro;
            this.GreetLine.Location = new System.Drawing.Point(308, 347);
            this.GreetLine.Name = "GreetLine";
            this.GreetLine.Size = new System.Drawing.Size(116, 21);
            this.GreetLine.TabIndex = 5;
            this.GreetLine.Text = "AHOY, Matey!";
            // 
            // IdleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(730, 530);
            this.Controls.Add(this.IconBox);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.GreetLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IdleForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label GreetLine;
    }
}