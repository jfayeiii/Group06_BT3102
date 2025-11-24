using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GOSO_Hotel.UI.UseControlAdmin;

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
        public void LoadUserControl(UserControl control)
        {
            adminPanelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            adminPanelMain.Controls.Add(control);
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
            

            
            UserControlGuestRecords userControlGuestRecords = new UserControlGuestRecords();
            userControlGuestRecords.Dock = DockStyle.Fill;


            adminPanelMain.Controls.Add(userControlGuestRecords);


        }

        private void reservationstatsbtn_Click(object sender, EventArgs e)
        {
            MovePanel(reservationstatsbtn);

            LoadUserControl(new ReservationandGuestRecords());


           

        }

        private void BillingPaymentbtn_Click(object sender, EventArgs e)
        {
            MovePanel(BillingPaymentbtn);

            adminPanelMain.Controls.Clear();
            UserControlBillingPayment usercontroladminbilling = new UserControlBillingPayment();
            usercontroladminbilling.Dock = DockStyle.Fill;


            adminPanelMain.Controls.Add(usercontroladminbilling);

        }

        private void checkincheckoutbtn_Click(object sender, EventArgs e)
        {
            MovePanel(checkincheckoutbtn);

            adminPanelMain.Controls.Clear();
            UserControlCheckInCheckOut checkincheckout = new UserControlCheckInCheckOut();
            checkincheckout.Dock = DockStyle.Fill;


            adminPanelMain.Controls.Add(checkincheckout);

        }
    }
}
    

