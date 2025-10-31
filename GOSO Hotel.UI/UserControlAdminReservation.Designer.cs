namespace GOSO_Hotel.UI
{
    partial class UserControlAdminReservation
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
            this.tabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteReservationbtn = new System.Windows.Forms.Button();
            this.CancelReservationbtn = new System.Windows.Forms.Button();
            this.RStatCheckoutbtn = new System.Windows.Forms.Button();
            this.RStatCheckInbtn = new System.Windows.Forms.Button();
            this.RStatReservebtn = new System.Windows.Forms.Button();
            this.reservationStatDGrid = new System.Windows.Forms.DataGridView();
            this.ReservationStatSearchbtn = new System.Windows.Forms.Button();
            this.RStatSearchtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Reservebtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkReservationPayment = new System.Windows.Forms.CheckBox();
            this.ReservationCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.ReservationCheckInDate = new System.Windows.Forms.DateTimePicker();
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
            this.guestnumbercmb = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationStatDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1192, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.guestnumbercmb);
            this.tabPage.Controls.Add(this.Reservebtn);
            this.tabPage.Controls.Add(this.comboBox1);
            this.tabPage.Controls.Add(this.chkReservationPayment);
            this.tabPage.Controls.Add(this.ReservationCheckOutDate);
            this.tabPage.Controls.Add(this.ReservationCheckInDate);
            this.tabPage.Controls.Add(this.txtReservationRoomNumber);
            this.tabPage.Controls.Add(this.txtReservationGender);
            this.tabPage.Controls.Add(this.txtReservationGuestName);
            this.tabPage.Controls.Add(this.label11);
            this.tabPage.Controls.Add(this.label10);
            this.tabPage.Controls.Add(this.label9);
            this.tabPage.Controls.Add(this.label8);
            this.tabPage.Controls.Add(this.label7);
            this.tabPage.Controls.Add(this.label6);
            this.tabPage.Controls.Add(this.label5);
            this.tabPage.Controls.Add(this.label1);
            this.tabPage.Controls.Add(this.label2);
            this.tabPage.Location = new System.Drawing.Point(4, 4);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(1184, 571);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Reserve Guest";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteReservationbtn);
            this.tabPage2.Controls.Add(this.CancelReservationbtn);
            this.tabPage2.Controls.Add(this.RStatCheckoutbtn);
            this.tabPage2.Controls.Add(this.RStatCheckInbtn);
            this.tabPage2.Controls.Add(this.RStatReservebtn);
            this.tabPage2.Controls.Add(this.reservationStatDGrid);
            this.tabPage2.Controls.Add(this.ReservationStatSearchbtn);
            this.tabPage2.Controls.Add(this.RStatSearchtxt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1184, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservation Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteReservationbtn
            // 
            this.deleteReservationbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteReservationbtn.Location = new System.Drawing.Point(973, 261);
            this.deleteReservationbtn.Name = "deleteReservationbtn";
            this.deleteReservationbtn.Size = new System.Drawing.Size(115, 34);
            this.deleteReservationbtn.TabIndex = 35;
            this.deleteReservationbtn.Text = "Delete";
            this.deleteReservationbtn.UseVisualStyleBackColor = false;
            // 
            // CancelReservationbtn
            // 
            this.CancelReservationbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelReservationbtn.Location = new System.Drawing.Point(973, 221);
            this.CancelReservationbtn.Name = "CancelReservationbtn";
            this.CancelReservationbtn.Size = new System.Drawing.Size(115, 34);
            this.CancelReservationbtn.TabIndex = 34;
            this.CancelReservationbtn.Text = "Cancel";
            this.CancelReservationbtn.UseVisualStyleBackColor = false;
            // 
            // RStatCheckoutbtn
            // 
            this.RStatCheckoutbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RStatCheckoutbtn.Location = new System.Drawing.Point(973, 181);
            this.RStatCheckoutbtn.Name = "RStatCheckoutbtn";
            this.RStatCheckoutbtn.Size = new System.Drawing.Size(115, 34);
            this.RStatCheckoutbtn.TabIndex = 33;
            this.RStatCheckoutbtn.Text = "Check-out";
            this.RStatCheckoutbtn.UseVisualStyleBackColor = false;
            // 
            // RStatCheckInbtn
            // 
            this.RStatCheckInbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RStatCheckInbtn.Location = new System.Drawing.Point(973, 141);
            this.RStatCheckInbtn.Name = "RStatCheckInbtn";
            this.RStatCheckInbtn.Size = new System.Drawing.Size(115, 34);
            this.RStatCheckInbtn.TabIndex = 32;
            this.RStatCheckInbtn.Text = "Check-in";
            this.RStatCheckInbtn.UseVisualStyleBackColor = false;
            // 
            // RStatReservebtn
            // 
            this.RStatReservebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RStatReservebtn.Location = new System.Drawing.Point(973, 101);
            this.RStatReservebtn.Name = "RStatReservebtn";
            this.RStatReservebtn.Size = new System.Drawing.Size(115, 34);
            this.RStatReservebtn.TabIndex = 31;
            this.RStatReservebtn.Text = "Reserve";
            this.RStatReservebtn.UseVisualStyleBackColor = false;
            // 
            // reservationStatDGrid
            // 
            this.reservationStatDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationStatDGrid.Location = new System.Drawing.Point(210, 101);
            this.reservationStatDGrid.Name = "reservationStatDGrid";
            this.reservationStatDGrid.RowHeadersWidth = 51;
            this.reservationStatDGrid.RowTemplate.Height = 24;
            this.reservationStatDGrid.Size = new System.Drawing.Size(757, 426);
            this.reservationStatDGrid.TabIndex = 30;
            // 
            // ReservationStatSearchbtn
            // 
            this.ReservationStatSearchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReservationStatSearchbtn.Location = new System.Drawing.Point(1059, 14);
            this.ReservationStatSearchbtn.Name = "ReservationStatSearchbtn";
            this.ReservationStatSearchbtn.Size = new System.Drawing.Size(115, 34);
            this.ReservationStatSearchbtn.TabIndex = 29;
            this.ReservationStatSearchbtn.Text = "Search";
            this.ReservationStatSearchbtn.UseVisualStyleBackColor = false;
            // 
            // RStatSearchtxt
            // 
            this.RStatSearchtxt.Location = new System.Drawing.Point(764, 14);
            this.RStatSearchtxt.Multiline = true;
            this.RStatSearchtxt.Name = "RStatSearchtxt";
            this.RStatSearchtxt.Size = new System.Drawing.Size(289, 34);
            this.RStatSearchtxt.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Reservation Status:";
            // 
            // Reservebtn
            // 
            this.Reservebtn.BackColor = System.Drawing.Color.Red;
            this.Reservebtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservebtn.Location = new System.Drawing.Point(683, 453);
            this.Reservebtn.Name = "Reservebtn";
            this.Reservebtn.Size = new System.Drawing.Size(157, 34);
            this.Reservebtn.TabIndex = 46;
            this.Reservebtn.Text = "Reserve";
            this.Reservebtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(482, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 24);
            this.comboBox1.TabIndex = 45;
            // 
            // chkReservationPayment
            // 
            this.chkReservationPayment.AutoSize = true;
            this.chkReservationPayment.Location = new System.Drawing.Point(482, 406);
            this.chkReservationPayment.Name = "chkReservationPayment";
            this.chkReservationPayment.Size = new System.Drawing.Size(106, 20);
            this.chkReservationPayment.TabIndex = 44;
            this.chkReservationPayment.Text = "Full Payment";
            this.chkReservationPayment.UseVisualStyleBackColor = true;
            // 
            // ReservationCheckOutDate
            // 
            this.ReservationCheckOutDate.Location = new System.Drawing.Point(482, 351);
            this.ReservationCheckOutDate.Name = "ReservationCheckOutDate";
            this.ReservationCheckOutDate.Size = new System.Drawing.Size(358, 22);
            this.ReservationCheckOutDate.TabIndex = 43;
            // 
            // ReservationCheckInDate
            // 
            this.ReservationCheckInDate.Location = new System.Drawing.Point(482, 312);
            this.ReservationCheckInDate.Name = "ReservationCheckInDate";
            this.ReservationCheckInDate.Size = new System.Drawing.Size(358, 22);
            this.ReservationCheckInDate.TabIndex = 42;
            // 
            // txtReservationRoomNumber
            // 
            this.txtReservationRoomNumber.Location = new System.Drawing.Point(482, 207);
            this.txtReservationRoomNumber.Name = "txtReservationRoomNumber";
            this.txtReservationRoomNumber.Size = new System.Drawing.Size(358, 22);
            this.txtReservationRoomNumber.TabIndex = 40;
            // 
            // txtReservationGender
            // 
            this.txtReservationGender.Location = new System.Drawing.Point(482, 137);
            this.txtReservationGender.Name = "txtReservationGender";
            this.txtReservationGender.Size = new System.Drawing.Size(358, 22);
            this.txtReservationGender.TabIndex = 39;
            // 
            // txtReservationGuestName
            // 
            this.txtReservationGuestName.Location = new System.Drawing.Point(482, 99);
            this.txtReservationGuestName.Name = "txtReservationGuestName";
            this.txtReservationGuestName.Size = new System.Drawing.Size(358, 22);
            this.txtReservationGuestName.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(290, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 19);
            this.label11.TabIndex = 37;
            this.label11.Text = "Payment:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Check-out Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Check-in Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Number of Guest:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Reserve Guest:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Room Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Room Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Guest Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Gender:";
            // 
            // guestnumbercmb
            // 
            this.guestnumbercmb.FormattingEnabled = true;
            this.guestnumbercmb.Location = new System.Drawing.Point(482, 239);
            this.guestnumbercmb.Name = "guestnumbercmb";
            this.guestnumbercmb.Size = new System.Drawing.Size(358, 24);
            this.guestnumbercmb.TabIndex = 47;
            // 
            // UserControlAdminReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlAdminReservation";
            this.Size = new System.Drawing.Size(1196, 603);
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationStatDGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button deleteReservationbtn;
        private System.Windows.Forms.Button CancelReservationbtn;
        private System.Windows.Forms.Button RStatCheckoutbtn;
        private System.Windows.Forms.Button RStatCheckInbtn;
        private System.Windows.Forms.Button RStatReservebtn;
        private System.Windows.Forms.DataGridView reservationStatDGrid;
        private System.Windows.Forms.Button ReservationStatSearchbtn;
        private System.Windows.Forms.TextBox RStatSearchtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reservebtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkReservationPayment;
        private System.Windows.Forms.DateTimePicker ReservationCheckOutDate;
        private System.Windows.Forms.DateTimePicker ReservationCheckInDate;
        private System.Windows.Forms.TextBox txtReservationRoomNumber;
        private System.Windows.Forms.TextBox txtReservationGender;
        private System.Windows.Forms.TextBox txtReservationGuestName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox guestnumbercmb;
    }
}
