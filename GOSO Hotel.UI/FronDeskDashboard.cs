using GOSO_Hotel.Controller;
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

        private void reservationstatsbtn_Click(object sender, EventArgs e)
        {
            MovePanel(reservationstatsbtn);
            FrontDeskPanelMain.Controls.Clear();

            var rec = new GOSO_Hotel.UI.UseControlAdmin.ReservationandGuestRecords();
            rec.Dock = DockStyle.Fill;
            FrontDeskPanelMain.Controls.Add(rec);
        }

        private void BillingPaymentbtn_Click(object sender, EventArgs e)
        {
            MovePanel(BillingPaymentbtn);
            FrontDeskPanelMain.Controls.Clear();

            var billingPayment = new UserControlBillingPayment();
            billingPayment.Dock = DockStyle.Fill;
            FrontDeskPanelMain.Controls.Add(billingPayment);
        }

        // Designer expects method named checkincheckoutbtn_Click
        private void checkincheckoutbtn_Click(object sender, EventArgs e)
        {
            MovePanel(checkincheckoutbtn);

            FrontDeskPanelMain.Controls.Clear();
            UserControlCheckInCheckOut checkincheckout = new UserControlCheckInCheckOut();
            checkincheckout.Dock = DockStyle.Fill;

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
            }

            FrontDeskPanelMain.Controls.Add(checkincheckout);


        }

        public void LoadUserControl(UserControl control)
        {
            FrontDeskPanelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            FrontDeskPanelMain.Controls.Add(control);
            try
            {
                var adminRec = control as GOSO_Hotel.UI.UseControlAdmin.ReservationandGuestRecords;
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
                if (FrontDeskPanelMain.Controls.Count > 0)
                {
                    var control = FrontDeskPanelMain.Controls[0];
                    try
                    {
                        var adminRec = control as GOSO_Hotel.UI.UseControlAdmin.ReservationandGuestRecords;
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
    }
}
