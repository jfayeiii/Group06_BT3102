using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using GOSO_Hotel.Controller;

namespace GOSO_Hotel.UI.UseControlAdmin
{
    public partial class ReservationandGuestRecords : UserControl
    {
        private readonly CustomerReservationController controller;

        public string FrontDeskOperatorName { get; set; }

        public ReservationandGuestRecords()
        {
            InitializeComponent();
            controller = new CustomerReservationController();
            FrontDeskOperatorName = Environment.UserName;
            InitializeControls();
            LoadGrid();
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            RecalculateAmounts();
        }

        private void InitializeControls()
        {
            gendercmb.Items.AddRange(new[] { "Male", "Female", "Other" });
            IDtypecmb.Items.AddRange(new[] { "Passport", "Driver's License", "National ID" });

            try
            {
                var types = controller.GetRoomTypes();
                if (types != null && types.Count > 0)
                    roomtypecmb.Items.AddRange(types.ToArray());
                else
                    roomtypecmb.Items.AddRange(new[] { "Single", "Double", "Suite" });
            }
            catch
            {
                roomtypecmb.Items.AddRange(new[] { "Single", "Double", "Suite" });
            }

            comboBox3.Items.AddRange(new[] { "Reserved", "CheckedIn", "CheckedOut", "Cancelled" });

            roomtypecmb.SelectedIndexChanged += Roomtypecmb_SelectedIndexChanged;
            checkinDTPicker.ValueChanged += Dates_ValueChanged;
            CheckoutDTPicker.ValueChanged += Dates_ValueChanged;

            txtTotalPriceNight.TextChanged += (s, e) => RecalculateAmounts();

            roomnumbercmb.SelectedIndexChanged += Roomnumbercmb_SelectedIndexChanged;

            btnSave.Click += BtnSave_Click;

            btnCancelReservation.Click += BtnCancelReservation_Click;

            searchbtn.Click += Searchbtn_Click;
            textBox2.KeyDown += TextBox2_KeyDown;
            try
            {
                AppEvents.OnRoomStatusChanged -= OnRoomStatusChangedHandler;
                AppEvents.OnRoomStatusChanged += OnRoomStatusChangedHandler;
            }
            catch { }

            try
            {
                this.VisibleChanged -= ReservationandGuestRecords_VisibleChanged;
                this.VisibleChanged += ReservationandGuestRecords_VisibleChanged;
            }
            catch { }
        }

