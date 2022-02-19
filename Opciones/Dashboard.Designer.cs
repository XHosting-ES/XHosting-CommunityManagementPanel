namespace XHostingCommunityPanel.Opciones
{
    partial class Dashboard
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
            this.changelogWebLabel = new System.Windows.Forms.Label();
            this.changelog_web1Label = new System.Windows.Forms.Label();
            this.changelog_web2Label = new System.Windows.Forms.Label();
            this.explicacionLabel = new System.Windows.Forms.Label();
            this.changelogAppLabel = new System.Windows.Forms.Label();
            this.changelog_app1Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changelogWebLabel
            // 
            this.changelogWebLabel.AutoSize = true;
            this.changelogWebLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelogWebLabel.ForeColor = System.Drawing.Color.White;
            this.changelogWebLabel.Location = new System.Drawing.Point(0, 0);
            this.changelogWebLabel.Name = "changelogWebLabel";
            this.changelogWebLabel.Size = new System.Drawing.Size(244, 29);
            this.changelogWebLabel.TabIndex = 0;
            this.changelogWebLabel.Text = "CHANGELOG: WEB";
            this.changelogWebLabel.Click += new System.EventHandler(this.changelogLabel_Click);
            // 
            // changelog_web1Label
            // 
            this.changelog_web1Label.AutoSize = true;
            this.changelog_web1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelog_web1Label.ForeColor = System.Drawing.Color.White;
            this.changelog_web1Label.Location = new System.Drawing.Point(2, 62);
            this.changelog_web1Label.Name = "changelog_web1Label";
            this.changelog_web1Label.Size = new System.Drawing.Size(191, 20);
            this.changelog_web1Label.TabIndex = 1;
            this.changelog_web1Label.Text = "- Mejora de estabilidad";
            // 
            // changelog_web2Label
            // 
            this.changelog_web2Label.AutoSize = true;
            this.changelog_web2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelog_web2Label.ForeColor = System.Drawing.Color.White;
            this.changelog_web2Label.Location = new System.Drawing.Point(2, 93);
            this.changelog_web2Label.Name = "changelog_web2Label";
            this.changelog_web2Label.Size = new System.Drawing.Size(555, 20);
            this.changelog_web2Label.TabIndex = 2;
            this.changelog_web2Label.Text = "- Ya no hay errores al ejecutar comandos en servers de STEAMCMD";
            // 
            // explicacionLabel
            // 
            this.explicacionLabel.AutoSize = true;
            this.explicacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explicacionLabel.ForeColor = System.Drawing.Color.White;
            this.explicacionLabel.Location = new System.Drawing.Point(12, 332);
            this.explicacionLabel.Name = "explicacionLabel";
            this.explicacionLabel.Size = new System.Drawing.Size(768, 32);
            this.explicacionLabel.TabIndex = 4;
            this.explicacionLabel.Text = "Buenas al usuario, esta app sirve para que podais comprar vuestro servidor y esta" +
    "r al tanto de las novedades\r\nde la pagina web y de la propia app";
            // 
            // changelogAppLabel
            // 
            this.changelogAppLabel.AutoSize = true;
            this.changelogAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelogAppLabel.ForeColor = System.Drawing.Color.White;
            this.changelogAppLabel.Location = new System.Drawing.Point(0, 165);
            this.changelogAppLabel.Name = "changelogAppLabel";
            this.changelogAppLabel.Size = new System.Drawing.Size(237, 29);
            this.changelogAppLabel.TabIndex = 5;
            this.changelogAppLabel.Text = "CHANGELOG: APP";
            // 
            // changelog_app1Label
            // 
            this.changelog_app1Label.AutoSize = true;
            this.changelog_app1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelog_app1Label.ForeColor = System.Drawing.Color.White;
            this.changelog_app1Label.Location = new System.Drawing.Point(265, 172);
            this.changelog_app1Label.Name = "changelog_app1Label";
            this.changelog_app1Label.Size = new System.Drawing.Size(150, 20);
            this.changelog_app1Label.TabIndex = 6;
            this.changelog_app1Label.Text = "PROXIMAMENTE";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changelog_app1Label);
            this.Controls.Add(this.changelogAppLabel);
            this.Controls.Add(this.explicacionLabel);
            this.Controls.Add(this.changelog_web2Label);
            this.Controls.Add(this.changelog_web1Label);
            this.Controls.Add(this.changelogWebLabel);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changelogWebLabel;
        private System.Windows.Forms.Label changelog_web1Label;
        private System.Windows.Forms.Label changelog_web2Label;
        private System.Windows.Forms.Label explicacionLabel;
        private System.Windows.Forms.Label changelogAppLabel;
        private System.Windows.Forms.Label changelog_app1Label;
    }
}