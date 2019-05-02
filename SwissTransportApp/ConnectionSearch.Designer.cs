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
            this.FromStation = new System.Windows.Forms.ComboBox();
            this.ToStation = new System.Windows.Forms.ComboBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchConnection = new System.Windows.Forms.Button();
            this.DataViewGrid = new System.Windows.Forms.DataGridView();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrdauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FromStation
            // 
            this.FromStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FromStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FromStation.FormattingEnabled = true;
            this.FromStation.Location = new System.Drawing.Point(77, 58);
            this.FromStation.Name = "FromStation";
            this.FromStation.Size = new System.Drawing.Size(181, 21);
            this.FromStation.TabIndex = 0;
            this.FromStation.TextChanged += new System.EventHandler(this.StationFill);
            // 
            // ToStation
            // 
            this.ToStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ToStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ToStation.FormattingEnabled = true;
            this.ToStation.Location = new System.Drawing.Point(500, 58);
            this.ToStation.Name = "ToStation";
            this.ToStation.Size = new System.Drawing.Size(181, 21);
            this.ToStation.TabIndex = 1;
            this.ToStation.TextChanged += new System.EventHandler(this.StationFill);
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(77, 106);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(89, 20);
            this.DatePicker.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SwissTransportApp.Properties.Resources.icons8_daten_in_beide_richtungen_filled_50;
            this.pictureBox1.Location = new System.Drawing.Point(351, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SearchConnection
            // 
            this.SearchConnection.Location = new System.Drawing.Point(368, 107);
            this.SearchConnection.Name = "SearchConnection";
            this.SearchConnection.Size = new System.Drawing.Size(75, 23);
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
            this.DataViewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataViewGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.DataViewGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataViewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Gleis,
            this.Ankunft,
            this.Fahrdauer,
            this.Endstation});
            this.DataViewGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataViewGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataViewGrid.EnableHeadersVisualStyles = false;
            this.DataViewGrid.GridColor = System.Drawing.Color.Black;
            this.DataViewGrid.Location = new System.Drawing.Point(0, 180);
            this.DataViewGrid.MultiSelect = false;
            this.DataViewGrid.Name = "DataViewGrid";
            this.DataViewGrid.RowHeadersVisible = false;
            this.DataViewGrid.Size = new System.Drawing.Size(800, 270);
            this.DataViewGrid.TabIndex = 8;
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.Width = 160;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            this.Gleis.Width = 160;
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.Width = 160;
            // 
            // Fahrdauer
            // 
            this.Fahrdauer.HeaderText = "Fahrdauer";
            this.Fahrdauer.Name = "Fahrdauer";
            this.Fahrdauer.Width = 160;
            // 
            // Endstation
            // 
            this.Endstation.HeaderText = "Endstation";
            this.Endstation.Name = "Endstation";
            this.Endstation.Width = 160;
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(189, 106);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(69, 20);
            this.TimePicker.TabIndex = 9;
            // 
            // ConnectionSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.DataViewGrid);
            this.Controls.Add(this.SearchConnection);
            this.Controls.Add(this.DatePicker);
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
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button SearchConnection;
        private System.Windows.Forms.DataGridView DataViewGrid;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrdauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}