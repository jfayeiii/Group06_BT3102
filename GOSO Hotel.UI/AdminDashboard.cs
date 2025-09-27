using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOSO_Hotel.UI
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            // Open at ~95% of the screen
            Rectangle workArea = Screen.PrimaryScreen.WorkingArea;
            int width = (int)(workArea.Width * 0.80);
            int height = (int)(workArea.Height * 0.80);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(width, height);
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void Adminlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                
            }
        }

        private void AdminRoombtn_Click(object sender, EventArgs e)
        {
            MovePanel(AdminRoombtn);
            adminPanelMain.Controls.Clear();

            UserControlRooms roomControl = new UserControlRooms();
            roomControl.Dock = DockStyle.Fill; 

           
           adminPanelMain.Controls.Add(roomControl);
        }
       

        private void guestrecordsbtn_Click(object sender, EventArgs e)
        {
            MovePanel(guestrecordsbtn);

            adminPanelMain.Controls.Clear();
            UserControlGuestRecords userControlGuestRecords = new UserControlGuestRecords();
            userControlGuestRecords.Dock = DockStyle.Fill;


            adminPanelMain.Controls.Add(userControlGuestRecords);


        }
    }
}
    

