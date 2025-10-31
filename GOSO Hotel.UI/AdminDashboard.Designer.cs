namespace GOSO_Hotel.UI
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.guestrecordsbtn = new System.Windows.Forms.Button();
            this.AdminRoombtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Adminlogout = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.adminPanelMain = new System.Windows.Forms.Panel();
            this.reservationstatsbtn = new System.Windows.Forms.Button();
            this.BillingPaymentbtn = new System.Windows.Forms.Button();
            this.checkincheckoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 872);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(72, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 153);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "GOSO Hotel";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelSlide);
            this.panel3.Controls.Add(this.guestrecordsbtn);
            this.panel3.Controls.Add(this.AdminRoombtn);
            this.panel3.Controls.Add(this.reservationstatsbtn);
            this.panel3.Controls.Add(this.BillingPaymentbtn);
            this.panel3.Controls.Add(this.checkincheckoutbtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 619);
            this.panel3.TabIndex = 2;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Black;
            this.panelSlide.ForeColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(47, 3);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(17, 81);
            this.panelSlide.TabIndex = 3;
            // 
            // guestrecordsbtn
            // 
            this.guestrecordsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestrecordsbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestrecordsbtn.ForeColor = System.Drawing.Color.Black;
            this.guestrecordsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guestrecordsbtn.Location = new System.Drawing.Point(47, 90);
            this.guestrecordsbtn.Name = "guestrecordsbtn";
            this.guestrecordsbtn.Size = new System.Drawing.Size(297, 81);
            this.guestrecordsbtn.TabIndex = 1;
            this.guestrecordsbtn.Text = "Guest Records";
            this.guestrecordsbtn.UseVisualStyleBackColor = true;
            this.guestrecordsbtn.Click += new System.EventHandler(this.guestrecordsbtn_Click);
            // 
            // AdminRoombtn
            // 
            this.AdminRoombtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminRoombtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRoombtn.ForeColor = System.Drawing.Color.Black;
            this.AdminRoombtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminRoombtn.Location = new System.Drawing.Point(47, 3);
            this.AdminRoombtn.Name = "AdminRoombtn";
            this.AdminRoombtn.Size = new System.Drawing.Size(297, 81);
            this.AdminRoombtn.TabIndex = 0;
            this.AdminRoombtn.Text = "Rooms";
            this.AdminRoombtn.UseVisualStyleBackColor = true;
            this.AdminRoombtn.Click += new System.EventHandler(this.AdminRoombtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Adminlogout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(344, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 205);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome Admin";
            // 
            // Adminlogout
            // 
            this.Adminlogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Adminlogout.AutoSize = true;
            this.Adminlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminlogout.Location = new System.Drawing.Point(1128, 129);
            this.Adminlogout.Name = "Adminlogout";
            this.Adminlogout.Size = new System.Drawing.Size(83, 23);
            this.Adminlogout.TabIndex = 1;
            this.Adminlogout.TabStop = true;
            this.Adminlogout.Text = "Log out";
            this.Adminlogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Adminlogout_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1132, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.adminPanelMain);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(344, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1262, 667);
            this.panel4.TabIndex = 3;
            // 
            // adminPanelMain
            // 
            this.adminPanelMain.Location = new System.Drawing.Point(5, 5);
            this.adminPanelMain.Name = "adminPanelMain";
            this.adminPanelMain.Size = new System.Drawing.Size(1247, 661);
            this.adminPanelMain.TabIndex = 0;
            // 
            // reservationstatsbtn
            // 
            this.reservationstatsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationstatsbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationstatsbtn.ForeColor = System.Drawing.Color.Black;
            this.reservationstatsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationstatsbtn.Location = new System.Drawing.Point(47, 177);
            this.reservationstatsbtn.Name = "reservationstatsbtn";
            this.reservationstatsbtn.Size = new System.Drawing.Size(297, 81);
            this.reservationstatsbtn.TabIndex = 4;
            this.reservationstatsbtn.Text = "Reservation";
            this.reservationstatsbtn.UseVisualStyleBackColor = true;
            this.reservationstatsbtn.Click += new System.EventHandler(this.reservationstatsbtn_Click);
            // 
            // BillingPaymentbtn
            // 
            this.BillingPaymentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillingPaymentbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingPaymentbtn.ForeColor = System.Drawing.Color.Black;
            this.BillingPaymentbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BillingPaymentbtn.Location = new System.Drawing.Point(47, 264);
            this.BillingPaymentbtn.Name = "BillingPaymentbtn";
            this.BillingPaymentbtn.Size = new System.Drawing.Size(297, 81);
            this.BillingPaymentbtn.TabIndex = 5;
            this.BillingPaymentbtn.Text = "Billing/Payment";
            this.BillingPaymentbtn.UseVisualStyleBackColor = true;
            this.BillingPaymentbtn.Click += new System.EventHandler(this.BillingPaymentbtn_Click);
            // 
            // checkincheckoutbtn
            // 
            this.checkincheckoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkincheckoutbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkincheckoutbtn.ForeColor = System.Drawing.Color.Black;
            this.checkincheckoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkincheckoutbtn.Location = new System.Drawing.Point(46, 351);
            this.checkincheckoutbtn.Name = "checkincheckoutbtn";
            this.checkincheckoutbtn.Size = new System.Drawing.Size(297, 81);
            this.checkincheckoutbtn.TabIndex = 6;
            this.checkincheckoutbtn.Text = "Checkin/Checkout";
            this.checkincheckoutbtn.UseVisualStyleBackColor = true;
            this.checkincheckoutbtn.Click += new System.EventHandler(this.checkincheckoutbtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 872);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AdminRoombtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Adminlogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button guestrecordsbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel adminPanelMain;
        private System.Windows.Forms.Button reservationstatsbtn;
        private System.Windows.Forms.Button BillingPaymentbtn;
        private System.Windows.Forms.Button checkincheckoutbtn;
    }
}