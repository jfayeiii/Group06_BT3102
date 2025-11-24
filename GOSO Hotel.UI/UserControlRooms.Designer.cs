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
            this.btnSearch = new System.Windows.Forms.Button();
            this.RoomNotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomaddtab = new System.Windows.Forms.TabPage();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtBedNo = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteRoomTab = new System.Windows.Forms.TabPage();
            this.txtDeleteByRoomNo = new System.Windows.Forms.TextBox();
            this.deleteRoomSearchbtn = new System.Windows.Forms.Button();
            this.deleteRoombtn = new System.Windows.Forms.Button();
            this.roomDeleteDGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RoomModUpdatebtn = new System.Windows.Forms.Button();
            this.RoomModSearchbtn = new System.Windows.Forms.Button();
            this.RoomModSearchtxt = new System.Windows.Forms.TextBox();
            this.RoomModificationDGrid = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRoomPriceUpdate = new System.Windows.Forms.TextBox();
            this.txtRoomTypeUpdate = new System.Windows.Forms.ComboBox();
            this.txtBedCountUpdate = new System.Windows.Forms.TextBox();
            this.RoomStatusUpdate = new System.Windows.Forms.ComboBox();
            this.txtCapacityUpdate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RoomNoUpdatecmb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.roomsTabcntrl.SuspendLayout();
            this.roomsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomSearchDGrid)).BeginInit();
            this.roomaddtab.SuspendLayout();
            this.deleteRoomTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDeleteDGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomModificationDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsTabcntrl
            // 
            this.roomsTabcntrl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.roomsTabcntrl.Controls.Add(this.roomsearch);
            this.roomsTabcntrl.Controls.Add(this.roomaddtab);
            this.roomsTabcntrl.Controls.Add(this.deleteRoomTab);
            this.roomsTabcntrl.Controls.Add(this.tabPage1);
            this.roomsTabcntrl.Location = new System.Drawing.Point(28, 34);
            this.roomsTabcntrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsTabcntrl.Multiline = true;
            this.roomsTabcntrl.Name = "roomsTabcntrl";
            this.roomsTabcntrl.SelectedIndex = 0;
            this.roomsTabcntrl.Size = new System.Drawing.Size(1123, 544);
            this.roomsTabcntrl.TabIndex = 0;
            // 
            // roomsearch
            // 
            this.roomsearch.Controls.Add(this.roomSearchDGrid);
            this.roomsearch.Controls.Add(this.btnSearch);
            this.roomsearch.Controls.Add(this.RoomNotxt);
            this.roomsearch.Controls.Add(this.label2);
            this.roomsearch.Controls.Add(this.label1);
            this.roomsearch.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsearch.Location = new System.Drawing.Point(4, 4);
            this.roomsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsearch.Name = "roomsearch";
            this.roomsearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsearch.Size = new System.Drawing.Size(1115, 515);
            this.roomsearch.TabIndex = 0;
            this.roomsearch.Text = "Rooms Search";
            this.roomsearch.UseVisualStyleBackColor = true;
            // 
            // roomSearchDGrid
            // 
            this.roomSearchDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomSearchDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomSearchDGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roomSearchDGrid.Enabled = false;
            this.roomSearchDGrid.Location = new System.Drawing.Point(3, 163);
            this.roomSearchDGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomSearchDGrid.Name = "roomSearchDGrid";
            this.roomSearchDGrid.ReadOnly = true;
            this.roomSearchDGrid.RowHeadersWidth = 51;
            this.roomSearchDGrid.RowTemplate.Height = 24;
            this.roomSearchDGrid.Size = new System.Drawing.Size(1109, 350);
            this.roomSearchDGrid.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(567, 111);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 33);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // RoomNotxt
            // 
            this.RoomNotxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNotxt.Location = new System.Drawing.Point(323, 111);
            this.RoomNotxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomNotxt.Name = "RoomNotxt";
            this.RoomNotxt.Size = new System.Drawing.Size(221, 32);
            this.RoomNotxt.TabIndex = 5;
            this.RoomNotxt.TextChanged += new System.EventHandler(this.RoomNotxt_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "RoomSearch:";
            // 
            // roomaddtab
            // 
            this.roomaddtab.Controls.Add(this.btnAddRoom);
            this.roomaddtab.Controls.Add(this.txtCapacity);
            this.roomaddtab.Controls.Add(this.txtBedNo);
            this.roomaddtab.Controls.Add(this.txtRoomNo);
            this.roomaddtab.Controls.Add(this.txtRoomType);
            this.roomaddtab.Controls.Add(this.txtPrice);
            this.roomaddtab.Controls.Add(this.cbStatus);
            this.roomaddtab.Controls.Add(this.label16);
            this.roomaddtab.Controls.Add(this.label15);
            this.roomaddtab.Controls.Add(this.label8);
            this.roomaddtab.Controls.Add(this.label7);
            this.roomaddtab.Controls.Add(this.label6);
            this.roomaddtab.Controls.Add(this.label5);
            this.roomaddtab.Controls.Add(this.label3);
            this.roomaddtab.Location = new System.Drawing.Point(4, 4);
            this.roomaddtab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomaddtab.Name = "roomaddtab";
            this.roomaddtab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomaddtab.Size = new System.Drawing.Size(1115, 515);
            this.roomaddtab.TabIndex = 1;
            this.roomaddtab.Text = "Add Room";
            this.roomaddtab.UseVisualStyleBackColor = true;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddRoom.Location = new System.Drawing.Point(473, 348);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(160, 44);
            this.btnAddRoom.TabIndex = 20;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(751, 244);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapacity.Multiline = true;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(159, 31);
            this.txtCapacity.TabIndex = 19;
            // 
            // txtBedNo
            // 
            this.txtBedNo.Location = new System.Drawing.Point(751, 158);
            this.txtBedNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBedNo.Multiline = true;
            this.txtBedNo.Name = "txtBedNo";
            this.txtBedNo.Size = new System.Drawing.Size(159, 31);
            this.txtBedNo.TabIndex = 18;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(208, 158);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomNo.Multiline = true;
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(160, 31);
            this.txtRoomNo.TabIndex = 17;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.FormattingEnabled = true;
            this.txtRoomType.Location = new System.Drawing.Point(208, 245);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(160, 32);
            this.txtRoomType.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(472, 158);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 31);
            this.txtPrice.TabIndex = 15;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(472, 245);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(160, 32);
            this.cbStatus.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(468, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "Room Status:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(468, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "Room Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(747, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Capacity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Room Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(747, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number of Beds:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Room Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add Room:";
            // 
            // deleteRoomTab
            // 
            this.deleteRoomTab.Controls.Add(this.txtDeleteByRoomNo);
            this.deleteRoomTab.Controls.Add(this.deleteRoomSearchbtn);
            this.deleteRoomTab.Controls.Add(this.deleteRoombtn);
            this.deleteRoomTab.Controls.Add(this.roomDeleteDGrid);
            this.deleteRoomTab.Controls.Add(this.label9);
            this.deleteRoomTab.Controls.Add(this.label4);
            this.deleteRoomTab.Location = new System.Drawing.Point(4, 4);
            this.deleteRoomTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRoomTab.Name = "deleteRoomTab";
            this.deleteRoomTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRoomTab.Size = new System.Drawing.Size(1115, 515);
            this.deleteRoomTab.TabIndex = 2;
            this.deleteRoomTab.Text = "Delete Room";
            this.deleteRoomTab.UseVisualStyleBackColor = true;
            // 
            // txtDeleteByRoomNo
            // 
            this.txtDeleteByRoomNo.Location = new System.Drawing.Point(269, 75);
            this.txtDeleteByRoomNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeleteByRoomNo.Multiline = true;
            this.txtDeleteByRoomNo.Name = "txtDeleteByRoomNo";
            this.txtDeleteByRoomNo.Size = new System.Drawing.Size(248, 40);
            this.txtDeleteByRoomNo.TabIndex = 14;
            // 
            // deleteRoomSearchbtn
            // 
            this.deleteRoomSearchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteRoomSearchbtn.Location = new System.Drawing.Point(524, 75);
            this.deleteRoomSearchbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRoomSearchbtn.Name = "deleteRoomSearchbtn";
            this.deleteRoomSearchbtn.Size = new System.Drawing.Size(112, 41);
            this.deleteRoomSearchbtn.TabIndex = 13;
            this.deleteRoomSearchbtn.Text = "Search";
            this.deleteRoomSearchbtn.UseVisualStyleBackColor = false;
            this.deleteRoomSearchbtn.Click += new System.EventHandler(this.deleteRoomSearchbtn_Click_1);
            // 
            // deleteRoombtn
            // 
            this.deleteRoombtn.BackColor = System.Drawing.Color.Red;
            this.deleteRoombtn.Location = new System.Drawing.Point(641, 75);
            this.deleteRoombtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRoombtn.Name = "deleteRoombtn";
            this.deleteRoombtn.Size = new System.Drawing.Size(112, 41);
            this.deleteRoombtn.TabIndex = 12;
            this.deleteRoombtn.Text = "Delete";
            this.deleteRoombtn.UseVisualStyleBackColor = false;
            this.deleteRoombtn.Click += new System.EventHandler(this.deleteRoombtn_Click_1);
            // 
            // roomDeleteDGrid
            // 
            this.roomDeleteDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDeleteDGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roomDeleteDGrid.Enabled = false;
            this.roomDeleteDGrid.Location = new System.Drawing.Point(3, 160);
            this.roomDeleteDGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomDeleteDGrid.Name = "roomDeleteDGrid";
            this.roomDeleteDGrid.ReadOnly = true;
            this.roomDeleteDGrid.RowHeadersWidth = 51;
            this.roomDeleteDGrid.RowTemplate.Height = 24;
            this.roomDeleteDGrid.Size = new System.Drawing.Size(1109, 353);
            this.roomDeleteDGrid.TabIndex = 11;
            this.roomDeleteDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomDeleteDGrid_CellContentClick_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(265, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Room Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Delete Room:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RoomModUpdatebtn);
            this.tabPage1.Controls.Add(this.RoomModSearchbtn);
            this.tabPage1.Controls.Add(this.RoomModSearchtxt);
            this.tabPage1.Controls.Add(this.RoomModificationDGrid);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.txtRoomPriceUpdate);
            this.tabPage1.Controls.Add(this.txtRoomTypeUpdate);
            this.tabPage1.Controls.Add(this.txtBedCountUpdate);
            this.tabPage1.Controls.Add(this.RoomStatusUpdate);
            this.tabPage1.Controls.Add(this.txtCapacityUpdate);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.RoomNoUpdatecmb);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1115, 515);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Update Room";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RoomModUpdatebtn
            // 
            this.RoomModUpdatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RoomModUpdatebtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomModUpdatebtn.Location = new System.Drawing.Point(925, 164);
            this.RoomModUpdatebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomModUpdatebtn.Name = "RoomModUpdatebtn";
            this.RoomModUpdatebtn.Size = new System.Drawing.Size(144, 43);
            this.RoomModUpdatebtn.TabIndex = 30;
            this.RoomModUpdatebtn.Text = "Update";
            this.RoomModUpdatebtn.UseVisualStyleBackColor = false;
            this.RoomModUpdatebtn.Click += new System.EventHandler(this.RoomModUpdatebtn_Click_1);
            // 
            // RoomModSearchbtn
            // 
            this.RoomModSearchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RoomModSearchbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomModSearchbtn.Location = new System.Drawing.Point(603, 164);
            this.RoomModSearchbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomModSearchbtn.Name = "RoomModSearchbtn";
            this.RoomModSearchbtn.Size = new System.Drawing.Size(160, 43);
            this.RoomModSearchbtn.TabIndex = 29;
            this.RoomModSearchbtn.Text = "Search";
            this.RoomModSearchbtn.UseVisualStyleBackColor = false;
            this.RoomModSearchbtn.Click += new System.EventHandler(this.RoomModSearchbtn_Click_1);
            // 
            // RoomModSearchtxt
            // 
            this.RoomModSearchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomModSearchtxt.Location = new System.Drawing.Point(324, 170);
            this.RoomModSearchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomModSearchtxt.Name = "RoomModSearchtxt";
            this.RoomModSearchtxt.Size = new System.Drawing.Size(272, 30);
            this.RoomModSearchtxt.TabIndex = 28;
            // 
            // RoomModificationDGrid
            // 
            this.RoomModificationDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomModificationDGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RoomModificationDGrid.Enabled = false;
            this.RoomModificationDGrid.Location = new System.Drawing.Point(3, 221);
            this.RoomModificationDGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomModificationDGrid.Name = "RoomModificationDGrid";
            this.RoomModificationDGrid.ReadOnly = true;
            this.RoomModificationDGrid.RowHeadersWidth = 51;
            this.RoomModificationDGrid.RowTemplate.Height = 24;
            this.RoomModificationDGrid.Size = new System.Drawing.Size(1109, 292);
            this.RoomModificationDGrid.TabIndex = 27;
            this.RoomModificationDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomModificationDGrid_CellContentClick_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(921, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 19);
            this.label18.TabIndex = 26;
            this.label18.Text = "Room Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(740, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Room Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(569, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "Number of Beds:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(396, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 19);
            this.label17.TabIndex = 23;
            this.label17.Text = "Room Status";
            // 
            // txtRoomPriceUpdate
            // 
            this.txtRoomPriceUpdate.Location = new System.Drawing.Point(925, 92);
            this.txtRoomPriceUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomPriceUpdate.Multiline = true;
            this.txtRoomPriceUpdate.Name = "txtRoomPriceUpdate";
            this.txtRoomPriceUpdate.Size = new System.Drawing.Size(143, 24);
            this.txtRoomPriceUpdate.TabIndex = 22;
            // 
            // txtRoomTypeUpdate
            // 
            this.txtRoomTypeUpdate.FormattingEnabled = true;
            this.txtRoomTypeUpdate.Location = new System.Drawing.Point(744, 91);
            this.txtRoomTypeUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomTypeUpdate.Name = "txtRoomTypeUpdate";
            this.txtRoomTypeUpdate.Size = new System.Drawing.Size(143, 24);
            this.txtRoomTypeUpdate.TabIndex = 21;
            // 
            // txtBedCountUpdate
            // 
            this.txtBedCountUpdate.Location = new System.Drawing.Point(573, 92);
            this.txtBedCountUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBedCountUpdate.Multiline = true;
            this.txtBedCountUpdate.Name = "txtBedCountUpdate";
            this.txtBedCountUpdate.Size = new System.Drawing.Size(143, 24);
            this.txtBedCountUpdate.TabIndex = 20;
            // 
            // RoomStatusUpdate
            // 
            this.RoomStatusUpdate.FormattingEnabled = true;
            this.RoomStatusUpdate.Location = new System.Drawing.Point(400, 91);
            this.RoomStatusUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomStatusUpdate.Name = "RoomStatusUpdate";
            this.RoomStatusUpdate.Size = new System.Drawing.Size(143, 24);
            this.RoomStatusUpdate.TabIndex = 19;
            // 
            // txtCapacityUpdate
            // 
            this.txtCapacityUpdate.Location = new System.Drawing.Point(221, 91);
            this.txtCapacityUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapacityUpdate.Multiline = true;
            this.txtCapacityUpdate.Name = "txtCapacityUpdate";
            this.txtCapacityUpdate.Size = new System.Drawing.Size(143, 25);
            this.txtCapacityUpdate.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(217, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 17;
            this.label12.Text = "Capacity:";
            // 
            // RoomNoUpdatecmb
            // 
            this.RoomNoUpdatecmb.Location = new System.Drawing.Point(48, 92);
            this.RoomNoUpdatecmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomNoUpdatecmb.Multiline = true;
            this.RoomNoUpdatecmb.Name = "RoomNoUpdatecmb";
            this.RoomNoUpdatecmb.Size = new System.Drawing.Size(143, 24);
            this.RoomNoUpdatecmb.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "RoomNo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Room Modification:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // UserControlRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.roomsTabcntrl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomModificationDGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl roomsTabcntrl;
        private System.Windows.Forms.TabPage roomsearch;
        private System.Windows.Forms.TabPage roomaddtab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage deleteRoomTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox RoomNotxt;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtBedNo;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.ComboBox txtRoomType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView roomSearchDGrid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDeleteByRoomNo;
        private System.Windows.Forms.Button deleteRoomSearchbtn;
        private System.Windows.Forms.Button deleteRoombtn;
        private System.Windows.Forms.DataGridView roomDeleteDGrid;
        private System.Windows.Forms.TextBox txtBedCountUpdate;
        private System.Windows.Forms.ComboBox RoomStatusUpdate;
        private System.Windows.Forms.TextBox txtCapacityUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RoomNoUpdatecmb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button RoomModUpdatebtn;
        private System.Windows.Forms.Button RoomModSearchbtn;
        private System.Windows.Forms.TextBox RoomModSearchtxt;
        private System.Windows.Forms.DataGridView RoomModificationDGrid;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRoomPriceUpdate;
        private System.Windows.Forms.ComboBox txtRoomTypeUpdate;
    }
}
