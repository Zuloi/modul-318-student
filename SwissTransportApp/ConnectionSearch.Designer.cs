namespace SwissTransportApp
{
    partial class ConnectionSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FromStation = new System.Windows.Forms.ComboBox();
            this.ToStation = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchConnection = new System.Windows.Forms.Button();
            this.DataViewGrid = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrgleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrdauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsgleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FromStation
            // 
            this.FromStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FromStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FromStation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromStation.FormattingEnabled = true;
            this.FromStation.Location = new System.Drawing.Point(149, 57);
            this.FromStation.Name = "FromStation";
            this.FromStation.Size = new System.Drawing.Size(206, 30);
            this.FromStation.TabIndex = 0;
            this.FromStation.TextChanged += new System.EventHandler(this.StationFill);
            // 
            // ToStation
            // 
            this.ToStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ToStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ToStation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToStation.FormattingEnabled = true;
            this.ToStation.Location = new System.Drawing.Point(619, 57);
            this.ToStation.Name = "ToStation";
            this.ToStation.Size = new System.Drawing.Size(181, 30);
            this.ToStation.TabIndex = 1;
            this.ToStation.TextChanged += new System.EventHandler(this.StationFill);
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(149, 102);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(119, 31);
            this.Date.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SwissTransportApp.Properties.Resources.icons8_daten_in_beide_richtungen_filled_50;
            this.pictureBox1.Location = new System.Drawing.Point(441, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SearchConnection
            // 
            this.SearchConnection.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchConnection.Location = new System.Drawing.Point(619, 102);
            this.SearchConnection.Name = "SearchConnection";
            this.SearchConnection.Size = new System.Drawing.Size(181, 32);
            this.SearchConnection.TabIndex = 7;
            this.SearchConnection.Text = "Search";
            this.SearchConnection.UseVisualStyleBackColor = true;
            this.SearchConnection.Click += new System.EventHandler(this.SearchConnection_Click);
            // 
            // DataViewGrid
            // 
            this.DataViewGrid.AllowUserToAddRows = false;
            this.DataViewGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataViewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataViewGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.DataViewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtszeit,
            this.Abfahrtsort,
            this.Fahrgleis,
            this.Fahrdauer,
            this.Ankunftsort,
            this.Ankunftsgleis});
            this.DataViewGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataViewGrid.EnableHeadersVisualStyles = false;
            this.DataViewGrid.GridColor = System.Drawing.Color.Black;
            this.DataViewGrid.Location = new System.Drawing.Point(0, 182);
            this.DataViewGrid.MultiSelect = false;
            this.DataViewGrid.Name = "DataViewGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataViewGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataViewGrid.Size = new System.Drawing.Size(1197, 301);
            this.DataViewGrid.TabIndex = 8;
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time.Location = new System.Drawing.Point(274, 103);
            this.Time.Name = "Time";
            this.Time.ShowUpDown = true;
            this.Time.Size = new System.Drawing.Size(81, 31);
            this.Time.TabIndex = 9;
            this.Time.Value = new System.DateTime(2019, 5, 16, 0, 0, 0, 0);
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.MaxInputLength = 200;
            this.Abfahrtszeit.MinimumWidth = 143;
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            this.Abfahrtszeit.Width = 170;
            // 
            // Abfahrtsort
            // 
            this.Abfahrtsort.HeaderText = "Abfahrtsort";
            this.Abfahrtsort.MaxInputLength = 260;
            this.Abfahrtsort.MinimumWidth = 260;
            this.Abfahrtsort.Name = "Abfahrtsort";
            this.Abfahrtsort.Width = 260;
            // 
            // Fahrgleis
            // 
            this.Fahrgleis.HeaderText = "Fahrgleis";
            this.Fahrgleis.MaxInputLength = 200;
            this.Fahrgleis.MinimumWidth = 140;
            this.Fahrgleis.Name = "Fahrgleis";
            this.Fahrgleis.Width = 169;
            // 
            // Fahrdauer
            // 
            this.Fahrdauer.HeaderText = "Fahrdauer";
            this.Fahrdauer.MaxInputLength = 200;
            this.Fahrdauer.MinimumWidth = 140;
            this.Fahrdauer.Name = "Fahrdauer";
            this.Fahrdauer.Width = 168;
            // 
            // Ankunftsort
            // 
            this.Ankunftsort.HeaderText = "Ankunftsort";
            this.Ankunftsort.MaxInputLength = 260;
            this.Ankunftsort.MinimumWidth = 260;
            this.Ankunftsort.Name = "Ankunftsort";
            this.Ankunftsort.Width = 260;
            // 
            // Ankunftsgleis
            // 
            this.Ankunftsgleis.HeaderText = "Ankunftsgleis";
            this.Ankunftsgleis.MaxInputLength = 203;
            this.Ankunftsgleis.MinimumWidth = 142;
            this.Ankunftsgleis.Name = "Ankunftsgleis";
            this.Ankunftsgleis.Width = 169;
            // 
            // ConnectionSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.DataViewGrid);
            this.Controls.Add(this.SearchConnection);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToStation);
            this.Controls.Add(this.FromStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionSearch";
            this.Text = "ConnectionSearch";
            this.Load += new System.EventHandler(this.ConnectionSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FromStation;
        private System.Windows.Forms.ComboBox ToStation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button SearchConnection;
        private System.Windows.Forms.DataGridView DataViewGrid;
        private System.Windows.Forms.DateTimePicker Time;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrgleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrdauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsgleis;
    }
}