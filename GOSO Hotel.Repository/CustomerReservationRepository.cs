using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GOSO_Hotel.Model.Model;

namespace GOSO_Hotel.Repository
{
    public class CustomerReservationRepository
    {
        private readonly string connectionString;

        public CustomerReservationRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["GOSOHotel"].ConnectionString;
        }

        public int Create(CustomerReservationModel model)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO CustomerReservation
(CustomerName, Gender, Nationality, IdType, IdNumber, Contact, Email, Address,
 RoomType, RoomNumber, ReservationStatus, TimeOfArrival, RoomGuest, CheckInDate, CheckOutDate,
 TotalPricePerNight, AmountToPay, PaymentStatus, AmountPaid, ChangeDue)
VALUES
(@CustomerName, @Gender, @Nationality, @IdType, @IdNumber, @Contact, @Email, @Address,
 @RoomType, @RoomNumber, @ReservationStatus, @TimeOfArrival, @RoomGuest, @CheckInDate, @CheckOutDate,
 @TotalPricePerNight, @AmountToPay, @PaymentStatus, @AmountPaid, @ChangeDue);
SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.AddWithValue("@CustomerName", (object)model.CustomerName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Gender", (object)model.Gender ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nationality", (object)model.Nationality ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdType", (object)model.IdType ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdNumber", (object)model.IdNumber ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Contact", (object)model.Contact ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)model.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", (object)model.Address ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@RoomType", (object)model.RoomType ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@RoomNumber", (object)model.RoomNumber ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ReservationStatus", (object)model.ReservationStatus ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TimeOfArrival", (object)model.TimeOfArrival ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@RoomGuest", (object)model.RoomGuest ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CheckInDate", (object)model.CheckInDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CheckOutDate", (object)model.CheckOutDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TotalPricePerNight", model.TotalPricePerNight);
                    cmd.Parameters.AddWithValue("@AmountToPay", model.AmountToPay);
                    cmd.Parameters.AddWithValue("@PaymentStatus", (object)model.PaymentStatus ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@AmountPaid", model.AmountPaid);
                    cmd.Parameters.AddWithValue("@ChangeDue", model.ChangeDue);

                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating reservation: " + ex.Message);
                throw;
            }
        }

        public bool DeleteReservation(int reservationId)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM CustomerReservation WHERE ReservationId = @id";
                    cmd.Parameters.AddWithValue("@id", reservationId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting reservation: " + ex.Message);
                throw;
            }
        }

        public bool UpdateReservationStatus(int reservationId, string status)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE CustomerReservation SET ReservationStatus = @status WHERE ReservationId = @id";
                    cmd.Parameters.AddWithValue("@status", status ?? string.Empty);
                    cmd.Parameters.AddWithValue("@id", reservationId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating reservation status: " + ex.Message);
                throw;
            }
        }

        public bool UpdateReservationPaymentAndStatus(int reservationId, string paymentStatus, decimal amountPaid, decimal changeDue)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE CustomerReservation SET PaymentStatus = @paymentStatus, AmountPaid = @amountPaid, ChangeDue = @changeDue, ReservationStatus = @status WHERE ReservationId = @id";
                    cmd.Parameters.AddWithValue("@paymentStatus", (object)paymentStatus ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@amountPaid", amountPaid);
                    cmd.Parameters.AddWithValue("@changeDue", changeDue);
                    cmd.Parameters.AddWithValue("@status", "CheckedIn");
                    cmd.Parameters.AddWithValue("@id", reservationId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating reservation payment/status: " + ex.Message);
                throw;
            }
        }
        public bool UpdateReservationPaymentAndStatusWithStatus(int reservationId, string paymentStatus, decimal amountPaid, decimal changeDue, string status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE CustomerReservation SET PaymentStatus = @paymentStatus, AmountPaid = @amountPaid, ChangeDue = @changeDue, ReservationStatus = @status WHERE ReservationId = @reservationId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@paymentStatus", paymentStatus ?? string.Empty);
                        cmd.Parameters.AddWithValue("@amountPaid", amountPaid);
                        cmd.Parameters.AddWithValue("@changeDue", changeDue);
                        cmd.Parameters.AddWithValue("@status", status ?? string.Empty);
                        cmd.Parameters.AddWithValue("@reservationId", reservationId);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating reservation payment/status: " + ex.Message);
                throw;
            }
        }
        public CustomerReservationModel GetById(int reservationId)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CustomerReservation WHERE ReservationId = @id";
                    cmd.Parameters.AddWithValue("@id", reservationId);
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        da.Fill(table);
                        if (table.Rows.Count == 0) return null;

                        var row = table.Rows[0];
                        var m = new CustomerReservationModel
                        {
                            ReservationId = row["ReservationId"] != DBNull.Value ? Convert.ToInt32(row["ReservationId"]) : 0,
                            CustomerId = row.Table.Columns.Contains("CustomerId") && row["CustomerId"] != DBNull.Value ? Convert.ToInt32(row["CustomerId"]) : 0,
                            CustomerName = row["CustomerName"]?.ToString(),
                            Gender = row["Gender"]?.ToString(),
                            Nationality = row["Nationality"]?.ToString(),
                            IdType = row["IdType"]?.ToString(),
                            IdNumber = row["IdNumber"]?.ToString(),
                            Contact = row["Contact"]?.ToString(),
                            Email = row["Email"]?.ToString(),
                            Address = row["Address"]?.ToString(),

                            RoomType = row["RoomType"]?.ToString(),
                            RoomNumber = row["RoomNumber"]?.ToString(),
                            ReservationStatus = row["ReservationStatus"]?.ToString(),
                            TimeOfArrival = row.Table.Columns.Contains("TimeOfArrival") && row["TimeOfArrival"] != DBNull.Value ? (TimeSpan?)row["TimeOfArrival"] : null,
                            RoomGuest = row["RoomGuest"]?.ToString(),
                            CheckInDate = row.Table.Columns.Contains("CheckInDate") && row["CheckInDate"] != DBNull.Value ? (DateTime?)row["CheckInDate"] : null,
                            CheckOutDate = row.Table.Columns.Contains("CheckOutDate") && row["CheckOutDate"] != DBNull.Value ? (DateTime?)row["CheckOutDate"] : null,
                            TotalPricePerNight = row.Table.Columns.Contains("TotalPricePerNight") && row["TotalPricePerNight"] != DBNull.Value ? Convert.ToDecimal(row["TotalPricePerNight"]) : 0m,
                            AmountToPay = row.Table.Columns.Contains("AmountToPay") && row["AmountToPay"] != DBNull.Value ? Convert.ToDecimal(row["AmountToPay"]) : 0m,
                            PaymentStatus = row["PaymentStatus"]?.ToString(),
                            AmountPaid = row.Table.Columns.Contains("AmountPaid") && row["AmountPaid"] != DBNull.Value ? Convert.ToDecimal(row["AmountPaid"]) : 0m,
                            ChangeDue = row.Table.Columns.Contains("ChangeDue") && row["ChangeDue"] != DBNull.Value ? Convert.ToDecimal(row["ChangeDue"]) : 0m
                        };

                        return m;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving reservation by id: " + ex.Message);
                throw;
            }
        }

        public List<CustomerReservationModel> GetAll()
        {
            var list = new List<CustomerReservationModel>();

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CustomerReservation ORDER BY ReservationId DESC";
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        da.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            var m = new CustomerReservationModel
                            {
                                ReservationId = row["ReservationId"] != DBNull.Value ? Convert.ToInt32(row["ReservationId"]) : 0,
                                CustomerId = row.Table.Columns.Contains("CustomerId") && row["CustomerId"] != DBNull.Value ? Convert.ToInt32(row["CustomerId"]) : 0,
                                CustomerName = row["CustomerName"]?.ToString(),
                                Gender = row["Gender"]?.ToString(),
                                Nationality = row["Nationality"]?.ToString(),
                                IdType = row["IdType"]?.ToString(),
                                IdNumber = row["IdNumber"]?.ToString(),
                                Contact = row["Contact"]?.ToString(),
                                Email = row["Email"]?.ToString(),
                                Address = row["Address"]?.ToString(),

                                RoomType = row["RoomType"]?.ToString(),
                                RoomNumber = row["RoomNumber"]?.ToString(),
                                ReservationStatus = row["ReservationStatus"]?.ToString(),
                                TimeOfArrival = row.Table.Columns.Contains("TimeOfArrival") && row["TimeOfArrival"] != DBNull.Value ? (TimeSpan?)row["TimeOfArrival"] : null,
                                RoomGuest = row["RoomGuest"]?.ToString(),
                                CheckInDate = row.Table.Columns.Contains("CheckInDate") && row["CheckInDate"] != DBNull.Value ? (DateTime?)row["CheckInDate"] : null,
                                CheckOutDate = row.Table.Columns.Contains("CheckOutDate") && row["CheckOutDate"] != DBNull.Value ? (DateTime?)row["CheckOutDate"] : null,
                                TotalPricePerNight = row.Table.Columns.Contains("TotalPricePerNight") && row["TotalPricePerNight"] != DBNull.Value ? Convert.ToDecimal(row["TotalPricePerNight"]) : 0m,
                                AmountToPay = row.Table.Columns.Contains("AmountToPay") && row["AmountToPay"] != DBNull.Value ? Convert.ToDecimal(row["AmountToPay"]) : 0m,
                                PaymentStatus = row["PaymentStatus"]?.ToString(),
                                AmountPaid = row.Table.Columns.Contains("AmountPaid") && row["AmountPaid"] != DBNull.Value ? Convert.ToDecimal(row["AmountPaid"]) : 0m,
                                ChangeDue = row.Table.Columns.Contains("ChangeDue") && row["ChangeDue"] != DBNull.Value ? Convert.ToDecimal(row["ChangeDue"]) : 0m
                            };

                            list.Add(m);
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving reservations: " + ex.Message);
                throw;
            }
        }
    }
}
