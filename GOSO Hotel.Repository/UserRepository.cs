using GOSO_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSO_Hotel.Repository
{
    public class UserRepository
    {
        private string connectionString;

        public UserRepository()
        {
            this.connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GOSOHotel.DB;Integrated Security=True;TrustServerCertificate=True";
        }

        public UserModel ValidateUser(string Username, string Password, bool isAdmin)
        {

            try
            {
                UserModel matchingUser = new UserModel();
                using (SqlConnection Hotel = new SqlConnection(connectionString))
                {
                    Hotel.Open();
                    string query = null;
                    if (isAdmin)
                    {
                        query = "SELECT * FROM Admin WHERE Username = @username AND Password = @password";
                    }
                    else
                    {
                         query = "SELECT * FROM [Front Desk] WHERE Username = @username AND Password = @password";
                    }
                        SqlCommand command = new SqlCommand(query, Hotel);
                    command.Parameters.AddWithValue("@username", Username);
                    command.Parameters.AddWithValue("@password", Password);


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count >= 1)
                    {
                        matchingUser = new UserModel
                        {
                            Username = Username,
                            Password = Password
                        };
                        return matchingUser;


                    }
                }
            }

            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return null;

        }
    }
}
