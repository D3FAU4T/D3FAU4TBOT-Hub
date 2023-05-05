namespace D3FAU4TBOT_Hub.Forms
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.GreetLineEditor = new System.Windows.Forms.Label();
            this.BrandLabelEditor = new System.Windows.Forms.Label();
            this.IconBoxEditor = new System.Windows.Forms.PictureBox();
            this.EditorPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IconBoxEditor)).BeginInit();
            this.EditorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GreetLineEditor
            // 
            this.GreetLineEditor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GreetLineEditor.AutoSize = true;
            this.GreetLineEditor.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetLineEditor.ForeColor = System.Drawing.Color.Gainsboro;
            this.GreetLineEditor.Location = new System.Drawing.Point(132, 327);
            this.GreetLineEditor.Name = "GreetLineEditor";
            this.GreetLineEditor.Size = new System.Drawing.Size(454, 63);
            this.GreetLineEditor.TabIndex = 5;
            this.GreetLineEditor.Text = "Aye, me bucko!\r\nYe need a proper login to hoist the mainsail on this editor.\r\nDon" +
    "\'t be a landlubber, log in like a proper pirate!";
            this.GreetLineEditor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrandLabelEditor
            // 
            this.BrandLabelEditor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrandLabelEditor.AutoSize = true;
            this.BrandLabelEditor.Font = new System.Drawing.Font("Play", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLabelEditor.ForeColor = System.Drawing.Color.Gainsboro;
            this.BrandLabelEditor.Location = new System.Drawing.Point(249, 287);
            this.BrandLabelEditor.Name = "BrandLabelEditor";
            this.BrandLabelEditor.Size = new System.Drawing.Size(216, 40);
            this.BrandLabelEditor.TabIndex = 4;
            this.BrandLabelEditor.Text = "D3FAU4TBOT";
            // 
            // IconBoxEditor
            // 
            this.IconBoxEditor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IconBoxEditor.Image = ((System.Drawing.Image)(resources.GetObject("IconBoxEditor.Image")));
            this.IconBoxEditor.Location = new System.Drawing.Point(279, 142);
            this.IconBoxEditor.Name = "IconBoxEditor";
            this.IconBoxEditor.Size = new System.Drawing.Size(155, 145);
            this.IconBoxEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconBoxEditor.TabIndex = 3;
            this.IconBoxEditor.TabStop = false;
            // 
            // EditorPanel
            // 
            this.EditorPanel.Controls.Add(this.IconBoxEditor);
            this.EditorPanel.Controls.Add(this.BrandLabelEditor);
            this.EditorPanel.Controls.Add(this.GreetLineEditor);
            this.EditorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorPanel.Location = new System.Drawing.Point(0, 0);
            this.EditorPanel.Name = "EditorPanel";
            this.EditorPanel.Size = new System.Drawing.Size(714, 491);
            this.EditorPanel.TabIndex = 0;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.EditorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditorForm";
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.IconBoxEditor)).EndInit();
            this.EditorPanel.ResumeLayout(false);
            this.EditorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GreetLineEditor;
        private System.Windows.Forms.Label BrandLabelEditor;
        private System.Windows.Forms.PictureBox IconBoxEditor;
        private System.Windows.Forms.Panel EditorPanel;
    }
}