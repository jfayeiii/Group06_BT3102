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
    public partial class FronDeskDashboard : Form
    {
        public FronDeskDashboard()
        {
            InitializeComponent();
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

        private void fdlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
        }

        private void roomsAvailablebtn_Click(object sender, EventArgs e)
        {
            MovePanel(roomsAvailablebtn);
            FrontDeskPanelMain.Controls.Clear();

            UserControlRoomsAvailable roomsavailable = new UserControlRoomsAvailable();
            roomsavailable.Dock = DockStyle.Fill;


            FrontDeskPanelMain.Controls.Add(roomsavailable);

        }

        private void guestInfobtn_Click(object sender, EventArgs e)
        {
            MovePanel(guestInfobtn);
            FrontDeskPanelMain.Controls.Clear();

            UserControlGuestInformationcs guestInfo = new UserControlGuestInformationcs();
            guestInfo.Dock = DockStyle.Fill;


            FrontDeskPanelMain.Controls.Add(guestInfo);
        }

        private void fdreservationbtn_Click(object sender, EventArgs e)
        {
            MovePanel(fdreservationbtn);
            FrontDeskPanelMain.Controls.Clear();

            UserControlReservation usreserve = new UserControlReservation();
            usreserve.Dock = DockStyle.Fill;


            FrontDeskPanelMain.Controls.Add(usreserve);

        }

        private void fdBillingPaymentbtn_Click(object sender, EventArgs e)
        {
            MovePanel(fdBillingPaymentbtn);
            FrontDeskPanelMain.Controls.Clear();

            UserControlBillingPayment billingPayment = new UserControlBillingPayment();
            billingPayment.Dock = DockStyle.Fill;

            FrontDeskPanelMain.Controls.Add(billingPayment);

        }

        private void fdReservationStatbtn_Click(object sender, EventArgs e)
        {
            MovePanel(fdReservationStatbtn);
            FrontDeskPanelMain.Controls.Clear();

            UserControlReservationStatus stat = new UserControlReservationStatus();
            stat.Dock = DockStyle.Fill;

            FrontDeskPanelMain.Controls.Add(stat);

        }


        private void CheckInCheckOutbtn_Click_1(object sender, EventArgs e)
        {
            MovePanel(CheckInCheckOutbtn);
            FrontDeskPanelMain.Controls.Clear();

            UserControlCheckInCheckOut checkInCheckOut = new UserControlCheckInCheckOut();
            checkInCheckOut.Dock = DockStyle.Fill;

            FrontDeskPanelMain.Controls.Add(checkInCheckOut);

        }

      
    }
}
