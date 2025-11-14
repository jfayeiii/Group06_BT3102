using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GOSO_Hotel.Controller;
using GOSO_Hotel.Model;

namespace GOSO_Hotel.UI
{
    public partial class UserControlRooms : UserControl
    {
        private RoomController _roomController;
        private int selectedRoomId = 0;
        public UserControlRooms()
        {
            InitializeComponent();
            LoadComboBox();
            _roomController = new RoomController();
            LoadAllRooms();
        }

        public void LoadComboBox()
        {
            cbStatus.Items.AddRange(new string[] { "Available", "Occupied", "Reserved", "Out of Service" });
            txtRoomType.Items.AddRange(new string[] { "Single", "Double", "Suite", "Deluxe" });
            RoomStatusUpdate.Items.AddRange(new string[] { "Available", "Occupied", "Reserved", "Out of Service" });
            txtRoomTypeUpdate.Items.AddRange(new string[] { "Single", "Double", "Suite", "Deluxe" });
        }

        private void LoadAllRooms()
        {
            try
            {
                List<RoomModel> rooms = _roomController.GetAllRooms();
                BindGrid(roomSearchDGrid, rooms);
                BindGrid(roomDeleteDGrid, rooms);
                BindGrid(RoomModificationDGrid, rooms);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(DataGridView grid, List<RoomModel> rooms)
        {
            grid.AutoGenerateColumns = true;
            grid.DataSource = null;
            grid.DataSource = rooms;
        }


        private void roomDeleteDGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        
            if (e.RowIndex < 0) return;

            var room = roomSearchDGrid.Rows[e.RowIndex].DataBoundItem as RoomModel;
            if (room != null)
            {
                selectedRoomId = room.Id;
                txtRoomNo.Text = room.RoomNo.ToString();
                txtRoomType.Text = room.RoomType;
                txtPrice.Text = room.PricePerNight.ToString();
                txtCapacity.Text = room.Capacity.ToString();
                txtBedNo.Text = room.NoOfBeds.ToString();
                cbStatus.SelectedItem = room.Status;
            }
        }

        private void RoomNotxt_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

      
            try
            {
                if (string.IsNullOrWhiteSpace(RoomNotxt.Text))
                {
                    MessageBox.Show("Please enter a room number to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int roomNo = Convert.ToInt32(RoomNotxt.Text);
                var filteredRooms = _roomController.GetAllRooms().Where(r => r.RoomNo == roomNo).ToList();

                if (filteredRooms.Any())
                    BindGrid(roomSearchDGrid, filteredRooms);
                else
                {
                    MessageBox.Show("Room not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllRooms();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            selectedRoomId = 0;
            try
            {
                if (string.IsNullOrWhiteSpace(txtRoomNo.Text) || string.IsNullOrWhiteSpace(txtRoomType.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtCapacity.Text) ||
                    string.IsNullOrWhiteSpace(txtBedNo.Text) || cbStatus.SelectedItem == null)
                {
                    MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int roomNo = Convert.ToInt32(txtRoomNo.Text);
                string roomType = txtRoomType.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);
                int capacity = Convert.ToInt32(txtCapacity.Text);
                int beds = Convert.ToInt32(txtBedNo.Text);
                string status = cbStatus.SelectedItem.ToString();

                if (selectedRoomId == 0)
                {
                    var newRoom = _roomController.CreateRoom(roomNo, roomType, price, capacity, beds);
                    MessageBox.Show($"Room {newRoom.RoomNo} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var updatedRoom = _roomController.UpdateRoom(selectedRoomId, roomNo, roomType, price, capacity, beds, status);
                    MessageBox.Show($"Room {updatedRoom.RoomNo} updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedRoomId = 0;
                }

                ClearFields();
                LoadAllRooms();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtRoomNo.Text = string.Empty;
            txtRoomType.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtCapacity.Text = string.Empty;
            txtBedNo.Text = string.Empty;
            cbStatus.SelectedIndex = 0;
            selectedRoomId = 0;
        }

        private void deleteRoomSearchbtn_Click_1(object sender, EventArgs e)
        {

        string roomNo = txtDeleteByRoomNo.Text.Trim();

            if (string.IsNullOrEmpty(roomNo))
            {
                MessageBox.Show("Enter a room number.");
                return;
            }

            var result = _roomController.GetAllRooms();

            roomDeleteDGrid.DataSource = result.Count > 0 ? result : null;

            if (result.Count == 0)
                MessageBox.Show("No room found.");
        }

        private void deleteRoombtn_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDeleteByRoomNo.Text))
            {
                MessageBox.Show("Enter a room number first.");
                return;
            }

            int roomNo = Convert.ToInt32(txtDeleteByRoomNo.Text);

            if (MessageBox.Show("Delete this room?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_roomController.DeleteRoomByNumber(roomNo))
                {
                    MessageBox.Show("Room deleted successfully!");
                    txtDeleteByRoomNo.Clear();
                    LoadAllRooms();
                }
                else
                {
                    MessageBox.Show("No room found with that number.");
                }
            }
        }

        private void RoomModSearchbtn_Click_1(object sender, EventArgs e)
        {

        string roomNo = RoomModSearchtxt.Text.Trim();
            if (string.IsNullOrEmpty(roomNo))
            {
                MessageBox.Show("Enter a room number to search.");
                return;
            }

            RoomModel room = _roomController.GetRoomByRoomNo(roomNo);
            if (room == null)
            {
                MessageBox.Show("Room not found.");
                return;
            }

            selectedRoomId = room.Id;
            RoomNoUpdatecmb.Text = room.RoomNo.ToString();
            txtCapacityUpdate.Text = room.Capacity.ToString();
            RoomStatusUpdate.Text = room.Status;
            txtBedCountUpdate.Text = room.NoOfBeds.ToString();
            txtRoomTypeUpdate.Text = room.RoomType;
            txtRoomPriceUpdate.Text = room.PricePerNight.ToString();
        }

        private void RoomModUpdatebtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtRoomTypeUpdate.Text))
                {
                    MessageBox.Show("Enter room number first.");
                    return;
                }

                int roomId = selectedRoomId;
                int roomNo = Convert.ToInt32(RoomNoUpdatecmb.Text);
                string roomType = txtRoomTypeUpdate.Text.Trim();
                decimal price = Convert.ToDecimal(txtRoomPriceUpdate.Text);
                int capacity = Convert.ToInt32(txtCapacityUpdate.Text);
                int beds = Convert.ToInt32(txtBedCountUpdate.Text);
                string status = RoomStatusUpdate.Text.Trim();

                var updatedRoom = _roomController.UpdateRoom(roomId, roomNo, roomType, price, capacity, beds, status);

                if (updatedRoom != null)
                {
                    MessageBox.Show("Room updated successfully!");
                    LoadAllRooms();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room: " + ex.Message);
            }
        }


        private void RoomModificationDGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

 
            if (e.RowIndex < 0) return;

            var room = RoomModificationDGrid.Rows[e.RowIndex].DataBoundItem as RoomModel;
            if (room == null) return;

            selectedRoomId = room.Id;
            RoomNoUpdatecmb.Text = room.RoomNo.ToString();
            txtCapacityUpdate.Text = room.Capacity.ToString();
            RoomStatusUpdate.Text = room.Status;
            txtBedCountUpdate.Text = room.NoOfBeds.ToString();
            txtRoomTypeUpdate.Text = room.RoomType;
            txtRoomPriceUpdate.Text = room.PricePerNight.ToString();
        }

        
    }
}