        private void OnRoomStatusChangedHandler()
        {
            try
            {
                this.BeginInvoke((Action)(() =>
                {
                    try { MessageBox.Show("Room status changed event received", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information); } catch { }
                    try
                    {
                        var prev = roomtypecmb.SelectedItem?.ToString();
                        roomtypecmb.Items.Clear();
                        var types = controller.GetRoomTypes();
                        if (types != null && types.Count > 0)
                        {
                            roomtypecmb.Items.AddRange(types.ToArray());
                        }
                        if (!string.IsNullOrWhiteSpace(prev) && roomtypecmb.Items.Contains(prev))
                        {
                            roomtypecmb.SelectedItem = prev;
                        }
                        else if (roomtypecmb.Items.Count > 0)
                        {
                            roomtypecmb.SelectedIndex = 0;
                        }

                        try { LoadAvailableRoomsForSelectedType(); } catch { }
                    }
                    catch { }

                    try { LoadGrid(); } catch { }
                }));
            }
            catch { }
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGBCustomerReservation.CurrentRow == null)
                {
                    MessageBox.Show("Select a reservation in the grid first.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cell = DGBCustomerReservation.CurrentRow.Cells["ReservationId"];
                if (cell == null || cell.Value == null)
                {
                    MessageBox.Show("Selected row does not contain a reservation id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cell.Value.ToString(), out int reservationId))
                {
                    MessageBox.Show("Invalid reservation id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Open the Check-In/Check-Out control and select the reservation to proceed.", "Manual Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initiate check-in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                PerformSearch();
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            try
            {
                var txt = textBox2.Text?.Trim();
                if (string.IsNullOrWhiteSpace(txt))
                {
                    LoadGrid();
                    return;
                }

                if (!int.TryParse(txt, out var id))
                {
                    MessageBox.Show("Please enter a valid numeric Reservation ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var items = controller.GetAllForGrid();
                var table = new DataTable();
                table.Columns.Add("ReservationId", typeof(int));
                table.Columns.Add("CustomerName", typeof(string));
                table.Columns.Add("RoomType", typeof(string));
                table.Columns.Add("RoomNumber", typeof(string));
                table.Columns.Add("RoomGuest", typeof(string));
                table.Columns.Add("CheckInDate", typeof(DateTime));
                table.Columns.Add("CheckOutDate", typeof(DateTime));
                table.Columns.Add("Nights", typeof(int));
                table.Columns.Add("TotalPricePerNight", typeof(decimal));
                table.Columns.Add("AmountToPay", typeof(decimal));
                table.Columns.Add("AmountPaid", typeof(decimal));
                table.Columns.Add("ChangeDue", typeof(decimal));
                table.Columns.Add("ReservationStatus", typeof(string));
                table.Columns.Add("PaymentStatus", typeof(string));

                bool found = false;
                if (items != null)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        var r = items[i];
                        if (r == null) continue;
                        if (r.ReservationId != id) continue;

                        var checkIn = r.CheckInDate.HasValue ? r.CheckInDate.Value.Date : DateTime.MinValue;
                        var checkOut = r.CheckOutDate.HasValue ? r.CheckOutDate.Value.Date : DateTime.MinValue;
                        var nights = 0;
                        if (r.CheckInDate.HasValue && r.CheckOutDate.HasValue)
                        {
                            nights = (r.CheckOutDate.Value.Date - r.CheckInDate.Value.Date).Days;
                            if (nights < 0) nights = 0;
                        }

                        table.Rows.Add(
                            r.ReservationId,
                            r.CustomerName ?? string.Empty,
                            r.RoomType ?? string.Empty,
                            r.RoomNumber ?? string.Empty,
                            r.RoomGuest ?? string.Empty,
                            checkIn == DateTime.MinValue ? (object)DBNull.Value : checkIn,
                            checkOut == DateTime.MinValue ? (object)DBNull.Value : checkOut,
                            nights,
                            r.TotalPricePerNight,
                            r.AmountToPay,
                            r.AmountPaid,
                            r.ChangeDue,
                            r.ReservationStatus ?? string.Empty,
                            r.PaymentStatus ?? string.Empty
                        );

                        found = true;
                        break; // only one
                    }
                }

                if (!found)
                {
                    MessageBox.Show($"No reservation found with ID {id}.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DGBCustomerReservation.DataSource = table;
                DGBCustomerReservation.AutoGenerateColumns = true;
                DGBCustomerReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (DGBCustomerReservation.Columns.Contains("ReservationId"))
                    DGBCustomerReservation.Columns["ReservationId"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dates_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableRoomsForSelectedType();

            RecalculateAmounts();
        }

        private void Roomtypecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableRoomsForSelectedType();
        }

        private void Roomnumbercmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var roomNo = roomnumbercmb.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(roomNo)) return;

                var room = controller.GetRoomByRoomNo(roomNo);
                if (room == null) return;

                txtTotalPriceNight.Text = room.PricePerNight.ToString("F2");

                txtGuestAllowed.Text = room.Capacity.ToString();

                if (string.IsNullOrWhiteSpace(txtroomguest.Text))
                {
                    txtroomguest.Text = room.Capacity.ToString();
                }

                txtPaymentStatus.Text = "Full Payment";

                RecalculateAmounts();
            }
            catch (Exception ex)
            {
            }
        }

        private void LoadAvailableRoomsForSelectedType()
        {
            try
            {
                var selectedType = roomtypecmb.SelectedItem?.ToString();
                roomnumbercmb.Items.Clear();

                if (string.IsNullOrWhiteSpace(selectedType)) return;

                var checkIn = checkinDTPicker.Value.Date;
                var checkOut = CheckoutDTPicker.Value.Date;

                var roomNumbers = controller.GetAvailableRoomNumbersByType(selectedType, checkIn, checkOut);
                foreach (var rn in roomNumbers)
                {
                    roomnumbercmb.Items.Add(rn);
                }

                if (roomnumbercmb.Items.Count > 0)
                    roomnumbercmb.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load room numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecalculateAmounts()
        {
            try
            {
                decimal pricePerNight = 0m;
                decimal.TryParse(txtTotalPriceNight.Text, out pricePerNight);

                var checkIn = checkinDTPicker.Value.Date;
                var checkOut = CheckoutDTPicker.Value.Date;
                int nights = (checkOut - checkIn).Days;
                if (nights < 1) nights = 1;

                var totalToPay = pricePerNight * nights;
                txtAmountToPay.Text = totalToPay.ToString("F2");

                decimal amountPaid = 0m;
                decimal.TryParse(txtAmountPaid.Text, out amountPaid);

                var change = amountPaid - totalToPay;
                if (change < 0) change = 0m;
                txtChangeDue.Text = change.ToString("F2");
            }
            catch
            {
            }
        }

        private void LoadGrid()
        {
            try
            {
                var items = controller.GetAllForGrid();

                var table = new DataTable();
                table.Columns.Add("ReservationId", typeof(int));
                table.Columns.Add("CustomerName", typeof(string));
                table.Columns.Add("RoomType", typeof(string));
                table.Columns.Add("RoomNumber", typeof(string));
                table.Columns.Add("RoomGuest", typeof(string));
                table.Columns.Add("CheckInDate", typeof(DateTime));
                table.Columns.Add("CheckOutDate", typeof(DateTime));
                table.Columns.Add("Nights", typeof(int));
                table.Columns.Add("TotalPricePerNight", typeof(decimal));
                table.Columns.Add("AmountToPay", typeof(decimal));
                table.Columns.Add("AmountPaid", typeof(decimal));
                table.Columns.Add("ChangeDue", typeof(decimal));
                table.Columns.Add("ReservationStatus", typeof(string));
                table.Columns.Add("PaymentStatus", typeof(string));

                if (items != null)
                {
                    foreach (var r in items)
                    {
                        var checkIn = r.CheckInDate.HasValue ? r.CheckInDate.Value.Date : DateTime.MinValue;
                        var checkOut = r.CheckOutDate.HasValue ? r.CheckOutDate.Value.Date : DateTime.MinValue;
                        var nights = 0;
                        if (r.CheckInDate.HasValue && r.CheckOutDate.HasValue)
                        {
                            nights = (r.CheckOutDate.Value.Date - r.CheckInDate.Value.Date).Days;
                            if (nights < 0) nights = 0;
                        }

                        table.Rows.Add(
                            r.ReservationId,
                            r.CustomerName ?? string.Empty,
                            r.RoomType ?? string.Empty,
                            r.RoomNumber ?? string.Empty,
                            r.RoomGuest ?? string.Empty,
                            checkIn == DateTime.MinValue ? (object)DBNull.Value : checkIn,
                            checkOut == DateTime.MinValue ? (object)DBNull.Value : checkOut,
                            nights,
                            r.TotalPricePerNight,
                            r.AmountToPay,
                            r.AmountPaid,
                            r.ChangeDue,
                            r.ReservationStatus ?? string.Empty,
                            r.PaymentStatus ?? string.Empty
                        );
                    }
                }

                DGBCustomerReservation.DataSource = table;

                DGBCustomerReservation.AutoGenerateColumns = true;
                DGBCustomerReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (DGBCustomerReservation.Columns.Contains("ReservationId"))
                    DGBCustomerReservation.Columns["ReservationId"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load reservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = MapFromForm();
                if (string.IsNullOrWhiteSpace(model.ReservationStatus))
                {
                    if (model.CheckInDate.HasValue)
                    {
                        var today = DateTime.Now.Date;
                        if (model.CheckInDate.Value.Date >= today)
                        {
                            model.ReservationStatus = "Reserved";
                        }
                        else
                        {
                            model.ReservationStatus = "Reserved";
                        }
                    }
                    else
                    {
                        model.ReservationStatus = "Reserved";
                    }
                }

                var validation = controller.ValidateReservation(model);
                if (!validation.isValid)
                {
                    MessageBox.Show(validation.errorMessage, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.AmountPaid = decimal.TryParse(txtAmountPaid.Text, out var ap) ? ap : 0m;
                model.ChangeDue = decimal.TryParse(txtChangeDue.Text, out var ch) ? ch : 0m;

                var newId = controller.Create(model);

                try
                {
                    PrintReservation(model);
                }
                catch (Exception pex)
                {
                    MessageBox.Show("Saved but printing failed: " + pex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show($"Reservation saved (ID: {newId})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGBCustomerReservation.CurrentRow == null)
                {
                    MessageBox.Show("Select a reservation in the grid first.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cell = DGBCustomerReservation.CurrentRow.Cells["ReservationId"];
                if (cell == null || cell.Value == null)
                {
                    MessageBox.Show("Selected row does not contain a reservation id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cell.Value.ToString(), out int reservationId))
                {
                    MessageBox.Show("Invalid reservation id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show($"Cancel reservation {reservationId}?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                var ok = controller.CancelReservation(reservationId);
                if (ok)
                {
                    MessageBox.Show("Reservation cancelled and room status updated.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Failed to cancel reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatPhp(decimal amount)
        {
            return $"Php {amount:N2}";
        }

        private void PrintReservation(CustomerReservationModel model)
        {
            if (model == null) return;

            var pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = false;
            pd.PrintPage += (s, ev) =>
            {
                var g = ev.Graphics;
                int margin = 40;
                int left = margin;
                int right = ev.PageBounds.Width - margin;
                float y = margin;

                // Fonts
                var headerFont = new Font("Segoe UI", 16, FontStyle.Bold);
                var subHeaderFont = new Font("Segoe UI", 12, FontStyle.Bold);
                var regularFont = new Font("Segoe UI", 10, FontStyle.Regular);
                var boldFont = new Font("Segoe UI", 10, FontStyle.Bold);
                var amountFont = new Font("Segoe UI", 10, FontStyle.Bold);

                float lineSpacing = Math.Max(regularFont.GetHeight(g), 16f) + 4f;

                string hotelName = "GOSO HOTEL";
                var hotelSize = g.MeasureString(hotelName, headerFont);
                g.DrawString(hotelName, headerFont, Brushes.Black, (ev.PageBounds.Width - hotelSize.Width) / 2f, y);
                y += hotelSize.Height + 4f;

                string hotelInfo = "123 Hotel Street, City · (02) 1234-5678 · info@gosohotel.example";
                var infoSize = g.MeasureString(hotelInfo, regularFont);
                g.DrawString(hotelInfo, regularFont, Brushes.Gray, (ev.PageBounds.Width - infoSize.Width) / 2f, y);
                y += infoSize.Height + 10f;

                // Title
                string title = "Reservation Receipt";
                var titleSize = g.MeasureString(title, subHeaderFont);
                g.DrawString(title, subHeaderFont, Brushes.Black, (ev.PageBounds.Width - titleSize.Width) / 2f, y);
                y += titleSize.Height + 8f;

                string operatorName = string.IsNullOrWhiteSpace(FrontDeskOperatorName) ? "Front Desk" : FrontDeskOperatorName;
                string dateStr = DateTime.Now.ToString("yyyy-MM-dd");
                string timeStr = DateTime.Now.ToString("HH:mm:ss");

                g.DrawString($"Issued by: {operatorName}", regularFont, Brushes.Black, left, y);
                var datetime = $"{dateStr}  {timeStr}";
                var dtSize = g.MeasureString(datetime, regularFont);
                g.DrawString(datetime, regularFont, Brushes.Black, right - dtSize.Width, y);
                y += lineSpacing;

                // Separator
                var pen = new Pen(Color.LightGray) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
                g.DrawLine(pen, left, y, right, y);
                y += 8f;

                // Customer block
                g.DrawString("Customer Details", boldFont, Brushes.Black, left, y);
                y += lineSpacing;

                void DrawLabelValue(string label, string value)
                {
                    g.DrawString(label, boldFont, Brushes.Black, left, y);
                    g.DrawString(value ?? string.Empty, regularFont, Brushes.Black, left + 90, y);
                    y += lineSpacing;
                }

                DrawLabelValue("Name:", model.CustomerName);
                DrawLabelValue("Contact:", model.Contact);
                if (!string.IsNullOrWhiteSpace(model.Email)) DrawLabelValue("Email:", model.Email);
                if (!string.IsNullOrWhiteSpace(model.Address)) DrawLabelValue("Address:", model.Address);

                y += 6f;
                g.DrawLine(pen, left, y, right, y);
                y += 8f;

                // Reservation details (left) and amounts (right) — align vertically
                g.DrawString("Reservation Details", boldFont, Brushes.Black, left, y);
                y += lineSpacing;

                // remember start y for amounts
                float detailsStartY = y;
                float amountsY = detailsStartY;

                // Left column details
                void DrawDetail(string label, string value)
                {
                    g.DrawString(label, boldFont, Brushes.Black, left, y);
                    g.DrawString(value ?? string.Empty, regularFont, Brushes.Black, left + 100, y);
                    y += lineSpacing;
                }

                DrawDetail("Room Type:", model.RoomType);
                DrawDetail("Room Number:", model.RoomNumber);
                DrawDetail("Guest(s):", model.RoomGuest);

                if (model.CheckInDate.HasValue && model.CheckOutDate.HasValue)
                {
                    var ci = model.CheckInDate.Value.Date.ToString("yyyy-MM-dd");
                    var co = model.CheckOutDate.Value.Date.ToString("yyyy-MM-dd");
                    int nights = (model.CheckOutDate.Value.Date - model.CheckInDate.Value.Date).Days;
                    if (nights < 1) nights = 1;

                    DrawDetail("Check-in:", ci);
                    DrawDetail("Check-out:", co);
                    DrawDetail("Nights:", nights.ToString());
                }

                float amountsLabelX = right - 220;
                float amountsValueX = right - 40;

                void DrawAmount(string label, string value)
                {
                    g.DrawString(label, boldFont, Brushes.Black, amountsLabelX, amountsY);

                    float availableWidth = (amountsValueX - amountsLabelX) - 8f; 

                    float fontSize = amountFont.Size;
                    Font f = amountFont;
                    var measured = g.MeasureString(value, f);
                    while (measured.Width > availableWidth && fontSize > 6f)
                    {
                        fontSize -= 1f;
                        f = new Font(amountFont.FontFamily, fontSize, amountFont.Style);
                        measured = g.MeasureString(value, f);
                    }

                    g.DrawString(value, f, Brushes.Black, amountsValueX - measured.Width, amountsY);

                    if (!object.ReferenceEquals(f, amountFont)) f.Dispose();

                    amountsY += lineSpacing;
                }

                DrawAmount("Price/Night", FormatPhp(model.TotalPricePerNight));
                DrawAmount("Amount Due", FormatPhp(model.AmountToPay));
                DrawAmount("Amount Paid", FormatPhp(model.AmountPaid));
                DrawAmount("Change", FormatPhp(model.ChangeDue));

                // advance y below amounts area if needed
                y = Math.Max(y, amountsY) + 12f;

                // Payment status under amounts
                g.DrawString($"Payment Status: {model.PaymentStatus}", regularFont, Brushes.Black, amountsLabelX, y);
                y += lineSpacing + 6f;

                // Signature line
                g.DrawLine(Pens.LightGray, left, y, right, y);
                y += 12f;
                g.DrawString("Customer Signature:", regularFont, Brushes.Black, left, y);
                g.DrawLine(Pens.Black, left + 140, y + 12, left + 420, y + 12);
                y += 36f;

                // Footer
                string note = "Please present this receipt during check-in as proof of reservation.";
                var nf = new Font("Segoe UI", 9, FontStyle.Italic);
                var noteSize = g.MeasureString(note, nf, right - left);
                g.DrawString(note, nf, Brushes.Black, (ev.PageBounds.Width - noteSize.Width) / 2f, y);
                y += noteSize.Height + 8f;

                string thanks = "Thank you for choosing GOSO Hotel!";
                var tf = new Font("Segoe UI", 11, FontStyle.Bold);
                var ts = g.MeasureString(thanks, tf);
                g.DrawString(thanks, tf, Brushes.Black, (ev.PageBounds.Width - ts.Width) / 2f, y);

                ev.HasMorePages = false;
            };

            using (var preview = new PrintPreviewDialog())
            {
                preview.Document = pd;
                try { preview.Width = 900; preview.Height = 700; } catch { }
                preview.ShowDialog();
            }
        }

        private CustomerReservationModel MapFromForm()
        {
            var model = new CustomerReservationModel
            {
                CustomerName = txtCustomerName.Text.Trim(),
                Gender = gendercmb.SelectedItem?.ToString(),
                Nationality = txtNationality.Text.Trim(),
                IdType = IDtypecmb.SelectedItem?.ToString(),
                IdNumber = textBox1.Text.Trim(),
                Contact = txtContact.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = textBox1.Text.Trim(),

                RoomType = roomtypecmb.SelectedItem?.ToString(),
                RoomNumber = roomnumbercmb.SelectedItem?.ToString(),
                ReservationStatus = comboBox3.SelectedItem?.ToString(),
                TimeOfArrival = ParseTime(txtTimeofArrival.Text.Trim()),
                RoomGuest = txtroomguest.Text.Trim(),
                CheckInDate = checkinDTPicker.Value.Date,
                CheckOutDate = CheckoutDTPicker.Value.Date,
                TotalPricePerNight = ParseDecimal(txtTotalPriceNight.Text),
                AmountToPay = ParseDecimal(txtAmountToPay.Text),
                PaymentStatus = txtPaymentStatus.Text.Trim(),
                AmountPaid = ParseDecimal(txtAmountPaid.Text),
                ChangeDue = ParseDecimal(txtChangeDue.Text)
            };

            return model;
        }

        private TimeSpan? ParseTime(string txt)
        {
            if (TimeSpan.TryParse(txt, out var t)) return t;
            return null;
        }

        private decimal ParseDecimal(string txt)
        {
            if (decimal.TryParse(txt, out var d)) return d;
            return 0m;
        }

        private void ClearForm()
        {
            txtCustomerName.Text = string.Empty;
            gendercmb.SelectedIndex = -1;
            txtNationality.Text = string.Empty;
            IDtypecmb.SelectedIndex = -1;
            textBox1.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtEmail.Text = string.Empty;
            roomtypecmb.SelectedIndex = -1;
            roomnumbercmb.Items.Clear();
            roomnumbercmb.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            txtroomguest.Text = string.Empty;
            txtTimeofArrival.Text = string.Empty;
            txtTotalPriceNight.Text = string.Empty;
            txtAmountToPay.Text = string.Empty;
            txtAmountPaid.Text = string.Empty;
            txtChangeDue.Text = string.Empty;
            txtPaymentStatus.Text = string.Empty;
            txtGuestAllowed.Text = string.Empty;
            checkinDTPicker.Value = DateTime.Now;
            CheckoutDTPicker.Value = DateTime.Now.AddDays(1);
        }

        private void DGBCustomerReservation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var row = DGBCustomerReservation.Rows[e.RowIndex];
                if (row == null) return;
                var idCell = row.Cells["ReservationId"];
                if (idCell == null || idCell.Value == null) return;
                if (!int.TryParse(idCell.Value.ToString(), out int reservationId)) return;

                var res = controller.GetById(reservationId);
                if (res == null) return;

                var top = this.FindForm();
                if (top == null) return;

                var admin = top as AdminDashboard;
                if (admin != null)
                {
                    var checkinControl = new UserControlCheckInCheckOut();
                    checkinControl.PrefillFromReservationModel(res);
                    admin.LoadUserControl(checkinControl);
                    return;
                }

                var fd = top as FronDeskDashboard;
                if (fd != null)
                {
                    var checkinControl = new UserControlCheckInCheckOut();
                    checkinControl.PrefillFromReservationModel(res);
                    fd.LoadUserControl(checkinControl);
                    return;
                }
            }
            catch
            {
            }
        }

        private void ReservationandGuestRecords_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    try { 
                        var prev = roomtypecmb.SelectedItem?.ToString();
                        roomtypecmb.Items.Clear();
                        var types = controller.GetRoomTypes();
                        if (types != null && types.Count > 0) roomtypecmb.Items.AddRange(types.ToArray());
                        if (!string.IsNullOrWhiteSpace(prev) && roomtypecmb.Items.Contains(prev)) roomtypecmb.SelectedItem = prev; else if (roomtypecmb.Items.Count > 0) roomtypecmb.SelectedIndex = 0;
                        LoadAvailableRoomsForSelectedType();
                    }
                    catch { }
                    try { LoadGrid(); } catch { }
                }
            }
            catch { }
        }

        public void RefreshRoomLists()
        {
            try
            {
                var prev = roomtypecmb.SelectedItem?.ToString();
                roomtypecmb.Items.Clear();
                var types = controller.GetRoomTypes();
                if (types != null && types.Count > 0) roomtypecmb.Items.AddRange(types.ToArray());
                if (!string.IsNullOrWhiteSpace(prev) && roomtypecmb.Items.Contains(prev)) roomtypecmb.SelectedItem = prev; else if (roomtypecmb.Items.Count > 0) roomtypecmb.SelectedIndex = 0;
                try { LoadAvailableRoomsForSelectedType(); } catch { }
            }
            catch { }
        }
    }
}
