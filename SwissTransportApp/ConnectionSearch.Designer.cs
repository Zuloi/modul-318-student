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
            this.FromStation = new System.Windows.Forms.ComboBox();
            this.ToStation = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchConnection = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FromStation
            // 
            this.FromStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FromStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FromStation.FormattingEnabled = true;
            this.FromStation.Location = new System.Drawing.Point(77, 58);
            this.FromStation.Name = "FromStation";
            this.FromStation.Size = new System.Drawing.Size(181, 21);
            this.FromStation.TabIndex = 0;
            this.FromStation.SelectedIndexChanged += new System.EventHandler(this.FromStation_SelectedIndexChanged);
            // 
            // ToStation
            // 
            this.ToStation.FormattingEnabled = true;
            this.ToStation.Location = new System.Drawing.Point(500, 58);
            this.ToStation.Name = "ToStation";
            this.ToStation.Size = new System.Drawing.Size(181, 21);
            this.ToStation.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(194, 106);
            this.maskedTextBox1.Mask = "90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(64, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 270);
            this.dataGridView1.TabIndex = 8;
            // 
            // ConnectionSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchConnection);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToStation);
            this.Controls.Add(this.FromStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionSearch";
            this.Text = "ConnectionSearch";
            this.Load += new System.EventHandler(this.ConnectionSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FromStation;
        private System.Windows.Forms.ComboBox ToStation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button SearchConnection;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}