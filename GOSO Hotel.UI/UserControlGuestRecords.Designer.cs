namespace GOSO_Hotel.UI
{
    partial class UserControlGuestRecords
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
            this.searchGuestTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.guestRecordDGrid = new System.Windows.Forms.DataGridView();
            this.guestIDtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guestNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteGuesttab = new System.Windows.Forms.TabPage();
            this.deleteGuestbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteByGuestIDtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addGuestTab = new System.Windows.Forms.TabPage();
            this.AddGuestbtn = new System.Windows.Forms.Button();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteGuestSearchbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.searchGuestTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestRecordDGrid)).BeginInit();
            this.deleteGuesttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addGuestTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.searchGuestTab);
            this.tabControl1.Controls.Add(this.deleteGuesttab);
            this.tabControl1.Controls.Add(this.addGuestTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1193, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // searchGuestTab
            // 
            this.searchGuestTab.Controls.Add(this.button1);
            this.searchGuestTab.Controls.Add(this.guestRecordDGrid);
            this.searchGuestTab.Controls.Add(this.guestIDtxt);
            this.searchGuestTab.Controls.Add(this.label3);
            this.searchGuestTab.Controls.Add(this.guestNametxt);
            this.searchGuestTab.Controls.Add(this.label2);
            this.searchGuestTab.Controls.Add(this.label1);
            this.searchGuestTab.Location = new System.Drawing.Point(4, 4);
            this.searchGuestTab.Name = "searchGuestTab";
            this.searchGuestTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchGuestTab.Size = new System.Drawing.Size(1185, 561);
            this.searchGuestTab.TabIndex = 0;
            this.searchGuestTab.Text = "Search Guest";
            this.searchGuestTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(642, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // guestRecordDGrid
            // 
            this.guestRecordDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestRecordDGrid.Location = new System.Drawing.Point(257, 107);
            this.guestRecordDGrid.Name = "guestRecordDGrid";
            this.guestRecordDGrid.RowHeadersWidth = 51;
            this.guestRecordDGrid.RowTemplate.Height = 24;
            this.guestRecordDGrid.Size = new System.Drawing.Size(680, 363);
            this.guestRecordDGrid.TabIndex = 5;
            // 
            // guestIDtxt
            // 
            this.guestIDtxt.Location = new System.Drawing.Point(460, 67);
            this.guestIDtxt.Multiline = true;
            this.guestIDtxt.Name = "guestIDtxt";
            this.guestIDtxt.Size = new System.Drawing.Size(165, 34);
            this.guestIDtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer ID:";
            // 
            // guestNametxt
            // 
            this.guestNametxt.Location = new System.Drawing.Point(257, 67);
            this.guestNametxt.Multiline = true;
            this.guestNametxt.Name = "guestNametxt";
            this.guestNametxt.Size = new System.Drawing.Size(165, 34);
            this.guestNametxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Guest:";
            // 
            // deleteGuesttab
            // 
            this.deleteGuesttab.Controls.Add(this.deleteGuestSearchbtn);
            this.deleteGuesttab.Controls.Add(this.deleteGuestbtn);
            this.deleteGuesttab.Controls.Add(this.dataGridView1);
            this.deleteGuesttab.Controls.Add(this.deleteByGuestIDtxt);
            this.deleteGuesttab.Controls.Add(this.label4);
            this.deleteGuesttab.Controls.Add(this.label6);
            this.deleteGuesttab.Location = new System.Drawing.Point(4, 4);
            this.deleteGuesttab.Name = "deleteGuesttab";
            this.deleteGuesttab.Padding = new System.Windows.Forms.Padding(3);
            this.deleteGuesttab.Size = new System.Drawing.Size(1185, 561);
            this.deleteGuesttab.TabIndex = 1;
            this.deleteGuesttab.Text = "Delete Guest";
            this.deleteGuesttab.UseVisualStyleBackColor = true;
            // 
            // deleteGuestbtn
            // 
            this.deleteGuestbtn.BackColor = System.Drawing.Color.Red;
            this.deleteGuestbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGuestbtn.Location = new System.Drawing.Point(723, 91);
            this.deleteGuestbtn.Name = "deleteGuestbtn";
            this.deleteGuestbtn.Size = new System.Drawing.Size(128, 34);
            this.deleteGuestbtn.TabIndex = 13;
            this.deleteGuestbtn.Text = "Delete";
            this.deleteGuestbtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 349);
            this.dataGridView1.TabIndex = 12;
            // 
            // deleteByGuestIDtxt
            // 
            this.deleteByGuestIDtxt.Location = new System.Drawing.Point(263, 91);
            this.deleteByGuestIDtxt.Multiline = true;
            this.deleteByGuestIDtxt.Name = "deleteByGuestIDtxt";
            this.deleteByGuestIDtxt.Size = new System.Drawing.Size(314, 34);
            this.deleteByGuestIDtxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Customer ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Delete Guest Record:";
            // 
            // addGuestTab
            // 
            this.addGuestTab.Controls.Add(this.AddGuestbtn);
            this.addGuestTab.Controls.Add(this.txtCapacity);
            this.addGuestTab.Controls.Add(this.txtRoomNo);
            this.addGuestTab.Controls.Add(this.txtGuestId);
            this.addGuestTab.Controls.Add(this.txtGuestName);
            this.addGuestTab.Controls.Add(this.label8);
            this.addGuestTab.Controls.Add(this.label7);
            this.addGuestTab.Controls.Add(this.label9);
            this.addGuestTab.Controls.Add(this.label10);
            this.addGuestTab.Controls.Add(this.label5);
            this.addGuestTab.Location = new System.Drawing.Point(4, 4);
            this.addGuestTab.Name = "addGuestTab";
            this.addGuestTab.Padding = new System.Windows.Forms.Padding(3);
            this.addGuestTab.Size = new System.Drawing.Size(1185, 561);
            this.addGuestTab.TabIndex = 2;
            this.addGuestTab.Text = "Add Guest";
            this.addGuestTab.UseVisualStyleBackColor = true;
            // 
            // AddGuestbtn
            // 
            this.AddGuestbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddGuestbtn.Location = new System.Drawing.Point(499, 293);
            this.AddGuestbtn.Name = "AddGuestbtn";
            this.AddGuestbtn.Size = new System.Drawing.Size(174, 63);
            this.AddGuestbtn.TabIndex = 19;
            this.AddGuestbtn.Text = "AddGuest";
            this.AddGuestbtn.UseVisualStyleBackColor = false;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(794, 223);
            this.txtCapacity.Multiline = true;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(142, 31);
            this.txtCapacity.TabIndex = 18;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(621, 223);
            this.txtRoomNo.Multiline = true;
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(142, 31);
            this.txtRoomNo.TabIndex = 17;
            // 
            // txtGuestId
            // 
            this.txtGuestId.Location = new System.Drawing.Point(436, 223);
            this.txtGuestId.Multiline = true;
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.Size = new System.Drawing.Size(142, 31);
            this.txtGuestId.TabIndex = 16;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(251, 223);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(142, 31);
            this.txtGuestName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(791, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Capacity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(618, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Room Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(433, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Guest Id:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(248, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add Guest:";
            // 
            // deleteGuestSearchbtn
            // 
            this.deleteGuestSearchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteGuestSearchbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGuestSearchbtn.Location = new System.Drawing.Point(589, 91);
            this.deleteGuestSearchbtn.Name = "deleteGuestSearchbtn";
            this.deleteGuestSearchbtn.Size = new System.Drawing.Size(128, 34);
            this.deleteGuestSearchbtn.TabIndex = 14;
            this.deleteGuestSearchbtn.Text = "Search";
            this.deleteGuestSearchbtn.UseVisualStyleBackColor = false;
            // 
            // UserControlGuestRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlGuestRecords";
            this.Size = new System.Drawing.Size(1196, 603);
            this.tabControl1.ResumeLayout(false);
            this.searchGuestTab.ResumeLayout(false);
            this.searchGuestTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestRecordDGrid)).EndInit();
            this.deleteGuesttab.ResumeLayout(false);
            this.deleteGuesttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addGuestTab.ResumeLayout(false);
            this.addGuestTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage searchGuestTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage deleteGuesttab;
        private System.Windows.Forms.TabPage addGuestTab;
        private System.Windows.Forms.DataGridView guestRecordDGrid;
        private System.Windows.Forms.TextBox guestIDtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guestNametxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteGuestbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox deleteByGuestIDtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddGuestbtn;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button deleteGuestSearchbtn;
    }
}
