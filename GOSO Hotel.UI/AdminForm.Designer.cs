namespace GOSO_Hotel.UI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.gboxlogin = new System.Windows.Forms.GroupBox();
            this.loginAdminbtn = new System.Windows.Forms.Button();
            this.adminpasstxt = new CuoreUI.Controls.cuiTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminusertxt = new CuoreUI.Controls.cuiTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gboxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxlogin
            // 
            this.gboxlogin.BackColor = System.Drawing.Color.White;
            this.gboxlogin.Controls.Add(this.label3);
            this.gboxlogin.Controls.Add(this.label2);
            this.gboxlogin.Controls.Add(this.adminusertxt);
            this.gboxlogin.Controls.Add(this.loginAdminbtn);
            this.gboxlogin.Controls.Add(this.adminpasstxt);
            this.gboxlogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxlogin.Location = new System.Drawing.Point(550, 238);
            this.gboxlogin.Name = "gboxlogin";
            this.gboxlogin.Size = new System.Drawing.Size(478, 314);
            this.gboxlogin.TabIndex = 4;
            this.gboxlogin.TabStop = false;
            this.gboxlogin.Text = "Admin Login";
            // 
            // loginAdminbtn
            // 
            this.loginAdminbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginAdminbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdminbtn.Location = new System.Drawing.Point(146, 227);
            this.loginAdminbtn.Name = "loginAdminbtn";
            this.loginAdminbtn.Size = new System.Drawing.Size(188, 52);
            this.loginAdminbtn.TabIndex = 2;
            this.loginAdminbtn.Text = "Login";
            this.loginAdminbtn.UseVisualStyleBackColor = false;
            this.loginAdminbtn.Click += new System.EventHandler(this.loginAdminbtn_Click);
            // 
            // adminpasstxt
            // 
            this.adminpasstxt.BackColor = System.Drawing.Color.Transparent;
            this.adminpasstxt.BackgroundColor = System.Drawing.Color.LightGray;
            this.adminpasstxt.Content = "";
            this.adminpasstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminpasstxt.FocusBackgroundColor = System.Drawing.Color.White;
            this.adminpasstxt.FocusImageTint = System.Drawing.Color.White;
            this.adminpasstxt.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.adminpasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpasstxt.ForeColor = System.Drawing.Color.Gray;
            this.adminpasstxt.Image = null;
            this.adminpasstxt.ImageExpand = new System.Drawing.Point(0, 0);
            this.adminpasstxt.ImageOffset = new System.Drawing.Point(0, 0);
            this.adminpasstxt.Location = new System.Drawing.Point(53, 176);
            this.adminpasstxt.Margin = new System.Windows.Forms.Padding(4);
            this.adminpasstxt.Multiline = false;
            this.adminpasstxt.Name = "adminpasstxt";
            this.adminpasstxt.NormalImageTint = System.Drawing.Color.White;
            this.adminpasstxt.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.adminpasstxt.Padding = new System.Windows.Forms.Padding(18, 13, 18, 0);
            this.adminpasstxt.PasswordChar = false;
            this.adminpasstxt.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.adminpasstxt.PlaceholderText = "";
            this.adminpasstxt.Rounding = new System.Windows.Forms.Padding(8);
            this.adminpasstxt.Size = new System.Drawing.Size(373, 44);
            this.adminpasstxt.TabIndex = 1;
            this.adminpasstxt.TextOffset = new System.Drawing.Size(0, 0);
            this.adminpasstxt.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = "GOSO Hotel";
            // 
            // adminusertxt
            // 
            this.adminusertxt.BackColor = System.Drawing.Color.Transparent;
            this.adminusertxt.BackgroundColor = System.Drawing.Color.LightGray;
            this.adminusertxt.Content = "";
            this.adminusertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminusertxt.FocusBackgroundColor = System.Drawing.Color.White;
            this.adminusertxt.FocusImageTint = System.Drawing.Color.White;
            this.adminusertxt.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.adminusertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminusertxt.ForeColor = System.Drawing.Color.Gray;
            this.adminusertxt.Image = null;
            this.adminusertxt.ImageExpand = new System.Drawing.Point(0, 0);
            this.adminusertxt.ImageOffset = new System.Drawing.Point(0, 0);
            this.adminusertxt.Location = new System.Drawing.Point(53, 97);
            this.adminusertxt.Margin = new System.Windows.Forms.Padding(4);
            this.adminusertxt.Multiline = false;
            this.adminusertxt.Name = "adminusertxt";
            this.adminusertxt.NormalImageTint = System.Drawing.Color.White;
            this.adminusertxt.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.adminusertxt.Padding = new System.Windows.Forms.Padding(18, 13, 18, 0);
            this.adminusertxt.PasswordChar = false;
            this.adminusertxt.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.adminusertxt.PlaceholderText = "";
            this.adminusertxt.Rounding = new System.Windows.Forms.Padding(8);
            this.adminusertxt.Size = new System.Drawing.Size(373, 44);
            this.adminusertxt.TabIndex = 3;
            this.adminusertxt.TextOffset = new System.Drawing.Size(0, 0);
            this.adminusertxt.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1615, 870);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboxlogin);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.gboxlogin.ResumeLayout(false);
            this.gboxlogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxlogin;
        private System.Windows.Forms.Button loginAdminbtn;
        private CuoreUI.Controls.cuiTextBox adminpasstxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiTextBox adminusertxt;
    }
}