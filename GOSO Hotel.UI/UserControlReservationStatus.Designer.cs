namespace GOSO_Hotel.UI
{
    partial class UserControlReservationStatus
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
            this.label4 = new System.Windows.Forms.Label();
            this.ReservationStatSearchbtn = new System.Windows.Forms.Button();
            this.RStatSearchtxt = new System.Windows.Forms.TextBox();
            this.reservationStatDGrid = new System.Windows.Forms.DataGridView();
            this.RStatReservebtn = new System.Windows.Forms.Button();
            this.RStatCheckInbtn = new System.Windows.Forms.Button();
            this.RStatCheckoutbtn = new System.Windows.Forms.Button();
            this.CancelReservationbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reservationStatDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reservation Status";
            // 
            // ReservationStatSearchbtn
            // 
            this.ReservationStatSearchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReservationStatSearchbtn.Location = new System.Drawing.Point(1060, 12);
            this.ReservationStatSearchbtn.Name = "ReservationStatSearchbtn";
            this.ReservationStatSearchbtn.Size = new System.Drawing.Size(115, 34);
            this.ReservationStatSearchbtn.TabIndex = 12;
            this.ReservationStatSearchbtn.Text = "Search";
            this.ReservationStatSearchbtn.UseVisualStyleBackColor = false;
            // 
            // RStatSearchtxt
            // 
            this.RStatSearchtxt.Location = new System.Drawing.Point(765, 12);
            this.RStatSearchtxt.Multiline = true;
            this.RStatSearchtxt.Name = "RStatSearchtxt";
            this.RStatSearchtxt.Size = new System.Drawing.Size(289, 34);
            this.RStatSearchtxt.TabIndex = 11;
            // 
            // reservationStatDGrid
            // 
            this.reservationStatDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationStatDGrid.Location = new System.Drawing.Point(211, 99);
            this.reservationStatDGrid.Name = "reservationStatDGrid";
            this.reservationStatDGrid.RowHeadersWidth = 51;
            this.reservationStatDGrid.RowTemplate.Height = 24;
            this.reservationStatDGrid.Size = new System.Drawing.Size(757, 426);
            this.reservationStatDGrid.TabIndex = 13;
            // 
            // RStatReservebtn
            // 
            this.RStatReservebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RStatReservebtn.Location = new System.Drawing.Point(974, 99);
            this.RStatReservebtn.Name = "RStatReservebtn";
            this.RStatReservebtn.Size = new System.Drawing.Size(115, 34);
            this.RStatReservebtn.TabIndex = 14;
            this.RStatReservebtn.Text = "Reserve";
            this.RStatReservebtn.UseVisualStyleBackColor = false;
            // 
            // RStatCheckInbtn
            // 
            this.RStatCheckInbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RStatCheckInbtn.Location = new System.Drawing.Point(974, 139);
            this.RStatCheckInbtn.Name = "RStatCheckInbtn";
            this.RStatCheckInbtn.Size = new System.Drawing.Size(115, 34);
            this.RStatCheckInbtn.TabIndex = 15;
            this.RStatCheckInbtn.Text = "Check-in";
            this.RStatCheckInbtn.UseVisualStyleBackColor = false;
            // 
            // RStatCheckoutbtn
            // 
            this.RStatCheckoutbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RStatCheckoutbtn.Location = new System.Drawing.Point(974, 179);
            this.RStatCheckoutbtn.Name = "RStatCheckoutbtn";
            this.RStatCheckoutbtn.Size = new System.Drawing.Size(115, 34);
            this.RStatCheckoutbtn.TabIndex = 16;
            this.RStatCheckoutbtn.Text = "Check-out";
            this.RStatCheckoutbtn.UseVisualStyleBackColor = false;
            // 
            // CancelReservationbtn
            // 
            this.CancelReservationbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelReservationbtn.Location = new System.Drawing.Point(974, 219);
            this.CancelReservationbtn.Name = "CancelReservationbtn";
            this.CancelReservationbtn.Size = new System.Drawing.Size(115, 34);
            this.CancelReservationbtn.TabIndex = 17;
            this.CancelReservationbtn.Text = "Cancel";
            this.CancelReservationbtn.UseVisualStyleBackColor = false;
            // 
            // UserControlReservationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelReservationbtn);
            this.Controls.Add(this.RStatCheckoutbtn);
            this.Controls.Add(this.RStatCheckInbtn);
            this.Controls.Add(this.RStatReservebtn);
            this.Controls.Add(this.reservationStatDGrid);
            this.Controls.Add(this.ReservationStatSearchbtn);
            this.Controls.Add(this.RStatSearchtxt);
            this.Controls.Add(this.label4);
            this.Name = "UserControlReservationStatus";
            this.Size = new System.Drawing.Size(1196, 603);
            ((System.ComponentModel.ISupportInitialize)(this.reservationStatDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReservationStatSearchbtn;
        private System.Windows.Forms.TextBox RStatSearchtxt;
        private System.Windows.Forms.DataGridView reservationStatDGrid;
        private System.Windows.Forms.Button RStatReservebtn;
        private System.Windows.Forms.Button RStatCheckInbtn;
        private System.Windows.Forms.Button RStatCheckoutbtn;
        private System.Windows.Forms.Button CancelReservationbtn;
    }
}
