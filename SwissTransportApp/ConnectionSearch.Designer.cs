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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionSearch));
            this.FromStation = new System.Windows.Forms.ComboBox();
            this.ToStation = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.SearchConnection = new System.Windows.Forms.Button();
            this.DataViewGrid = new System.Windows.Forms.DataGridView();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrgleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrdauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsgleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FromLocation = new System.Windows.Forms.PictureBox();
            this.Exchange = new System.Windows.Forms.PictureBox();
            this.ToLocation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // FromStation
            // 
            this.FromStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FromStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromStation.FormattingEnabled = true;
            this.FromStation.Location = new System.Drawing.Point(149, 57);
            this.FromStation.Name = "FromStation";
            this.FromStation.Size = new System.Drawing.Size(286, 32);
            this.FromStation.TabIndex = 0;
            this.FromStation.TextChanged += new System.EventHandler(this.StationFill);
            // 
            // ToStation
            // 
            this.ToStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ToStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToStation.FormattingEnabled = true;
            this.ToStation.Location = new System.Drawing.Point(711, 57);
            this.ToStation.Name = "ToStation";
            this.ToStation.Size = new System.Drawing.Size(286, 32);
            this.ToStation.TabIndex = 1;
            this.ToStation.TextChanged += new System.EventHandler(this.StationFill);
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(149, 102);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(144, 29);
            this.Date.TabIndex = 3;
            // 
            // SearchConnection
            // 
            this.SearchConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchConnection.Location = new System.Drawing.Point(711, 95);
            this.SearchConnection.Name = "SearchConnection";
            this.SearchConnection.Size = new System.Drawing.Size(286, 32);
            this.SearchConnection.TabIndex = 7;
            this.SearchConnection.Text = "Search";
            this.SearchConnection.UseVisualStyleBackColor = true;
            this.SearchConnection.Click += new System.EventHandler(this.SearchConnection_Click);
            // 
            // DataViewGrid
            // 
            this.DataViewGrid.AllowUserToAddRows = false;
            this.DataViewGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataViewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataViewGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.DataViewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtszeit,
            this.Abfahrtsort,
            this.Fahrgleis,
            this.Fahrdauer,
            this.Ankunftsort,
            this.Ankunftsgleis});
            this.DataViewGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataViewGrid.EnableHeadersVisualStyles = false;
            this.DataViewGrid.GridColor = System.Drawing.Color.Black;
            this.DataViewGrid.Location = new System.Drawing.Point(0, 182);
            this.DataViewGrid.MultiSelect = false;
            this.DataViewGrid.Name = "DataViewGrid";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataViewGrid.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataViewGrid.Size = new System.Drawing.Size(1197, 301);
            this.DataViewGrid.TabIndex = 8;
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
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time.Location = new System.Drawing.Point(316, 102);
            this.Time.Name = "Time";
            this.Time.ShowUpDown = true;
            this.Time.Size = new System.Drawing.Size(119, 29);
            this.Time.TabIndex = 9;
            this.Time.Value = new System.DateTime(2019, 5, 16, 0, 0, 0, 0);
            // 
            // FromLocation
            // 
            this.FromLocation.Image = ((System.Drawing.Image)(resources.GetObject("FromLocation.Image")));
            this.FromLocation.Location = new System.Drawing.Point(453, 52);
            this.FromLocation.Name = "FromLocation";
            this.FromLocation.Size = new System.Drawing.Size(35, 44);
            this.FromLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FromLocation.TabIndex = 10;
            this.FromLocation.TabStop = false;
            this.FromLocation.Click += new System.EventHandler(this.Location_Click);
            // 
            // Exchange
            // 
            this.Exchange.Image = global::SwissTransportApp.Properties.Resources.icons8_daten_in_beide_richtungen_filled_50;
            this.Exchange.Location = new System.Drawing.Point(560, 57);
            this.Exchange.Name = "Exchange";
            this.Exchange.Size = new System.Drawing.Size(79, 45);
            this.Exchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exchange.TabIndex = 2;
            this.Exchange.TabStop = false;
            this.Exchange.Click += new System.EventHandler(this.Exchange_Click);
            // 
            // ToLocation
            // 
            this.ToLocation.Image = ((System.Drawing.Image)(resources.GetObject("ToLocation.Image")));
            this.ToLocation.Location = new System.Drawing.Point(1003, 52);
            this.ToLocation.Name = "ToLocation";
            this.ToLocation.Size = new System.Drawing.Size(35, 44);
            this.ToLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ToLocation.TabIndex = 11;
            this.ToLocation.TabStop = false;
            this.ToLocation.Click += new System.EventHandler(this.Location_Click);
            // 
            // ConnectionSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.ToLocation);
            this.Controls.Add(this.FromLocation);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.DataViewGrid);
            this.Controls.Add(this.SearchConnection);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Exchange);
            this.Controls.Add(this.ToStation);
            this.Controls.Add(this.FromStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionSearch";
            this.Text = "ConnectionSearch";
            this.Load += new System.EventHandler(this.ConnectionSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FromStation;
        private System.Windows.Forms.ComboBox ToStation;
        private System.Windows.Forms.PictureBox Exchange;
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
        private System.Windows.Forms.PictureBox FromLocation;
        private System.Windows.Forms.PictureBox ToLocation;
    }
}