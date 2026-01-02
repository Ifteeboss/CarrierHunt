using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CareerOpportunity.Models;
using Npgsql;

namespace CareerOpportunity.DAL
{
    public class UserRepository
    {
        private readonly string connectionString = "Host=localhost;Port =5432;Database=careerhunt;Username=postgres;Password=4343";
        public bool IsUserExists(string userName)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM users WHERE username=@username";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", userName);
                        conn.Open();
                        long count = (long)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("An error occurred while checking if the user exists." + ex.Message,ex);
            }
        }
        public bool ValidateUser(string username, string password)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    conn.Open();
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void AddUser(User user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    string query = "INSERT INTO users (username, password, email) VALUES (@username, @password, @email)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", user.UserName);
                        cmd.Parameters.AddWithValue("password", user.Password);
                        cmd.Parameters.AddWithValue("email", user.Email);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("An error occurred while adding a new user." + ex.Message, ex);
            }
        }
    }
}
