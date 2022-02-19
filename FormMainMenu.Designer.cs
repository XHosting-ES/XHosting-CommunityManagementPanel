namespace XHostingCommunityPanel
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.webLinkLabel = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.MiniminizarApp = new System.Windows.Forms.Button();
            this.MaximizarApp = new System.Windows.Forms.Button();
            this.CerrarApp = new System.Windows.Forms.Button();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnShop = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.title2Label = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.titleLabbel = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.webLinkLabel);
            this.panelMenu.Controls.Add(this.labelVersion);
            this.panelMenu.Controls.Add(this.MiniminizarApp);
            this.panelMenu.Controls.Add(this.MaximizarApp);
            this.panelMenu.Controls.Add(this.CerrarApp);
            this.panelMenu.Controls.Add(this.btnAdmin);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnShop);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(227, 631);
            this.panelMenu.TabIndex = 0;
            // 
            // webLinkLabel
            // 
            this.webLinkLabel.AutoSize = true;
            this.webLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webLinkLabel.LinkColor = System.Drawing.Color.White;
            this.webLinkLabel.Location = new System.Drawing.Point(8, 556);
            this.webLinkLabel.Name = "webLinkLabel";
            this.webLinkLabel.Size = new System.Drawing.Size(211, 16);
            this.webLinkLabel.TabIndex = 9;
            this.webLinkLabel.TabStop = true;
            this.webLinkLabel.Text = "http://87.106.125.58/auth/login";
            this.webLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.webLinkLabel_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(114, 596);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(92, 16);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "v0.1.0-Beta1";
            // 
            // MiniminizarApp
            // 
            this.MiniminizarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MiniminizarApp.FlatAppearance.BorderSize = 0;
            this.MiniminizarApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniminizarApp.ForeColor = System.Drawing.Color.White;
            this.MiniminizarApp.Location = new System.Drawing.Point(78, 596);
            this.MiniminizarApp.Name = "MiniminizarApp";
            this.MiniminizarApp.Size = new System.Drawing.Size(27, 23);
            this.MiniminizarApp.TabIndex = 7;
            this.MiniminizarApp.Text = "-";
            this.MiniminizarApp.UseVisualStyleBackColor = true;
            this.MiniminizarApp.Click += new System.EventHandler(this.MiniminizarApp_Click);
            // 
            // MaximizarApp
            // 
            this.MaximizarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MaximizarApp.FlatAppearance.BorderSize = 0;
            this.MaximizarApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizarApp.ForeColor = System.Drawing.Color.White;
            this.MaximizarApp.Location = new System.Drawing.Point(45, 596);
            this.MaximizarApp.Name = "MaximizarApp";
            this.MaximizarApp.Size = new System.Drawing.Size(27, 23);
            this.MaximizarApp.TabIndex = 6;
            this.MaximizarApp.Text = "^";
            this.MaximizarApp.UseVisualStyleBackColor = true;
            this.MaximizarApp.Click += new System.EventHandler(this.MaximizarApp_Click);
            // 
            // CerrarApp
            // 
            this.CerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CerrarApp.FlatAppearance.BorderSize = 0;
            this.CerrarApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarApp.ForeColor = System.Drawing.Color.White;
            this.CerrarApp.Location = new System.Drawing.Point(12, 596);
            this.CerrarApp.Name = "CerrarApp";
            this.CerrarApp.Size = new System.Drawing.Size(27, 23);
            this.CerrarApp.TabIndex = 2;
            this.CerrarApp.Text = "X";
            this.CerrarApp.UseVisualStyleBackColor = true;
            this.CerrarApp.Click += new System.EventHandler(this.CerrarApp_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.Wind;
            this.btnAdmin.IconColor = System.Drawing.Color.White;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 317);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdmin.Size = new System.Drawing.Size(227, 61);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "AdminPanel";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 258);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSettings.Size = new System.Drawing.Size(227, 59);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Configuracion";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnShop
            // 
            this.btnShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShop.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnShop.IconColor = System.Drawing.Color.White;
            this.btnShop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.Location = new System.Drawing.Point(0, 199);
            this.btnShop.Name = "btnShop";
            this.btnShop.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnShop.Size = new System.Drawing.Size(227, 59);
            this.btnShop.TabIndex = 3;
            this.btnShop.Text = "Billing";
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(227, 59);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.title2Label);
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(227, 140);
            this.panelLogo.TabIndex = 1;
            // 
            // title2Label
            // 
            this.title2Label.AutoSize = true;
            this.title2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title2Label.Location = new System.Drawing.Point(13, 74);
            this.title2Label.Name = "title2Label";
            this.title2Label.Size = new System.Drawing.Size(193, 16);
            this.title2Label.TabIndex = 1;
            this.title2Label.Text = "Community Management Panel";
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Location = new System.Drawing.Point(20, 37);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(184, 37);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "XHOSTING";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTitleBar.Controls.Add(this.titleLabbel);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(227, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(977, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // titleLabbel
            // 
            this.titleLabbel.AutoSize = true;
            this.titleLabbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabbel.ForeColor = System.Drawing.Color.White;
            this.titleLabbel.Location = new System.Drawing.Point(73, 37);
            this.titleLabbel.Name = "titleLabbel";
            this.titleLabbel.Size = new System.Drawing.Size(44, 16);
            this.titleLabbel.TabIndex = 1;
            this.titleLabbel.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Violet;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Violet;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(27, 26);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(227, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(977, 556);
            this.panelDesktop.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 631);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "XHOSTING-CommunityManagementPanel";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnShop;
        private System.Windows.Forms.Label title2Label;
        private System.Windows.Forms.Label btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label titleLabbel;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button MiniminizarApp;
        private System.Windows.Forms.Button MaximizarApp;
        private System.Windows.Forms.Button CerrarApp;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel webLinkLabel;
    }
}

