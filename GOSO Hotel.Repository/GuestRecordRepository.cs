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
    public class GuestRecordRepository
    {
        private readonly string connectionString;

        public GuestRecordRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["GOSOHotel"].ConnectionString;
        }

        public GuestRecordModel GetById(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT CustomerID, RoomNo, Status FROM GuestRecord WHERE CustomerID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", customerId);
                conn.Open();

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;

                    return new GuestRecordModel
                    {
                        CustomerID = Convert.ToInt32(r["CustomerID"]),
                        RoomNo = r["RoomNo"].ToString(),
                        Status = r["Status"].ToString()
                    };
                }
            }
        }

        public string CheckInGuest(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_CheckInGuest", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    return r.Read() ? r[0].ToString() : "No response.";
                }
            }
        }

        public string CheckOutGuest(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_CheckOutGuest", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    return r.Read() ? r[0].ToString() : "No response.";
                }
            }
        }
    }
}