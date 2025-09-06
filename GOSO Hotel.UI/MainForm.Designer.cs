namespace GOSO_Hotel.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.adminbtn = new System.Windows.Forms.Button();
            this.fdbtn = new System.Windows.Forms.Button();
            this.cuiGroupBox1 = new CuoreUI.Controls.cuiGroupBox();
            this.cuiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "GOSO Hotel";
            // 
            // adminbtn
            // 
            this.adminbtn.BackColor = System.Drawing.Color.Orange;
            this.adminbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbtn.Location = new System.Drawing.Point(34, 103);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(346, 52);
            this.adminbtn.TabIndex = 1;
            this.adminbtn.Text = "Admin";
            this.adminbtn.UseVisualStyleBackColor = false;
            this.adminbtn.Click += new System.EventHandler(this.loginadminbtn_Click);
            // 
            // fdbtn
            // 
            this.fdbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fdbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdbtn.Location = new System.Drawing.Point(34, 45);
            this.fdbtn.Name = "fdbtn";
            this.fdbtn.Size = new System.Drawing.Size(346, 52);
            this.fdbtn.TabIndex = 0;
            this.fdbtn.Text = "Front Desk";
            this.fdbtn.UseVisualStyleBackColor = false;
            this.fdbtn.Click += new System.EventHandler(this.loginfdbtn_Click);
            // 
            // cuiGroupBox1
            // 
            this.cuiGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiGroupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuiGroupBox1.Content = "Login as";
            this.cuiGroupBox1.Controls.Add(this.adminbtn);
            this.cuiGroupBox1.Controls.Add(this.fdbtn);
            this.cuiGroupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiGroupBox1.Location = new System.Drawing.Point(594, 325);
            this.cuiGroupBox1.Name = "cuiGroupBox1";
            this.cuiGroupBox1.Padding = new System.Windows.Forms.Padding(4, 23, 4, 4);
            this.cuiGroupBox1.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiGroupBox1.Size = new System.Drawing.Size(417, 200);
            this.cuiGroupBox1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1611, 831);
            this.Controls.Add(this.cuiGroupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.cuiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fdbtn;
        private System.Windows.Forms.Button adminbtn;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox1;
    }
}

