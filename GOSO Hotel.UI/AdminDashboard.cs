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
using GOSO_Hotel.Controller;

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
            // subscribe to room status changes so admin UI can refresh
            try
            {
                GOSO_Hotel.Controller.AppEvents.OnRoomStatusChanged -= OnRoomRoomStatusChanged;
                GOSO_Hotel.Controller.AppEvents.OnRoomStatusChanged += OnRoomRoomStatusChanged;
            }
            catch { }
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
            // if the control supports a refresh method, call it
            try
            {
                var adminRec = control as ReservationandGuestRecords;
                if (adminRec != null) adminRec.RefreshRoomLists();

                var reservation = control as UserControlReservation;
                if (reservation != null)
                {
                    try { reservation.GetType().GetMethod("LoadRoomTypes")?.Invoke(reservation, null); } catch { }
                    try { reservation.GetType().GetMethod("UpdateAvailableRoomNumber")?.Invoke(reservation, null); } catch { }
                }
            }
            catch { }
        }

        private void OnRoomRoomStatusChanged()
        {
            try
            {
                if (adminPanelMain.Controls.Count > 0)
                {
                    var control = adminPanelMain.Controls[0];
                    try
                    {
                        var adminRec = control as ReservationandGuestRecords;
                        if (adminRec != null) adminRec.RefreshRoomLists();

                        var reservation = control as UserControlReservation;
                        if (reservation != null)
                        {
                            try { reservation.GetType().GetMethod("LoadRoomTypes")?.Invoke(reservation, null); } catch { }
                            try { reservation.GetType().GetMethod("UpdateAvailableRoomNumber")?.Invoke(reservation, null); } catch { }
                        }
                    }
                    catch { }
                }
            }
            catch { }
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

            // get reservations and set a compact datasource so grid in checkin control shows key reservation fields
            try
            {
                var controller = new CustomerReservationController();
                var items = controller.GetAllForGrid();
                if (items != null)
                {
                    // build compact DataTable with important columns only
                    var table = new DataTable();
                    table.Columns.Add("ReservationId", typeof(int));
                    table.Columns.Add("CustomerName", typeof(string));
                    table.Columns.Add("RoomType", typeof(string));
                    table.Columns.Add("RoomNumber", typeof(string));
                    table.Columns.Add("CheckInDate", typeof(DateTime));
                    table.Columns.Add("CheckOutDate", typeof(DateTime));
                    table.Columns.Add("AmountToPay", typeof(decimal));
                    table.Columns.Add("ReservationStatus", typeof(string));
                    table.Columns.Add("PaymentStatus", typeof(string));

                    foreach (var r in items)
                    {
                        var ci = r.CheckInDate.HasValue ? r.CheckInDate.Value.Date : DateTime.MinValue;
                        var co = r.CheckOutDate.HasValue ? r.CheckOutDate.Value.Date : DateTime.MinValue;

                        table.Rows.Add(
                            r.ReservationId,
                            r.CustomerName ?? string.Empty,
                            r.RoomType ?? string.Empty,
                            r.RoomNumber ?? string.Empty,
                            ci == DateTime.MinValue ? (object)DBNull.Value : ci,
                            co == DateTime.MinValue ? (object)DBNull.Value : co,
                            r.AmountToPay,
                            r.ReservationStatus ?? string.Empty,
                            r.PaymentStatus ?? string.Empty
                        );
                    }

                    checkincheckout.SetGridDataSource(table);
                }
            }
            catch
            {
                // ignore - show control without preloaded grid if something goes wrong
            }

            adminPanelMain.Controls.Add(checkincheckout);

        }
    }
}

