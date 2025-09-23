namespace GOSO_Hotel.UI
{
    partial class UserControlRoomsAvailable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomtypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatefromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(712, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 38);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(899, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rooms Available";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomtypeColumn,
            this.RoomNoColumn,
            this.guestNameColumn,
            this.CapacityColumn,
            this.statusColumn,
            this.DatefromColumn,
            this.DateToColumn});
            this.dataGridView1.Location = new System.Drawing.Point(131, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(916, 470);
            this.dataGridView1.TabIndex = 3;
            // 
            // RoomtypeColumn
            // 
            this.RoomtypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomtypeColumn.HeaderText = "Room Type";
            this.RoomtypeColumn.MinimumWidth = 6;
            this.RoomtypeColumn.Name = "RoomtypeColumn";
            // 
            // RoomNoColumn
            // 
            this.RoomNoColumn.HeaderText = "Rooms";
            this.RoomNoColumn.MinimumWidth = 6;
            this.RoomNoColumn.Name = "RoomNoColumn";
            this.RoomNoColumn.Width = 125;
            // 
            // guestNameColumn
            // 
            this.guestNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guestNameColumn.HeaderText = "Guest Name";
            this.guestNameColumn.MinimumWidth = 6;
            this.guestNameColumn.Name = "guestNameColumn";
            // 
            // CapacityColumn
            // 
            this.CapacityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CapacityColumn.HeaderText = "Capacity";
            this.CapacityColumn.MinimumWidth = 6;
            this.CapacityColumn.Name = "CapacityColumn";
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "StatusColumn";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.Width = 125;
            // 
            // DatefromColumn
            // 
            this.DatefromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatefromColumn.HeaderText = "Date From";
            this.DatefromColumn.MinimumWidth = 6;
            this.DatefromColumn.Name = "DatefromColumn";
            // 
            // DateToColumn
            // 
            this.DateToColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateToColumn.HeaderText = "Date To";
            this.DateToColumn.MinimumWidth = 6;
            this.DateToColumn.Name = "DateToColumn";
            // 
            // UserControlRoomsAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControlRoomsAvailable";
            this.Size = new System.Drawing.Size(1196, 603);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomtypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatefromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateToColumn;
    }
}
