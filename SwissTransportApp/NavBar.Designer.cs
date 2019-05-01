﻿namespace SwissTransportApp
{
    partial class NavBar
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavBar));
            this.navbarpanel = new System.Windows.Forms.Panel();
            this.ConnectionSearch = new System.Windows.Forms.Label();
            this.StationBoard = new System.Windows.Forms.Label();
            this.SwissTransportLabel = new System.Windows.Forms.Label();
            this.ZugIcon = new System.Windows.Forms.PictureBox();
            this.MaximizedForms = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitForms = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.navbarpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZugIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizedForms)).BeginInit();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbarpanel
            // 
            this.navbarpanel.BackColor = System.Drawing.Color.IndianRed;
            this.navbarpanel.Controls.Add(this.ConnectionSearch);
            this.navbarpanel.Controls.Add(this.StationBoard);
            this.navbarpanel.Controls.Add(this.SwissTransportLabel);
            this.navbarpanel.Controls.Add(this.ZugIcon);
            this.navbarpanel.Controls.Add(this.MaximizedForms);
            this.navbarpanel.Controls.Add(this.label1);
            this.navbarpanel.Controls.Add(this.ExitForms);
            this.navbarpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarpanel.Location = new System.Drawing.Point(0, 0);
            this.navbarpanel.Name = "navbarpanel";
            this.navbarpanel.Size = new System.Drawing.Size(825, 32);
            this.navbarpanel.TabIndex = 0;
            this.navbarpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SwissTransport_MouseDown);
            // 
            // ConnectionSearch
            // 
            this.ConnectionSearch.AutoSize = true;
            this.ConnectionSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionSearch.Location = new System.Drawing.Point(134, 7);
            this.ConnectionSearch.Name = "ConnectionSearch";
            this.ConnectionSearch.Size = new System.Drawing.Size(128, 17);
            this.ConnectionSearch.TabIndex = 6;
            this.ConnectionSearch.Text = "ConnectionSearch";
            this.ConnectionSearch.Click += new System.EventHandler(this.ConnectionSearch_Click);
            // 
            // StationBoard
            // 
            this.StationBoard.AutoSize = true;
            this.StationBoard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationBoard.Location = new System.Drawing.Point(268, 7);
            this.StationBoard.Name = "StationBoard";
            this.StationBoard.Size = new System.Drawing.Size(91, 17);
            this.StationBoard.TabIndex = 5;
            this.StationBoard.Text = "StationBoard";
            this.StationBoard.Click += new System.EventHandler(this.StationBoard_Click);
            // 
            // SwissTransportLabel
            // 
            this.SwissTransportLabel.AutoSize = true;
            this.SwissTransportLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwissTransportLabel.Location = new System.Drawing.Point(31, 7);
            this.SwissTransportLabel.Name = "SwissTransportLabel";
            this.SwissTransportLabel.Size = new System.Drawing.Size(97, 17);
            this.SwissTransportLabel.TabIndex = 3;
            this.SwissTransportLabel.Text = "SwissTransport";
            this.SwissTransportLabel.Click += new System.EventHandler(this.SwissTransport_Click);
            // 
            // ZugIcon
            // 
            this.ZugIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.ZugIcon.Image = global::SwissTransportApp.Properties.Resources.icons8_zug_filled_100;
            this.ZugIcon.Location = new System.Drawing.Point(0, 0);
            this.ZugIcon.Name = "ZugIcon";
            this.ZugIcon.Size = new System.Drawing.Size(25, 32);
            this.ZugIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ZugIcon.TabIndex = 2;
            this.ZugIcon.TabStop = false;
            // 
            // MaximizedForms
            // 
            this.MaximizedForms.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MaximizedForms.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizedForms.ErrorImage = global::SwissTransportApp.Properties.Resources.icons8_full_screen_filled_50;
            this.MaximizedForms.Image = global::SwissTransportApp.Properties.Resources.icons8_full_screen_filled_50;
            this.MaximizedForms.InitialImage = null;
            this.MaximizedForms.Location = new System.Drawing.Point(759, 0);
            this.MaximizedForms.Name = "MaximizedForms";
            this.MaximizedForms.Size = new System.Drawing.Size(25, 32);
            this.MaximizedForms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaximizedForms.TabIndex = 2;
            this.MaximizedForms.TabStop = false;
            this.MaximizedForms.Click += new System.EventHandler(this.MaximizedForms_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(784, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.MinimizedForms_Click);
            // 
            // ExitForms
            // 
            this.ExitForms.AutoSize = true;
            this.ExitForms.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitForms.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitForms.Location = new System.Drawing.Point(805, 0);
            this.ExitForms.Name = "ExitForms";
            this.ExitForms.Size = new System.Drawing.Size(20, 24);
            this.ExitForms.TabIndex = 1;
            this.ExitForms.Text = "x";
            this.ExitForms.Click += new System.EventHandler(this.ExitForms_Click);
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.AutoSize = true;
            this.content.Controls.Add(this.comboBox2);
            this.content.Controls.Add(this.comboBox1);
            this.content.Location = new System.Drawing.Point(0, 32);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(825, 420);
            this.content.TabIndex = 1;
            this.content.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SwissTransport_MouseDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(582, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 452);
            this.Controls.Add(this.content);
            this.Controls.Add(this.navbarpanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NavBar";
            this.Text = "SwissTransport";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SwissTransport_MouseDown);
            this.navbarpanel.ResumeLayout(false);
            this.navbarpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZugIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizedForms)).EndInit();
            this.content.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navbarpanel;
        private System.Windows.Forms.Label ExitForms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MaximizedForms;
        private System.Windows.Forms.PictureBox ZugIcon;
        private System.Windows.Forms.Label SwissTransportLabel;
        private System.Windows.Forms.Label StationBoard;
        private System.Windows.Forms.Label ConnectionSearch;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
