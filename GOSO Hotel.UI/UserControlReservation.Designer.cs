namespace GOSO_Hotel.UI
{
    partial class UserControlReservation
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbReservationRoomType = new System.Windows.Forms.TabPage();
            this.Reservebtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkReservationPayment = new System.Windows.Forms.CheckBox();
            this.ReservationCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.ReservationCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.txtRReservationNumberOfGuest = new System.Windows.Forms.TextBox();
            this.txtReservationRoomNumber = new System.Windows.Forms.TextBox();
            this.txtReservationGender = new System.Windows.Forms.TextBox();
            this.txtReservationGuestName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.cmbReservationRoomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.cmbReservationRoomType);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1190, 597);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1182, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search Guest Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(245, 109);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(710, 343);
            this.dataGridView2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(704, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search Guest Info:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 34);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search Guest Info:";
            // 
            // cmbReservationRoomType
            // 
            this.cmbReservationRoomType.Controls.Add(this.Reservebtn);
            this.cmbReservationRoomType.Controls.Add(this.comboBox1);
            this.cmbReservationRoomType.Controls.Add(this.chkReservationPayment);
            this.cmbReservationRoomType.Controls.Add(this.ReservationCheckOutDate);
            this.cmbReservationRoomType.Controls.Add(this.ReservationCheckInDate);
            this.cmbReservationRoomType.Controls.Add(this.txtRReservationNumberOfGuest);
            this.cmbReservationRoomType.Controls.Add(this.txtReservationRoomNumber);
            this.cmbReservationRoomType.Controls.Add(this.txtReservationGender);
            this.cmbReservationRoomType.Controls.Add(this.txtReservationGuestName);
            this.cmbReservationRoomType.Controls.Add(this.label11);
            this.cmbReservationRoomType.Controls.Add(this.label10);
            this.cmbReservationRoomType.Controls.Add(this.label9);
            this.cmbReservationRoomType.Controls.Add(this.label8);
            this.cmbReservationRoomType.Controls.Add(this.label7);
            this.cmbReservationRoomType.Controls.Add(this.label6);
            this.cmbReservationRoomType.Controls.Add(this.label5);
            this.cmbReservationRoomType.Controls.Add(this.label1);
            this.cmbReservationRoomType.Controls.Add(this.label2);
            this.cmbReservationRoomType.Location = new System.Drawing.Point(4, 4);
            this.cmbReservationRoomType.Name = "cmbReservationRoomType";
            this.cmbReservationRoomType.Padding = new System.Windows.Forms.Padding(3);
            this.cmbReservationRoomType.Size = new System.Drawing.Size(1182, 568);
            this.cmbReservationRoomType.TabIndex = 1;
            this.cmbReservationRoomType.Text = "Reserve Guest";
            this.cmbReservationRoomType.UseVisualStyleBackColor = true;
            // 
            // Reservebtn
            // 
            this.Reservebtn.BackColor = System.Drawing.Color.Red;
            this.Reservebtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservebtn.Location = new System.Drawing.Point(565, 465);
            this.Reservebtn.Name = "Reservebtn";
            this.Reservebtn.Size = new System.Drawing.Size(157, 34);
            this.Reservebtn.TabIndex = 28;
            this.Reservebtn.Text = "Reserve";
            this.Reservebtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(571, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // chkReservationPayment
            // 
            this.chkReservationPayment.AutoSize = true;
            this.chkReservationPayment.Location = new System.Drawing.Point(565, 423);
            this.chkReservationPayment.Name = "chkReservationPayment";
            this.chkReservationPayment.Size = new System.Drawing.Size(106, 20);
            this.chkReservationPayment.TabIndex = 23;
            this.chkReservationPayment.Text = "Full Payment";
            this.chkReservationPayment.UseVisualStyleBackColor = true;
            // 
            // ReservationCheckOutDate
            // 
            this.ReservationCheckOutDate.Location = new System.Drawing.Point(565, 362);
            this.ReservationCheckOutDate.Name = "ReservationCheckOutDate";
            this.ReservationCheckOutDate.Size = new System.Drawing.Size(164, 22);
            this.ReservationCheckOutDate.TabIndex = 22;
            // 
            // ReservationCheckInDate
            // 
            this.ReservationCheckInDate.Location = new System.Drawing.Point(565, 323);
            this.ReservationCheckInDate.Name = "ReservationCheckInDate";
            this.ReservationCheckInDate.Size = new System.Drawing.Size(164, 22);
            this.ReservationCheckInDate.TabIndex = 21;
            // 
            // txtRReservationNumberOfGuest
            // 
            this.txtRReservationNumberOfGuest.Location = new System.Drawing.Point(572, 253);
            this.txtRReservationNumberOfGuest.Name = "txtRReservationNumberOfGuest";
            this.txtRReservationNumberOfGuest.Size = new System.Drawing.Size(157, 22);
            this.txtRReservationNumberOfGuest.TabIndex = 20;
            // 
            // txtReservationRoomNumber
            // 
            this.txtReservationRoomNumber.Location = new System.Drawing.Point(572, 221);
            this.txtReservationRoomNumber.Name = "txtReservationRoomNumber";
            this.txtReservationRoomNumber.Size = new System.Drawing.Size(157, 22);
            this.txtReservationRoomNumber.TabIndex = 19;
            // 
            // txtReservationGender
            // 
            this.txtReservationGender.Location = new System.Drawing.Point(572, 148);
            this.txtReservationGender.Name = "txtReservationGender";
            this.txtReservationGender.Size = new System.Drawing.Size(157, 22);
            this.txtReservationGender.TabIndex = 17;
            // 
            // txtReservationGuestName
            // 
            this.txtReservationGuestName.Location = new System.Drawing.Point(572, 113);
            this.txtReservationGuestName.Name = "txtReservationGuestName";
            this.txtReservationGuestName.Size = new System.Drawing.Size(157, 22);
            this.txtReservationGuestName.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(363, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "Payment:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(363, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Check-out Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(363, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Check-in Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(363, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Number of Guest:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Reserve Guest:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Room Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Room Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Guest Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gender:";
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1196, 603);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.cmbReservationRoomType.ResumeLayout(false);
            this.cmbReservationRoomType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage cmbReservationRoomType;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkReservationPayment;
        private System.Windows.Forms.DateTimePicker ReservationCheckOutDate;
        private System.Windows.Forms.DateTimePicker ReservationCheckInDate;
        private System.Windows.Forms.TextBox txtRReservationNumberOfGuest;
        private System.Windows.Forms.TextBox txtReservationRoomNumber;
        private System.Windows.Forms.TextBox txtReservationGender;
        private System.Windows.Forms.TextBox txtReservationGuestName;
        private System.Windows.Forms.Button Reservebtn;
    }
}
