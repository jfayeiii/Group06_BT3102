namespace GOSO_Hotel.UI
{
    partial class FrontDeskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontDeskForm));
            this.label1 = new System.Windows.Forms.Label();
            this.gboxlogin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fdusertxt = new CuoreUI.Controls.cuiTextBox();
            this.loginfdbtn = new System.Windows.Forms.Button();
            this.fdpasstxt = new CuoreUI.Controls.cuiTextBox();
            this.gboxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 70);
            this.label1.TabIndex = 3;
            this.label1.Text = "GOSO Hotel";
            // 
            // gboxlogin
            // 
            this.gboxlogin.BackColor = System.Drawing.Color.White;
            this.gboxlogin.Controls.Add(this.label3);
            this.gboxlogin.Controls.Add(this.label2);
            this.gboxlogin.Controls.Add(this.fdusertxt);
            this.gboxlogin.Controls.Add(this.loginfdbtn);
            this.gboxlogin.Controls.Add(this.fdpasstxt);
            this.gboxlogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxlogin.Location = new System.Drawing.Point(603, 279);
            this.gboxlogin.Name = "gboxlogin";
            this.gboxlogin.Size = new System.Drawing.Size(478, 314);
            this.gboxlogin.TabIndex = 5;
            this.gboxlogin.TabStop = false;
            this.gboxlogin.Text = "Front Desk Login";
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
            // fdusertxt
            // 
            this.fdusertxt.BackColor = System.Drawing.Color.Transparent;
            this.fdusertxt.BackgroundColor = System.Drawing.Color.LightGray;
            this.fdusertxt.Content = "";
            this.fdusertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fdusertxt.FocusBackgroundColor = System.Drawing.Color.White;
            this.fdusertxt.FocusImageTint = System.Drawing.Color.White;
            this.fdusertxt.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.fdusertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdusertxt.ForeColor = System.Drawing.Color.Gray;
            this.fdusertxt.Image = null;
            this.fdusertxt.ImageExpand = new System.Drawing.Point(0, 0);
            this.fdusertxt.ImageOffset = new System.Drawing.Point(0, 0);
            this.fdusertxt.Location = new System.Drawing.Point(53, 97);
            this.fdusertxt.Margin = new System.Windows.Forms.Padding(4);
            this.fdusertxt.Multiline = false;
            this.fdusertxt.Name = "fdusertxt";
            this.fdusertxt.NormalImageTint = System.Drawing.Color.White;
            this.fdusertxt.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fdusertxt.Padding = new System.Windows.Forms.Padding(18, 13, 18, 0);
            this.fdusertxt.PasswordChar = false;
            this.fdusertxt.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.fdusertxt.PlaceholderText = "";
            this.fdusertxt.Rounding = new System.Windows.Forms.Padding(8);
            this.fdusertxt.Size = new System.Drawing.Size(373, 44);
            this.fdusertxt.TabIndex = 3;
            this.fdusertxt.TextOffset = new System.Drawing.Size(0, 0);
            this.fdusertxt.UnderlinedStyle = true;
            // 
            // loginfdbtn
            // 
            this.loginfdbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginfdbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfdbtn.Location = new System.Drawing.Point(146, 227);
            this.loginfdbtn.Name = "loginfdbtn";
            this.loginfdbtn.Size = new System.Drawing.Size(188, 52);
            this.loginfdbtn.TabIndex = 2;
            this.loginfdbtn.Text = "Login";
            this.loginfdbtn.UseVisualStyleBackColor = false;
            this.loginfdbtn.Click += new System.EventHandler(this.loginfdbtn_Click_1);
            // 
            // fdpasstxt
            // 
            this.fdpasstxt.BackColor = System.Drawing.Color.Transparent;
            this.fdpasstxt.BackgroundColor = System.Drawing.Color.LightGray;
            this.fdpasstxt.Content = "";
            this.fdpasstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fdpasstxt.FocusBackgroundColor = System.Drawing.Color.White;
            this.fdpasstxt.FocusImageTint = System.Drawing.Color.White;
            this.fdpasstxt.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.fdpasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdpasstxt.ForeColor = System.Drawing.Color.Gray;
            this.fdpasstxt.Image = null;
            this.fdpasstxt.ImageExpand = new System.Drawing.Point(0, 0);
            this.fdpasstxt.ImageOffset = new System.Drawing.Point(0, 0);
            this.fdpasstxt.Location = new System.Drawing.Point(53, 176);
            this.fdpasstxt.Margin = new System.Windows.Forms.Padding(4);
            this.fdpasstxt.Multiline = false;
            this.fdpasstxt.Name = "fdpasstxt";
            this.fdpasstxt.NormalImageTint = System.Drawing.Color.White;
            this.fdpasstxt.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fdpasstxt.Padding = new System.Windows.Forms.Padding(18, 13, 18, 0);
            this.fdpasstxt.PasswordChar = false;
            this.fdpasstxt.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.fdpasstxt.PlaceholderText = "";
            this.fdpasstxt.Rounding = new System.Windows.Forms.Padding(8);
            this.fdpasstxt.Size = new System.Drawing.Size(373, 44);
            this.fdpasstxt.TabIndex = 1;
            this.fdpasstxt.TextOffset = new System.Drawing.Size(0, 0);
            this.fdpasstxt.UnderlinedStyle = true;
            // 
            // FrontDeskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1615, 870);
            this.Controls.Add(this.gboxlogin);
            this.Controls.Add(this.label1);
            this.Name = "FrontDeskForm";
            this.Text = "FrontDeskForm";
            this.gboxlogin.ResumeLayout(false);
            this.gboxlogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiTextBox fdusertxt;
        private System.Windows.Forms.Button loginfdbtn;
        private CuoreUI.Controls.cuiTextBox fdpasstxt;
    }
}