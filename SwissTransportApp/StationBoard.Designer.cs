namespace SwissTransportApp
{
    partial class StationBoard
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
            this.DataViewGrid = new System.Windows.Forms.DataGridView();
            this.SearchConnection = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FromStation
            // 
            this.FromStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FromStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FromStation.FormattingEnabled = true;
            this.FromStation.Location = new System.Drawing.Point(385, 80);
            this.FromStation.Name = "FromStation";
            this.FromStation.Size = new System.Drawing.Size(217, 21);
            this.FromStation.TabIndex = 0;
            this.FromStation.TextChanged += new System.EventHandler(this.StationFill);
            // 
            // DataViewGrid
            // 
            this.DataViewGrid.AllowUserToAddRows = false;
            this.DataViewGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            this.DataViewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataViewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataViewGrid.BackgroundColor = System.Drawing.Color.IndianRed;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.Ankunftsort,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.DataViewGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.DataViewGrid.RowHeadersVisible = false;
            this.DataViewGrid.Size = new System.Drawing.Size(1022, 273);
            this.DataViewGrid.TabIndex = 10;
            // 
            // SearchConnection
            // 
            this.SearchConnection.Location = new System.Drawing.Point(385, 107);
            this.SearchConnection.Name = "SearchConnection";
            this.SearchConnection.Size = new System.Drawing.Size(217, 23);
            this.SearchConnection.TabIndex = 11;
            this.SearchConnection.Text = "Search";
            this.SearchConnection.UseVisualStyleBackColor = true;
            this.SearchConnection.Click += new System.EventHandler(this.SearchConnection_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Abfahrtszeit";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 143;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 143;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 143;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Abfahrtsort";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 143;
            this.dataGridViewTextBoxColumn2.MinimumWidth = 143;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 143;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Gleis";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 143;
            this.dataGridViewTextBoxColumn3.MinimumWidth = 143;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 143;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Fahrdauer";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 143;
            this.dataGridViewTextBoxColumn5.MinimumWidth = 143;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 143;
            // 
            // Ankunftsort
            // 
            this.Ankunftsort.HeaderText = "Ankunftsort";
            this.Ankunftsort.Name = "Ankunftsort";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Endstation";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 143;
            this.dataGridViewTextBoxColumn6.MinimumWidth = 143;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 143;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 143;
            this.dataGridViewTextBoxColumn7.MinimumWidth = 143;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 143;
            // 
            // StationBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.SearchConnection);
            this.Controls.Add(this.DataViewGrid);
            this.Controls.Add(this.FromStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StationBoard";
            this.Text = "StationBoard";
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FromStation;
        private System.Windows.Forms.DataGridView DataViewGrid;
        private System.Windows.Forms.Button SearchConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}