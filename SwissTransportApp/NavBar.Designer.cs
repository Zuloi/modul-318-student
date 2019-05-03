namespace SwissTransportApp
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
            this.content = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConnectionSearch = new System.Windows.Forms.Label();
            this.StationBoard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitForms = new System.Windows.Forms.Label();
            this.navbarpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarpanel
            // 
            this.navbarpanel.BackColor = System.Drawing.Color.IndianRed;
            this.navbarpanel.Controls.Add(this.content);
            this.navbarpanel.Controls.Add(this.pictureBox1);
            this.navbarpanel.Controls.Add(this.ConnectionSearch);
            this.navbarpanel.Controls.Add(this.StationBoard);
            this.navbarpanel.Controls.Add(this.label1);
            this.navbarpanel.Controls.Add(this.ExitForms);
            this.navbarpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarpanel.Location = new System.Drawing.Point(0, 0);
            this.navbarpanel.Name = "navbarpanel";
            this.navbarpanel.Size = new System.Drawing.Size(1198, 509);
            this.navbarpanel.TabIndex = 0;
            this.navbarpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SwissTransport_MouseDown);
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.BackColor = System.Drawing.Color.White;
            this.content.Location = new System.Drawing.Point(0, 59);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1198, 450);
            this.content.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SwissTransportApp.Properties.Resources.icons8_zug_filled_100;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ConnectionSearch
            // 
            this.ConnectionSearch.AutoSize = true;
            this.ConnectionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionSearch.Location = new System.Drawing.Point(59, 18);
            this.ConnectionSearch.Name = "ConnectionSearch";
            this.ConnectionSearch.Size = new System.Drawing.Size(167, 24);
            this.ConnectionSearch.TabIndex = 6;
            this.ConnectionSearch.Text = "ConnectionSearch";
            this.ConnectionSearch.Click += new System.EventHandler(this.ConnectionSearch_Click);
            // 
            // StationBoard
            // 
            this.StationBoard.AutoSize = true;
            this.StationBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationBoard.Location = new System.Drawing.Point(248, 18);
            this.StationBoard.Name = "StationBoard";
            this.StationBoard.Size = new System.Drawing.Size(116, 24);
            this.StationBoard.TabIndex = 5;
            this.StationBoard.Text = "StationBoard";
            this.StationBoard.Click += new System.EventHandler(this.StationBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1137, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.MinimizedForms_Click);
            // 
            // ExitForms
            // 
            this.ExitForms.AutoSize = true;
            this.ExitForms.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitForms.Location = new System.Drawing.Point(1166, 0);
            this.ExitForms.Name = "ExitForms";
            this.ExitForms.Size = new System.Drawing.Size(32, 37);
            this.ExitForms.TabIndex = 1;
            this.ExitForms.Text = "x";
            this.ExitForms.Click += new System.EventHandler(this.ExitForms_Click);
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 508);
            this.Controls.Add(this.navbarpanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NavBar";
            this.Text = "SwissTransport";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SwissTransport_MouseDown);
            this.navbarpanel.ResumeLayout(false);
            this.navbarpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbarpanel;
        private System.Windows.Forms.Label ExitForms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StationBoard;
        private System.Windows.Forms.Label ConnectionSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel content;
    }
}

