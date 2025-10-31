namespace GOSO_Hotel.UI
{
    partial class UserControlAdminCheckinCheckout
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CheckInbtn = new System.Windows.Forms.Button();
            this.CheckInSearchbtn = new System.Windows.Forms.Button();
            this.guestRecordDGrid = new System.Windows.Forms.DataGridView();
            this.CheckInSearchtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckOutbtn = new System.Windows.Forms.Button();
            this.CheckoutSearchbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckOutSearchtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestRecordDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1187, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CheckInbtn);
            this.tabPage1.Controls.Add(this.CheckInSearchbtn);
            this.tabPage1.Controls.Add(this.guestRecordDGrid);
            this.tabPage1.Controls.Add(this.CheckInSearchtxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1179, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Check-in";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CheckOutbtn);
            this.tabPage2.Controls.Add(this.CheckoutSearchbtn);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.CheckOutSearchtxt);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1179, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check-out";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CheckInbtn
            // 
            this.CheckInbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckInbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInbtn.Location = new System.Drawing.Point(804, 457);
            this.CheckInbtn.Name = "CheckInbtn";
            this.CheckInbtn.Size = new System.Drawing.Size(128, 34);
            this.CheckInbtn.TabIndex = 15;
            this.CheckInbtn.Text = "Check-in";
            this.CheckInbtn.UseVisualStyleBackColor = false;
            // 
            // CheckInSearchbtn
            // 
            this.CheckInSearchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckInSearchbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInSearchbtn.Location = new System.Drawing.Point(804, 48);
            this.CheckInSearchbtn.Name = "CheckInSearchbtn";
            this.CheckInSearchbtn.Size = new System.Drawing.Size(128, 34);
            this.CheckInSearchbtn.TabIndex = 14;
            this.CheckInSearchbtn.Text = "Search";
            this.CheckInSearchbtn.UseVisualStyleBackColor = false;
            // 
            // guestRecordDGrid
            // 
            this.guestRecordDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestRecordDGrid.Location = new System.Drawing.Point(252, 88);
            this.guestRecordDGrid.Name = "guestRecordDGrid";
            this.guestRecordDGrid.RowHeadersWidth = 51;
            this.guestRecordDGrid.RowTemplate.Height = 24;
            this.guestRecordDGrid.Size = new System.Drawing.Size(680, 363);
            this.guestRecordDGrid.TabIndex = 13;
            // 
            // CheckInSearchtxt
            // 
            this.CheckInSearchtxt.Location = new System.Drawing.Point(633, 48);
            this.CheckInSearchtxt.Multiline = true;
            this.CheckInSearchtxt.Name = "CheckInSearchtxt";
            this.CheckInSearchtxt.Size = new System.Drawing.Size(165, 34);
            this.CheckInSearchtxt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Check-In";
            // 
            // CheckOutbtn
            // 
            this.CheckOutbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckOutbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutbtn.Location = new System.Drawing.Point(803, 457);
            this.CheckOutbtn.Name = "CheckOutbtn";
            this.CheckOutbtn.Size = new System.Drawing.Size(128, 34);
            this.CheckOutbtn.TabIndex = 18;
            this.CheckOutbtn.Text = "Check-out";
            this.CheckOutbtn.UseVisualStyleBackColor = false;
            // 
            // CheckoutSearchbtn
            // 
            this.CheckoutSearchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckoutSearchbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutSearchbtn.Location = new System.Drawing.Point(803, 48);
            this.CheckoutSearchbtn.Name = "CheckoutSearchbtn";
            this.CheckoutSearchbtn.Size = new System.Drawing.Size(128, 34);
            this.CheckoutSearchbtn.TabIndex = 17;
            this.CheckoutSearchbtn.Text = "Search";
            this.CheckoutSearchbtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 363);
            this.dataGridView1.TabIndex = 16;
            // 
            // CheckOutSearchtxt
            // 
            this.CheckOutSearchtxt.Location = new System.Drawing.Point(632, 48);
            this.CheckOutSearchtxt.Multiline = true;
            this.CheckOutSearchtxt.Name = "CheckOutSearchtxt";
            this.CheckOutSearchtxt.Size = new System.Drawing.Size(165, 34);
            this.CheckOutSearchtxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Check-out";
            // 
            // UserControlAdminCheckinCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlAdminCheckinCheckout";
            this.Size = new System.Drawing.Size(1196, 603);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestRecordDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CheckInbtn;
        private System.Windows.Forms.Button CheckInSearchbtn;
        private System.Windows.Forms.DataGridView guestRecordDGrid;
        private System.Windows.Forms.TextBox CheckInSearchtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckOutbtn;
        private System.Windows.Forms.Button CheckoutSearchbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CheckOutSearchtxt;
        private System.Windows.Forms.Label label1;
    }
}
