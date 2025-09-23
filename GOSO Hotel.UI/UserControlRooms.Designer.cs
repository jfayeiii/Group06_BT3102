namespace GOSO_Hotel.UI
{
    partial class UserControlRooms
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
            this.components = new System.ComponentModel.Container();
            this.roomsTabcntrl = new System.Windows.Forms.TabControl();
            this.roomsearch = new System.Windows.Forms.TabPage();
            this.roomSearchDGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.RoomNotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomaddtab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtBedNo = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteRoomTab = new System.Windows.Forms.TabPage();
            this.deleteRoombtn = new System.Windows.Forms.Button();
            this.roomDeleteDGrid = new System.Windows.Forms.DataGridView();
            this.deleteRoomSearchbtn = new System.Windows.Forms.Button();
            this.txtDeleteByRoomNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.roomsTabcntrl.SuspendLayout();
            this.roomsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomSearchDGrid)).BeginInit();
            this.roomaddtab.SuspendLayout();
            this.deleteRoomTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDeleteDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsTabcntrl
            // 
            this.roomsTabcntrl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.roomsTabcntrl.Controls.Add(this.roomsearch);
            this.roomsTabcntrl.Controls.Add(this.roomaddtab);
            this.roomsTabcntrl.Controls.Add(this.deleteRoomTab);
            this.roomsTabcntrl.Location = new System.Drawing.Point(28, 35);
            this.roomsTabcntrl.Multiline = true;
            this.roomsTabcntrl.Name = "roomsTabcntrl";
            this.roomsTabcntrl.SelectedIndex = 0;
            this.roomsTabcntrl.Size = new System.Drawing.Size(1122, 544);
            this.roomsTabcntrl.TabIndex = 0;
            // 
            // roomsearch
            // 
            this.roomsearch.Controls.Add(this.roomSearchDGrid);
            this.roomsearch.Controls.Add(this.button1);
            this.roomsearch.Controls.Add(this.RoomNotxt);
            this.roomsearch.Controls.Add(this.label2);
            this.roomsearch.Controls.Add(this.label1);
            this.roomsearch.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsearch.Location = new System.Drawing.Point(4, 4);
            this.roomsearch.Name = "roomsearch";
            this.roomsearch.Padding = new System.Windows.Forms.Padding(3);
            this.roomsearch.Size = new System.Drawing.Size(1114, 515);
            this.roomsearch.TabIndex = 0;
            this.roomsearch.Text = "Rooms Search";
            this.roomsearch.UseVisualStyleBackColor = true;
            // 
            // roomSearchDGrid
            // 
            this.roomSearchDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomSearchDGrid.Location = new System.Drawing.Point(169, 133);
            this.roomSearchDGrid.Name = "roomSearchDGrid";
            this.roomSearchDGrid.RowHeadersWidth = 51;
            this.roomSearchDGrid.RowTemplate.Height = 24;
            this.roomSearchDGrid.Size = new System.Drawing.Size(712, 283);
            this.roomSearchDGrid.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(551, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RoomNotxt
            // 
            this.RoomNotxt.Location = new System.Drawing.Point(353, 97);
            this.RoomNotxt.Multiline = true;
            this.RoomNotxt.Name = "RoomNotxt";
            this.RoomNotxt.Size = new System.Drawing.Size(192, 30);
            this.RoomNotxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "RoomSearch:";
            // 
            // roomaddtab
            // 
            this.roomaddtab.Controls.Add(this.button2);
            this.roomaddtab.Controls.Add(this.txtCapacity);
            this.roomaddtab.Controls.Add(this.txtRoomType);
            this.roomaddtab.Controls.Add(this.txtBedNo);
            this.roomaddtab.Controls.Add(this.txtRoomNo);
            this.roomaddtab.Controls.Add(this.label8);
            this.roomaddtab.Controls.Add(this.label7);
            this.roomaddtab.Controls.Add(this.label6);
            this.roomaddtab.Controls.Add(this.label5);
            this.roomaddtab.Controls.Add(this.label3);
            this.roomaddtab.Location = new System.Drawing.Point(4, 4);
            this.roomaddtab.Name = "roomaddtab";
            this.roomaddtab.Padding = new System.Windows.Forms.Padding(3);
            this.roomaddtab.Size = new System.Drawing.Size(1114, 515);
            this.roomaddtab.TabIndex = 1;
            this.roomaddtab.Text = "Add Room";
            this.roomaddtab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(456, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add Room";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(751, 209);
            this.txtCapacity.Multiline = true;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(142, 31);
            this.txtCapacity.TabIndex = 9;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(578, 209);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(142, 31);
            this.txtRoomType.TabIndex = 8;
            // 
            // txtBedNo
            // 
            this.txtBedNo.Location = new System.Drawing.Point(393, 209);
            this.txtBedNo.Multiline = true;
            this.txtBedNo.Name = "txtBedNo";
            this.txtBedNo.Size = new System.Drawing.Size(142, 31);
            this.txtBedNo.TabIndex = 7;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(208, 209);
            this.txtRoomNo.Multiline = true;
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(142, 31);
            this.txtRoomNo.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(748, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Capacity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(575, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Room Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number of Beds:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Room Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add Room:";
            // 
            // deleteRoomTab
            // 
            this.deleteRoomTab.Controls.Add(this.deleteRoombtn);
            this.deleteRoomTab.Controls.Add(this.roomDeleteDGrid);
            this.deleteRoomTab.Controls.Add(this.deleteRoomSearchbtn);
            this.deleteRoomTab.Controls.Add(this.txtDeleteByRoomNo);
            this.deleteRoomTab.Controls.Add(this.label9);
            this.deleteRoomTab.Controls.Add(this.label4);
            this.deleteRoomTab.Location = new System.Drawing.Point(4, 4);
            this.deleteRoomTab.Name = "deleteRoomTab";
            this.deleteRoomTab.Padding = new System.Windows.Forms.Padding(3);
            this.deleteRoomTab.Size = new System.Drawing.Size(1114, 515);
            this.deleteRoomTab.TabIndex = 2;
            this.deleteRoomTab.Text = "Delete Room";
            this.deleteRoomTab.UseVisualStyleBackColor = true;
            // 
            // deleteRoombtn
            // 
            this.deleteRoombtn.BackColor = System.Drawing.Color.Red;
            this.deleteRoombtn.Location = new System.Drawing.Point(590, 71);
            this.deleteRoombtn.Name = "deleteRoombtn";
            this.deleteRoombtn.Size = new System.Drawing.Size(112, 30);
            this.deleteRoombtn.TabIndex = 10;
            this.deleteRoombtn.Text = "Delete";
            this.deleteRoombtn.UseVisualStyleBackColor = false;
            // 
            // roomDeleteDGrid
            // 
            this.roomDeleteDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDeleteDGrid.Location = new System.Drawing.Point(218, 107);
            this.roomDeleteDGrid.Name = "roomDeleteDGrid";
            this.roomDeleteDGrid.RowHeadersWidth = 51;
            this.roomDeleteDGrid.RowTemplate.Height = 24;
            this.roomDeleteDGrid.Size = new System.Drawing.Size(683, 295);
            this.roomDeleteDGrid.TabIndex = 9;
            // 
            // deleteRoomSearchbtn
            // 
            this.deleteRoomSearchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteRoomSearchbtn.Location = new System.Drawing.Point(472, 71);
            this.deleteRoomSearchbtn.Name = "deleteRoomSearchbtn";
            this.deleteRoomSearchbtn.Size = new System.Drawing.Size(112, 30);
            this.deleteRoomSearchbtn.TabIndex = 8;
            this.deleteRoomSearchbtn.Text = "Search";
            this.deleteRoomSearchbtn.UseVisualStyleBackColor = false;
            // 
            // txtDeleteByRoomNo
            // 
            this.txtDeleteByRoomNo.Location = new System.Drawing.Point(218, 71);
            this.txtDeleteByRoomNo.Multiline = true;
            this.txtDeleteByRoomNo.Name = "txtDeleteByRoomNo";
            this.txtDeleteByRoomNo.Size = new System.Drawing.Size(248, 30);
            this.txtDeleteByRoomNo.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Room Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Delete Room:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserControlRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.roomsTabcntrl);
            this.Name = "UserControlRooms";
            this.Size = new System.Drawing.Size(1196, 603);
            this.roomsTabcntrl.ResumeLayout(false);
            this.roomsearch.ResumeLayout(false);
            this.roomsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomSearchDGrid)).EndInit();
            this.roomaddtab.ResumeLayout(false);
            this.roomaddtab.PerformLayout();
            this.deleteRoomTab.ResumeLayout(false);
            this.deleteRoomTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDeleteDGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl roomsTabcntrl;
        private System.Windows.Forms.TabPage roomsearch;
        private System.Windows.Forms.TabPage roomaddtab;
        private System.Windows.Forms.TextBox RoomNotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView roomSearchDGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage deleteRoomTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtBedNo;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDeleteByRoomNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView roomDeleteDGrid;
        private System.Windows.Forms.Button deleteRoomSearchbtn;
        private System.Windows.Forms.Button deleteRoombtn;
    }
}
