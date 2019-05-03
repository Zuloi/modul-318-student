namespace SwissTransportApp
{
    partial class ConnectionSearchView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionSearchView));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToLocation = new System.Windows.Forms.PictureBox();
            this.FromLocation = new System.Windows.Forms.PictureBox();
            this.Exchange = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exchange)).BeginInit();
            this.SuspendLayout();
            // 
            // FromStation
            // 
            this.FromStation.AllowDrop = true;
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
            this.ToStation.AllowDrop = true;
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
            this.Date.Location = new System.Drawing.Point(149, 126);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(144, 29);
            this.Date.TabIndex = 3;
            // 
            // SearchConnection
            // 
            this.SearchConnection.BackColor = System.Drawing.Color.IndianRed;
            this.SearchConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchConnection.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchConnection.Location = new System.Drawing.Point(711, 123);
            this.SearchConnection.Name = "SearchConnection";
            this.SearchConnection.Size = new System.Drawing.Size(286, 32);
            this.SearchConnection.TabIndex = 7;
            this.SearchConnection.Text = "Verbindung Suchen";
            this.SearchConnection.UseVisualStyleBackColor = false;
            this.SearchConnection.Click += new System.EventHandler(this.SearchConnection_Click);
            // 
            // DataViewGrid
            // 
            this.DataViewGrid.AllowUserToAddRows = false;
            this.DataViewGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataViewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataViewGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.DataViewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataViewGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            this.Ankunftsgleis.HeaderText = "";
            this.Ankunftsgleis.MaxInputLength = 203;
            this.Ankunftsgleis.MinimumWidth = 142;
            this.Ankunftsgleis.Name = "Ankunftsgleis";
            this.Ankunftsgleis.Width = 169;
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time.Location = new System.Drawing.Point(316, 126);
            this.Time.Name = "Time";
            this.Time.ShowUpDown = true;
            this.Time.Size = new System.Drawing.Size(119, 29);
            this.Time.TabIndex = 9;
            this.Time.Value = new System.DateTime(2019, 5, 16, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Von Station:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Zeit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(707, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nach Station:";
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
            this.ToLocation.Click += new System.EventHandler(this.ToLocation_Click);
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
            this.FromLocation.Click += new System.EventHandler(this.FromLocation_Click);
            // 
            // Exchange
            // 
            this.Exchange.Image = global::SwissTransportApp.Properties.Resources.icons8_daten_in_beide_richtungen_filled_50;
            this.Exchange.Location = new System.Drawing.Point(554, 52);
            this.Exchange.Name = "Exchange";
            this.Exchange.Size = new System.Drawing.Size(79, 45);
            this.Exchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exchange.TabIndex = 2;
            this.Exchange.TabStop = false;
            this.Exchange.Click += new System.EventHandler(this.Exchange_Click);
            // 
            // ConnectionSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Name = "ConnectionSearchView";
            this.Text = "ConnectionSearch";
            this.Load += new System.EventHandler(this.ConnectionSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exchange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox FromLocation;
        private System.Windows.Forms.PictureBox ToLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrgleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrdauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsgleis;
    }
}