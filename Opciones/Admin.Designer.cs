namespace XHostingCommunityPanel.Opciones
{
    partial class Admin
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.xhostingLogo = new System.Windows.Forms.PictureBox();
            this.user_managementButton = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xhostingLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelButtons.Controls.Add(this.user_managementButton);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1197, 79);
            this.panelButtons.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panelContent.Controls.Add(this.xhostingLogo);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 79);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1197, 537);
            this.panelContent.TabIndex = 1;
            // 
            // xhostingLogo
            // 
            this.xhostingLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xhostingLogo.Image = global::XHostingCommunityPanel.Properties.Resources.xhostingLOGO1;
            this.xhostingLogo.Location = new System.Drawing.Point(1100, 464);
            this.xhostingLogo.Name = "xhostingLogo";
            this.xhostingLogo.Size = new System.Drawing.Size(85, 61);
            this.xhostingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xhostingLogo.TabIndex = 1;
            this.xhostingLogo.TabStop = false;
            // 
            // user_managementButton
            // 
            this.user_managementButton.FlatAppearance.BorderSize = 0;
            this.user_managementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_managementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_managementButton.ForeColor = System.Drawing.Color.White;
            this.user_managementButton.Location = new System.Drawing.Point(474, 24);
            this.user_managementButton.Name = "user_managementButton";
            this.user_managementButton.Size = new System.Drawing.Size(191, 31);
            this.user_managementButton.TabIndex = 1;
            this.user_managementButton.Text = "User Management";
            this.user_managementButton.UseVisualStyleBackColor = true;
            this.user_managementButton.Click += new System.EventHandler(this.user_managementButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 616);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelButtons);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xhostingLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox xhostingLogo;
        private System.Windows.Forms.Button user_managementButton;
    }
}