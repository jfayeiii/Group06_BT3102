using GOSO_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSO_Hotel.Repository
{
    public class RoomRepository
    {
        private readonly string connectionString;

        public RoomRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["GOSOHotel"].ConnectionString;
        }

        public RoomModel CreateRoom(RoomModel room)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Room (RoomNo, RoomType, PricePerNight, Capacity, Status, NoOfBeds, CreatedDate)
                                     VALUES (@roomNo, @roomType, @pricePerNight, @capacity, @status, @noOfBeds, @createdDate);
                                     SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@roomNo", room.RoomNo);
                        command.Parameters.AddWithValue("@roomType", room.RoomType);
                        command.Parameters.AddWithValue("@pricePerNight", room.PricePerNight);
                        command.Parameters.AddWithValue("@capacity", room.Capacity);
                        command.Parameters.AddWithValue("@status", room.Status);
                        command.Parameters.AddWithValue("@noOfBeds", room.NoOfBeds);
                        command.Parameters.AddWithValue("@createdDate", room.CreatedDate);

                        int newId = Convert.ToInt32(command.ExecuteScalar());
                        room.Id = newId;
                        return room;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database error creating room: {ex.Message}");
                throw;
            }
        }

        public RoomModel GetRoomById(int roomId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Room WHERE Id = @id";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", roomId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count == 0)
                                return null;

                            DataRow row = table.Rows[0];
                            return new RoomModel
                            {
                                Id = (int)row["Id"],
                                RoomNo = (int)row["RoomNo"],
                                RoomType = row["RoomType"].ToString(),
                                PricePerNight = (decimal)row["PricePerNight"],
                                Capacity = (int)row["Capacity"],
                                NoOfBeds = (int)row["NoOfBeds"],
                                Status = row["Status"].ToString(),
                                CreatedDate = (DateTime)row["CreatedDate"],
                                ModifiedDate = row["ModifiedDate"] != DBNull.Value
                                    ? (DateTime?)row["ModifiedDate"]
                                    : null
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database error retrieving room: {ex.Message}");
                throw;
            }
        }

        public List<RoomModel> GetAllRooms()
        {
            try
            {
                List<RoomModel> rooms = new List<RoomModel>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Room";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            rooms.Add(new RoomModel
                            {
                                Id = (int)row["Id"],
                                RoomNo = (int)row["RoomNo"],
                                RoomType = row["RoomType"].ToString(),
                                PricePerNight = (decimal)row["PricePerNight"],
                                Capacity = (int)row["Capacity"],
                                NoOfBeds = (int)row["NoOfBeds"],
                                Status = row["Status"].ToString(),
                                CreatedDate = (DateTime)row["CreatedDate"],
                                ModifiedDate = row["ModifiedDate"] != DBNull.Value
                                    ? (DateTime?)row["ModifiedDate"]
                                    : null
                            });
                        }
                    }
                }

                return rooms;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database error retrieving all rooms: {ex.Message}");
                throw;
            }
        }

        public RoomModel UpdateRoom(RoomModel room)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Room SET 
                                        RoomNo = @roomNo,
                                        RoomType = @roomType,
                                        PricePerNight = @pricePerNight,
                                        Capacity = @capacity,
                                        Status = @status,
                                        NoOfBeds = @noOfBeds,
                                        ModifiedDate = @modifiedDate
                                     WHERE Id = @id";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", room.Id);
                        command.Parameters.AddWithValue("@roomNo", room.RoomNo);
                        command.Parameters.AddWithValue("@roomType", room.RoomType);
                        command.Parameters.AddWithValue("@pricePerNight", room.PricePerNight);
                        command.Parameters.AddWithValue("@capacity", room.Capacity);
                        command.Parameters.AddWithValue("@status", room.Status);
                        command.Parameters.AddWithValue("@noOfBeds", room.NoOfBeds);
                        command.Parameters.AddWithValue("@modifiedDate", room.ModifiedDate ?? DateTime.Now);

                        command.ExecuteNonQuery();
                    }

                    return room;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database error updating room: {ex.Message}");
                throw;
            }
        }

        public bool DeleteRoomByNumber(int roomNo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Room WHERE RoomNo = @roomNo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomNo", roomNo);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting room: {ex.Message}");
                throw;
            }
        }

        public RoomModel GetRoomByRoomNo(string roomNo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Room WHERE RoomNo = @roomNo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@roomNo", roomNo);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RoomModel
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                RoomNo = Convert.ToInt32(reader["RoomNo"]),
                                Capacity = Convert.ToInt32(reader["Capacity"]),
                                Status = reader["Status"].ToString(),
                                NoOfBeds = Convert.ToInt32(reader["NoOfBeds"]),
                                RoomType = reader["RoomType"].ToString(),
                                PricePerNight = Convert.ToDecimal(reader["PricePerNight"])
                            };
                        }
                    }
                }
            }
            return null;
        }

    }
}
